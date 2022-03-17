using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class MongoDB
    {

        public static void AddToDataBase(ICharacter character)
        {
            MongoClient client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<ICharacter>("Сharacters");
            collection.InsertOne(character);
        }
        //public static List<ICharacter> GetFromCollection()
        //{
        //    MongoClient client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Сharacters");
        //    var collection = database.GetCollection<ICharacter>("Сharacters");
        //    return collection.Find(x => true).ToList();
        //}

        
        public static void ArcherAddToDB(string name, string proffession, double strength, double agility, double intelligence, double endurance)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Archer>("Сharacters");
            collection.InsertOne(new Archer(name, proffession, strength, agility, intelligence, endurance));
        }
        public static List<string> ArcherGetList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Archer>("Сharacters");
            var listFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new();
            foreach (var item in listFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
        public static void MageAddToDB(string name, string proffession, double strength, double agility, double intelligence, double endurance)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Mage>("Сharacters");
            collection.InsertOne(new Mage(name, proffession, strength, agility, intelligence, endurance));
        }
        public static List<string> MageGetList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Mage>("Сharacters");
            var listFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new();
            foreach (var item in listFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }

        public static void WarriorAddToDB(string name, string proffession, double strength, double agility, double intelligence, double endurance)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Warrior>("Сharacters");
            collection.InsertOne(new Warrior(name, proffession, strength, agility, intelligence, endurance));
        }
        public static List<string> WarriorGetList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Warrior>("Сharacters");
            var listFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new();
            foreach (var item in listFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
        public static Archer GetArcher(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Archer>("Сharacters");
            var FoundUser = collection.Find(x => x.Name == name).FirstOrDefault();

            return FoundUser;
        }

    }
}
