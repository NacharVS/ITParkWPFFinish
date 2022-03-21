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

        //public static List<string> GetListOfPersonages()
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Game");
        //    var collection = database.GetCollection<Personage>("Personages");
        //    var listPersonagesFromDB = collection.Find(x => true).ToList();
        //    List<string> listToReturn = new List<string>();
        //    foreach (var item in listPersonagesFromDB)
        //    {
        //        listToReturn.Add(item.name.ToString());
        //    }
        //    return listToReturn;
        //}
        public static List<string> GetListOfWarriors()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Warrior>("Personages");
            var listPersonagesFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listPersonagesFromDB)
            {
                listToReturn.Add(item.name.ToString());
            }
            return listToReturn;
        }
        public static List<string> GetListOfArchers()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Archer>("Personages");
            var listPersonagesFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listPersonagesFromDB)
            {
                listToReturn.Add(item.name.ToString());
            }
            return listToReturn;
        }
        public static List<string> GetListOfShamans()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Shaman>("Personages");
            var listPersonagesFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listPersonagesFromDB)
            {
                listToReturn.Add(item.name.ToString());
            }
            return listToReturn;
        }
    }
}
