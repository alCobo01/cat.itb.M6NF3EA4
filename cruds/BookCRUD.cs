using cat.itb.M6NF3EA3.connections;
using cat.itb.M6NF3EA3.models.books;
using cat.itb.M6NF3EA3;
using MongoDB.Bson;
using MongoDB.Driver;

namespace cat.itb.M6NF3EA3.cruds
{
    public class BookCRUD
    {
        public static void LoadCollection()
        {
            FileInfo file = new FileInfo($"../../../files/books.json");
            StreamReader sr = file.OpenText();
            string fileString = sr.ReadToEnd();
            sr.Close();

            List<Book> values = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Book>>(fileString);

            var database = MongoLocalConnection.GetDatabase("itb");
            database.DropCollection("books");
            
            var collection = database.GetCollection<Book>("books");

            if (values != null)
                foreach (var book in values)
                {
                    Console.WriteLine($"Inserting book: {book.Title}");
                    collection.InsertOne(book);
                }
        }

        public static IMongoCollection<Book> GetAll()
        {
            var database = MongoLocalConnection.GetDatabase("itb");
            var collection = database.GetCollection<Book>("books");

            return collection;
        }


    }
}
