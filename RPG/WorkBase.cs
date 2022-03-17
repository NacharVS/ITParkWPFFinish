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
        public static void AddPersonagToDB(IPersonag name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<IPersonag>("Personage");
            collection.InsertOne(name);
        }

        public static List<string> GetList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<IPersonag>("Personage");
            var listUsersFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUsersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }

    }
}
