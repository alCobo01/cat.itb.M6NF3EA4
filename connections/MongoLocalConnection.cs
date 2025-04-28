using MongoDB.Driver;

namespace cat.itb.M6NF3EA3.connections
{
    public class MongoLocalConnection
    {
        private static string URL = "mongodb://localhost:27017/";

       public static IMongoDatabase GetDatabase(string database)
        {
            MongoClient dbClient = new MongoClient(URL);
            return dbClient.GetDatabase(database);
        }

        public static MongoClient GetMongoClient()
        {
            return new MongoClient(URL);
        }
    }
}