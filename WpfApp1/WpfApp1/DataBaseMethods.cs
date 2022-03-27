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
        public static void AddPersonageToDatabase(BasePersonage personage)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<BasePersonage>("Personages");
            collection.InsertOne(personage);
        }
        

        public static List<string> GetListOfBasePersonages()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<IPersonage>("Personages");
            var listPersonagesFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listPersonagesFromDB)
            {
                listToReturn.Add(item.Name.ToString());
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

        public static void ReplacePersonageToDB(BasePersonage personage, string personageName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<BasePersonage>("Personages");
            collection.ReplaceOne(x => x.Name == personageName, personage);
        }
        public static void RemovePersonage(string personageName)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<BasePersonage>("Personages");
            collection.DeleteOne(x => x.Name == personageName);
        }
    }
}
