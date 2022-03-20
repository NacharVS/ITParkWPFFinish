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
            var collection1 = database.GetCollection<Archer>("Personage");
            var collection2 = database.GetCollection<Wizard>("Personage");
            var listUsersFromDB = collection.Find(x => true).ToList();
            var listUsersFromDB1 = collection1.Find(x => true).ToList();
            var listUsersFromDB2 = collection2.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            List<string> listToReturn1 = new List<string>();
            List<string> listToReturn2 = new List<string>();
            foreach (var item in listUsersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
            foreach (var item in listUsersFromDB1)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
            foreach (var item in listUsersFromDB2)
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
            var collection1 = database.GetCollection<Archer>("Personage");
            var collection2 = database.GetCollection<Wizard>("Personage");
            var foundedUser = collection.Find(x => x.Name == name).FirstOrDefault();
            var foundedUser1 = collection1.Find(x => x.Name == name).FirstOrDefault();
            var foundedUser2 = collection2.Find(x => x.Name == name).FirstOrDefault();
            return foundedUser;
            return foundedUser1;
            return foundedUser2;
        }

        public static void ReplasePersonage(string name, Warrior NameWarrior, Archer NameArcher, Wizard NameWizard) //Перезапись в БД
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Personage");
            var collection1 = database.GetCollection<Archer>("Personage");
            var collection2 = database.GetCollection<Wizard>("Personage");
            collection.ReplaceOne(x => x.Name == name, NameWarrior);
            collection1.ReplaceOne(x => x.Name == name, NameArcher);
            collection2.ReplaceOne(x => x.Name == name, NameWizard);
        }


        public static void DeletePersonage(string name) //Перезапись в БД. Добавить волшебника и лучника
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Personage");
            var collection1 = database.GetCollection<Archer>("Personage");
            var collection2 = database.GetCollection<Wizard>("Personage");
            collection.DeleteOne<Warrior>(x => x.Name == name);
            collection1.DeleteOne<Archer>(x => x.Name == name);
            collection2.DeleteOne<Wizard>(x => x.Name == name);
        }
    }
}
