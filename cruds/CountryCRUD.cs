using cat.itb.M6NF3EA3.connections;
using cat.itb.M6NF3EA3.models.countries;
using MongoDB.Bson;
using MongoDB.Driver;

namespace cat.itb.M6NF3EA3.cruds
{
    public class CountryCRUD
    {
        private static readonly IMongoDatabase database = MongoLocalConnection.GetDatabase("itb");
        private static readonly IMongoCollection<Country> collection = database.GetCollection<Country>("countries");

        public static void LoadCollection()
        {
            FileInfo file = new FileInfo($"../../../files/countries.json");
            StreamReader sr = file.OpenText();
            string fileString = sr.ReadToEnd();
            sr.Close();

            List<Country> values = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(fileString);

            database.DropCollection("countries");

            if (values != null)
                foreach (var country in values)
                {
                    Console.WriteLine($"Insertant country: {country.Name}");
                    collection.InsertOne(country);
                }

            Console.WriteLine($"S'han insertat {values.Count} countries!");
        }

        public static long GetEnglishCountriesCount()
        {
            var filter = Builders<Country>.Filter.Eq("languages.name", "English");

            AggregateCountResult result = collection.Aggregate()
                .Match(filter)
                .Count()
                .Single();

            return result.Count;
        }

        public static void GetMostCountriesRegion()
        {
            var aggregate = collection.Aggregate()
                .Group(new BsonDocument
                {
                    { "_id", "$region" },
                    { "count", new BsonDocument("$sum", 1) }
                })
                .Sort(new BsonDocument("count", -1))
                .ToList();

            Console.WriteLine(aggregate[0]);
        }

        public static void GetCountriesPerSubregion()
        {
            var aggregate = collection.Aggregate()
                .Group(c => c.Subregion, g => new { Subregion = g.Key, Count = g.Count() })
                .ToList();

            var result = aggregate.ToDictionary(x => x.Subregion, x => x.Count);

            foreach (KeyValuePair<string, int> keyValuePair in result)
            {
                Console.WriteLine($"Subregion: {keyValuePair.Key}, Countries: {keyValuePair.Value}");
            }
        }

        public static void GetMoreLanguagesCountry()
        {
            var aggregate = collection.Aggregate()
                .Group(new BsonDocument
                {
                    { "_id", "$name" },
                    { "count", new BsonDocument("$sum", new BsonDocument("$size", "$languages")) }
                })
                .Sort(new BsonDocument("count", -1))
                .ToList();

            Console.WriteLine(aggregate[0]);
        }

    }
}
