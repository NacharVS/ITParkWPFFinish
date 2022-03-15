using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class WorkBase
    {
        public static void AddWarriorToDB(Warrior warrior)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Personage");
            collection.InsertOne(warrior);
        }

        public static List<string> GetList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Personage");
            var listUsersFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUsersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }

        //public static Warrior GetWarrior(string name)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Registration");
        //    var collection = database.GetCollection<Warrior>("Personage");
        //    var foundedUser = collection.Find(x => x.Name == name).FirstOrDefault();
        //    return foundedUser;
        //}
    }
}
