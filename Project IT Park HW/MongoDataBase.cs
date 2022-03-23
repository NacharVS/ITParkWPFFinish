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
        public static void AddUnitToDB(string name, string classes, int strenght, int agility, int intellect, int endurance, int level, int experience, int point)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Archer>("Units");
            collection.InsertOne(new Archer(name, classes, strenght, agility, intellect, endurance, level, experience, point));
        }
        public static List<string> GetUnitList()
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
        public static List<string> GetClassUnitList()
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
        public static void RemoveUnit(string deleteUnit)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Units");
            collection.DeleteOne(x => x.Name == deleteUnit);
        }
        public static void RemoveClass(string deleteClass)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Units");
            collection.DeleteOne(x => x.Name == deleteClass);
        }
        public static string FindUser(string userName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Units");
            var foundedUser = collection.Find(x => x.Name == userName).FirstOrDefault();
            if (foundedUser == null)
            {
                return null;
            }
            else
            {
                string foundedName = foundedUser.Name;
                return foundedName;
            }
        }
        public static Character GetCharacter(string userName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Units");
            var foundedUser = collection.Find(x => x.Name == userName).FirstOrDefault();
            return foundedUser;
        }
        public static void ReplaceUnit(Archer user, string userName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Archer>("Units");
            collection.ReplaceOne(x => x.Name == userName, user);
        }
    }
}

