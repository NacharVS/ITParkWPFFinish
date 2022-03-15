using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior : IPersonag
    {

        public Warrior(string name, int minstrenght, int minagility, int minintelligence, int minendurance)
        {
            Name = name;
            _minstrenght = minstrenght;
            _minagility = minagility;
            _minintelligence = minintelligence;
            _minendurance = minendurance;
        }

        [BsonIgnoreIfDefault]
        public Object _id { get; set; }
        [BsonIgnoreIfDefault]
        public string Name { get; set; }
        public int MinStrenght { get => _minstrenght; set => _minstrenght = value; }
        public int MaxStrenght { set => _maxstrenght = value; }
        public int MinAgility { get => _minagility; set => _minagility = value; }
        public int MaxAgility { set => _maxagilityt = value; }
        public int MinIntelligence { get => _minintelligence; set => _minintelligence = value; }
        public int MaxIntelligence { set => _maxintelligence = value; }
        public int MinEndurance { get => _minendurance; set => _minendurance = value; }
        public int MaxEndurance { set => _maxendurance = value; }


        private int _minstrenght = 30;
        private int _maxstrenght = 250;
        private int _minagility = 15;
        private int _maxagilityt = 80;
        private int _minintelligence = 10;
        private int _maxintelligence = 50;
        private int _minendurance = 25;
        private int _maxendurance = 100;

        public static void AddWarriorToDB(string name, int minstrenght, int minagility, int minintelligence, int minendurance)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Warriors");
            collection.InsertOne(new Warrior(name, minstrenght, minagility, minintelligence, minendurance));
        }

        public static List<string> GetWarriorList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Warrior>("Warriors");
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
