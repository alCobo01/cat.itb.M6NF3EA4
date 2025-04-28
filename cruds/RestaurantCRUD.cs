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
           
            var database = MongoLocalConnection.GetDatabase("itb");
            database.DropCollection("restaurants");

            var collection = database.GetCollection<Restaurant>("restaurants");

            if (values != null)
                foreach (var restaurant in values)
                {
                    Console.WriteLine($"Insertant restaurant: {restaurant.Name}");
                    collection.InsertOne(restaurant);
                }

            Console.WriteLine($"S'han insertat {values.Count} restaurants!");
        }

    }
}
