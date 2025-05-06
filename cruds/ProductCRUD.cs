using cat.itb.M6NF3EA3.connections;
using cat.itb.M6NF3EA3.models.products;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;
using System.Xml.Linq;

namespace cat.itb.M6NF3EA3.cruds
{
    public class ProductCRUD
    {
        private static readonly IMongoDatabase database = MongoLocalConnection.GetDatabase("itb");
        private static readonly IMongoCollection<Product> collection = database.GetCollection<Product>("products");

        public static void LoadCollection()
        {
            FileInfo file = new FileInfo($"../../../files/products.json");

            database.DropCollection("products");

            using (StreamReader sr = file.OpenText())
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Product product = Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(line);
                    Console.WriteLine($"Inserting product: {product.Name}");
                    collection.InsertOne(product);
                }
            }
        }

        public static Product GetHighestPrice()
        {
            var products = collection.AsQueryable().ToList();
            var highestPriceProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();

            return highestPriceProduct;
        }

        public static int GetTotalStock()
        {
            var products = collection.AsQueryable().ToList();
            int totalStock = products.Sum(p => p.Stock);

            return totalStock;
        }

        public static void DisplayCategoryCount()
        {
            var categoryCounts = collection.Aggregate()
                .Project(product => new
                {
                    Name = product.Name,
                    CategoryCount = product.Categories != null ? product.Categories.Count : 0
                })
                .ToList();

            foreach (var item in categoryCounts)
            {
                Console.WriteLine($"Product: {item.Name}, Categories Count: {item.CategoryCount}");
            }
        }

        public static void GetAllCategories()
        {
            var aggregate = collection.Aggregate()
                .Unwind("categories")
                .Group(new BsonDocument { { "_id", "$categories" } })
                .ToList();

            foreach (var item in aggregate)
            {
                Console.WriteLine(item["_id"]);
            }
        }
    }
}
