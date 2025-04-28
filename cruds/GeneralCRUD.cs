using cat.itb.M6NF3EA3.connections;
using MongoDB.Bson;
using MongoDB.Driver;

namespace cat.itb.M6NF3EA3.cruds
{
    public static class GeneralCRUD
    {
        public static void DropCollection<T>(string database, string collection)
        {
            var db = MongoLocalConnection.GetDatabase(database);
            var col = db.GetCollection<T>(collection);

            var emptyFilter = Builders<T>.Filter.Empty;
            long documentCount = col.CountDocuments(emptyFilter);
            Console.WriteLine($"La col·lecció '{collection}' conté {documentCount} documents.");

            db.DropCollection(collection);
            Console.WriteLine($"La col·lecció '{collection}' ha estat eliminada.");

            Console.WriteLine($"\nCol·leccions restants a la base de dades '{database}':");
            using (var cursor = db.ListCollectionNames())
            {
                foreach (var collectionName in cursor.ToEnumerable())
                {
                    Console.WriteLine($"- {collectionName}");
                }
            }
        }
    }
}
