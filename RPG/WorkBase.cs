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
        public static void AddPersonagToDB(IPersonag name) //Добавление в БД
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<IPersonag>("Personage");
            collection.InsertOne(name);
        }

        public static List<string> GetList()  //Нужно добавить добавление из БД остальные классы
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

        public static IPersonag GetPersonag(string name) //Вытаскивание из БД
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Personage");
            var foundedUser = collection.Find(x => x.Name == name).FirstOrDefault();
            return foundedUser;
        }

        public static void ReplasePersonage(string name, IPersonag personag) //Перезапись в БД
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<IPersonag>("Personage");
            collection.ReplaceOne(x => x.Name == name, personag);
        }

    }
}
