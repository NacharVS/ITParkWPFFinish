using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class MongoAPI
    {
        
        public void ConectionBD()
        {

        }

        public static void AddPersonageToDataBase(Рersonage рersonage)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Рersonage>("Personage");
            collection.InsertOne(рersonage);
        }

        public static void EditPersonageToDataBase(Рersonage personage, Dictionary<string, object> propertiesChange)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Рersonage>("Personage");

            var filter = new BsonDocument("_id", personage._id);

            foreach (var property in propertiesChange)
            {
                if(property.Value != null)
                {
                    var update = Builders<Рersonage>.Update.Set(property.Key, property.Value);
                    collection.UpdateOne(filter, update);
                }
            }          
        }

        public static void DeletePersanageFromDataBase(Рersonage рersonage)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Рersonage>("Personage");

            var filter = new BsonDocument("_id", рersonage._id);
            collection.DeleteOne(filter);
        }

        public static List<Warrior> GetWarriorFromDataBase()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Warrior>("Personage");
            return collection.Find(x => x.CharacterType == "Воин").ToList();
        }

        public static List<Archer> GetArcherFromDataBase()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Personage");
            return collection.Find(x => x.CharacterType == "Лучник").ToList();
        }

        public static List<Magician> GetMagicianFromDataBase()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client?.GetDatabase("Game");
            var collection = database?.GetCollection<Magician>("Personage");
            return collection?.Find(x => x.CharacterType == "Волшебник").ToList();
        }

        public static List<Рersonage> GetPersonageFromDataBase()
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client?.GetDatabase("Game");
            var collection = database?.GetCollection<Рersonage>("Personage");
            return collection?.Find(x => true).ToList();
        }
    }
}
