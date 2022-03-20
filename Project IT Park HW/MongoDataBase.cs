using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IT_Park_HW
{
    class MongoDataBase
    {
        public static void AddArcherToDB(string name, string profession, int strenght, int agility, int intelligenсe, int stamina, int level, int experiense, int freePoint)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Archer>("Unit");
            collection.InsertOne(new Archer(name, profession, strenght, agility, intelligenсe, stamina, level, experiense, freePoint));
        }
        public static void AddMageToDB(string name, string profession, int strenght, int agility, int intelligenсe, int stamina, int level, int experiense, int freePoint)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Mage>("Unit");
            collection.InsertOne(new Mage(name, profession, strenght, agility, intelligenсe, stamina, level, experiense, freePoint));
        }
        public static void AddWarriorToDB(string name, string profession, int strenght, int agility, int intelligenсe, int stamina, int level, int experiense, int freePoint)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Unit");
            collection.InsertOne(new Warrior(name, profession, strenght, agility, intelligenсe, stamina, level, experiense, freePoint));
        }
        public static List<string> GetArcherList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Archer>("Units");
            var listUnitsFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUnitsFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
        public static List<string> GetMageList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Mage>("Units");
            var listUnitsFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUnitsFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
        public static List<string> GetWarriorList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Units");
            var listUnitsFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUnitsFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
        public static List<string> GetClassArcherList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Archer>("Units");
            var listUnitsFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUnitsFromDB)
            {
                listToReturn.Add(item.Classes);
            }
            return listToReturn;
        }
        public static List<string> GetClassMageList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Mage>("Units");
            var listUnitsFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUnitsFromDB)
            {
                listToReturn.Add(item.Classes);
            }
            return listToReturn;
        }
        public static List<string> GetClassWariiorList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Units");
            var listUnitsFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUnitsFromDB)
            {
                listToReturn.Add(item.Classes);
            }
            return listToReturn;
        }
    }
}

