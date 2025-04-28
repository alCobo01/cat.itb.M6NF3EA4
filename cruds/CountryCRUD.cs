using cat.itb.M6NF3EA3.connections;
using cat.itb.M6NF3EA3.models.countries;
using MongoDB.Driver;

namespace cat.itb.M6NF3EA3.cruds
{
    public class CountryCRUD
    {
        public static void LoadCollection()
        {
            FileInfo file = new FileInfo($"../../../files/countries.json");
            StreamReader sr = file.OpenText();
            string fileString = sr.ReadToEnd();
            sr.Close();

            List<Country> values = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(fileString);

            var database = MongoLocalConnection.GetDatabase("itb");
            database.DropCollection("countries");

            var collection = database.GetCollection<Country>("countries");

            if (values != null)
                foreach (var country in values)
                {
                    Console.WriteLine($"Insertant country: {country.Name}");
                    collection.InsertOne(country);
                }

            Console.WriteLine($"S'han insertat {values.Count} countries!");
        }

        public static List<Country> GetEnglishCountries()
        {
            var database = MongoLocalConnection.GetDatabase("itb");
            var collection = database.GetCollection<Country>("countries");

            var filter = Builders<Country>.Filter.ElemMatch(
                c => c.Languages,
                lang => lang.Name == "English"
            );

            AggregateCountResult result = collection.Aggregate

            return aggregate;
        }
    }
}
