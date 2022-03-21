using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class DataBaseMethods
    {
        public static void AddPersonageToDatabase(Personage personage)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Personage>("Personages");
            collection.InsertOne(personage);
        }
        public static void AddWarriorToDatabase(Warrior personage)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Warrior>("Personages");
            collection.InsertOne(personage);
        }
        public static void AddArcherToDatabase(Archer personage)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Personages");
            collection.InsertOne(personage);
        }
        public static void AddShamanToDatabase(Shaman personage)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Shaman>("Personages");
            collection.InsertOne(personage);
        }

        
        public static List<string> GetListOfBasePersonages()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<BasePersonage>("Personages");
            var listPersonagesFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listPersonagesFromDB)
            {
                listToReturn.Add(item.name.ToString());
            }
            return listToReturn;
        }
        public static BasePersonage GetPersonage(string personageName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<BasePersonage>("Personages");
            var foundedPersonage = collection.Find(x => x.Name == personageName).FirstOrDefault();
            return foundedPersonage;
        }
    }
}
