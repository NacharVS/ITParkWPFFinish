using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkWPFFinish
{
    class Mongo
    {
        public static void AddToDB(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TestCharacters");
            var collection = database.GetCollection<Character>("qq");
            collection.InsertOne(character);
        }

        public static void FindAll()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("TestCharacters");
            var collection = database.GetCollection<Character>("qq");
            var list = collection.Find(x => true).ToList();
        }
    }
}
