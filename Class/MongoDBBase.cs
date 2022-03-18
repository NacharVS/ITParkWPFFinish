using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor.Class
{
    class MongoDBBase
    {
        public static void SetWarrior(Сharacter warrior)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Warriors");
            collection.InsertOne(warrior);
        }

        public static List<string> GetListWarriors()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Warriors");
            var listCharactersFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listCharactersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }

        public static Сharacter GetWarrior(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Warriors");
            var foundedWarrior = collection.Find(x => x.Name == name).FirstOrDefault();
            return foundedWarrior;
        }
    }
}
