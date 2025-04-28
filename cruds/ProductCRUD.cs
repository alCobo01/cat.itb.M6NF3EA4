using cat.itb.M6NF3EA3.connections;
using cat.itb.M6NF3EA3.models.products;
using MongoDB.Driver;

namespace cat.itb.M6NF3EA3.cruds
{
    public class ProductCRUD
    {
        public static void LoadCollection()
        {
            FileInfo file = new FileInfo($"../../../files/products.json");

            var database = MongoLocalConnection.GetDatabase("itb");
            database.DropCollection("products");

            var collection = database.GetCollection<Product>("products");

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
            var database = MongoLocalConnection.GetDatabase("itb");
            var collection = database.GetCollection<Product>("products");

            var products = collection.AsQueryable().ToList();
            var highestPriceProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();

            return highestPriceProduct;
        }

        public static int GetTotalStock()
        {
            var database = MongoLocalConnection.GetDatabase("itb");
            var collection = database.GetCollection<Product>("products");

            var products = collection.AsQueryable().ToList();
            int totalStock = products.Sum(p => p.Stock);

            return totalStock;
        }
    }
}
