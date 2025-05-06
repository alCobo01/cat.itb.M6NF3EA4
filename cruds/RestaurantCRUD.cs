using cat.itb.M6NF3EA3.connections;
using cat.itb.M6NF3EA3.models.restaurants;
using cat.itb.M6NF3EA3;
using MongoDB.Bson;
using MongoDB.Driver;
using cat.itb.M6NF3EA3.models.countries;

namespace cat.itb.M6NF3EA3.cruds
{
    public class RestaurantCRUD
    {
        private static readonly IMongoDatabase database = MongoLocalConnection.GetDatabase("itb");
        private static readonly IMongoCollection<Restaurant> collection = database.GetCollection<Restaurant>("restaurants");

        public static void LoadCollection()
        {
            FileInfo file = new FileInfo($"../../../files/restaurants.json");

            List<Restaurant> values = new List<Restaurant>();
            foreach (var line in File.ReadLines(file.FullName))
            {
                var restaurant = Newtonsoft.Json.JsonConvert.DeserializeObject<Restaurant>(line);
                if (restaurant != null)
                    values.Add(restaurant);
            }
           
            database.DropCollection("restaurants");

            if (values != null)
                foreach (var restaurant in values)
                {
                    Console.WriteLine($"Insertant restaurant: {restaurant.Name}");
                    collection.InsertOne(restaurant);
                }

            Console.WriteLine($"S'han insertat {values.Count} restaurants!");
        }

        public static void ShowPostalCodesByBorough()
        {
            var aggregate = collection.Aggregate()
                .Group(new BsonDocument
                {
                    { "_id", "$borough" },
                    { "postalCodes", new BsonDocument("$addToSet", "$address.zipcode") }
                })
                .Sort(new BsonDocument("_id", 1))
                .ToList();

            Console.WriteLine("Codis postals per barri:");
            Console.WriteLine("------------------------");

            foreach (var result in aggregate)
            {
                string borough = result["_id"].ToString();
                var postalCodes = result["postalCodes"].AsBsonArray;

                Console.WriteLine($"Barri: {borough}");
                Console.WriteLine("Codis postals:");

                foreach (var code in postalCodes)
                {
                    Console.WriteLine($"  - {code}");
                }
                Console.WriteLine();
            }
        }

        public static void ShowRestaurantsPerCuisine()
        {
            var aggregate = collection.Aggregate()
                .Group(new BsonDocument
                {
                    { "_id", "$cuisine" },
                    { "numRestaurants", new BsonDocument("$sum", 1) }
                })
                .Sort(new BsonDocument("numRestaurants", -1))
                .ToList();

            Console.WriteLine("Nombre de restaurants per cuina");
            Console.WriteLine("------------------------");

            foreach (var result in aggregate)
            {
                string cuisine = result["_id"].ToString();
                string numRestaurants = result["numRestaurants"].ToString();

                Console.WriteLine($"{cuisine}: {numRestaurants}");
            }
        }

        public static void ShowNumberOfScores()
        {
            var aggregate = collection.Aggregate()
                .Unwind("Grades")
                .Group(new BsonDocument
                {
                    { "_id", "$grades.score" },
                    { "count", new BsonDocument("$sum", 1) }
                })
                .Project(new BsonDocument
                {
                    { "Score", "$_id" },
                    { "count", 1 },
                    { "_id", 0 }
                })
                .Sort(new BsonDocument("Score", -1))
                .ToList();

            Console.WriteLine("Nombre de vegades que apareix cada score");
            Console.WriteLine("------------------------");

            foreach (var result in aggregate)
            {
                string score = result["Score"].ToString();
                string count = result["count"].ToString();
                Console.WriteLine($"Score: {score}, Count: {count}");
            }
        }

        public static void ShowNumberOfGradesPerRestaurant()
        {
            var aggregate = collection.Aggregate()
                .Project(new BsonDocument
                {
                   { "Name", "$name" },
                   { "gradesCount", new BsonDocument("$size", "$grades") }
                })
                .Sort(new BsonDocument("gradesCount", -1))
                .ToList();

            Console.WriteLine("Nombre de valoracions per restaurant:");
            Console.WriteLine("--------------------------------------");

            foreach (var result in aggregate)
            {
                string name = result["Name"].ToString();
                string gradesCount = result["gradesCount"].ToString();
                Console.WriteLine($"Restaurant: {name}, Valoracions: {gradesCount}");
            }
        }

        public static void ShowCuisinesByBorough()
        {
            var aggregate = collection.Aggregate()
                .Group(new BsonDocument
                {
                   { "_id", "$borough" },
                   { "cuisines", new BsonDocument("$addToSet", "$cuisine") }
                })
                .Sort(new BsonDocument("_id", 1))
                .ToList();

            Console.WriteLine("Tipus de cuina per barri:");
            Console.WriteLine("--------------------------");

            foreach (var result in aggregate)
            {
                string borough = result["_id"].ToString();
                var cuisines = result["cuisines"].AsBsonArray;

                Console.WriteLine($"Barri: {borough}");
                Console.WriteLine("Tipus de cuina:");

                foreach (var cuisine in cuisines)
                {
                    Console.WriteLine($"  - {cuisine}");
                }
                Console.WriteLine();
            }
        }
        public static void ShowHighestScorePerRestaurant()
        {
            var aggregate = collection.Aggregate()
                .Project(new BsonDocument
                {
                    { "Name", "$name" },
                    { "highestScore", new BsonDocument("$max", "$grades.score") }
                })
                .Sort(new BsonDocument("highestScore", -1))
                .ToList();

            Console.WriteLine("Puntuació més alta per restaurant:");
            Console.WriteLine("----------------------------------");

            foreach (var result in aggregate)
            {
                string name = result["Name"].ToString();
                string highestScore = result["highestScore"].ToString();
                Console.WriteLine($"Restaurant: {name}, Puntuació més alta: {highestScore}");
            }
        }



    }
}
