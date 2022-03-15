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
        public int MinStrenght { get => _minstrenght=30; set => _minstrenght = value; }
        public int MaxStrenght { set => _maxstrenght = 250; }
        public int MinAgility { get => _minagility=15; set => _minagility = value; }
        public int MaxAgility { set => _maxagilityt = 80; }
        public int MinIntelligence { get => _minintelligence=10; set => _minintelligence = value; }
        public int MaxIntelligence { set => _maxintelligence = 50; }
        public int MinEndurance { get => _minendurance=25; set => _minendurance = value; }
        public int MaxEndurance { set => _maxendurance = 100; }
        [BsonIgnore]
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [BsonIgnore]
        public int Protection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [BsonIgnore]
        public int MagicDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [BsonIgnore]
        public int MagicProtection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [BsonIgnore]
        public int Life { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [BsonIgnore]
        public int Magic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int _minstrenght;
         int _maxstrenght;
         int _minagility;
         int _maxagilityt;
         int _minintelligence;
         int _maxintelligence;
         int _minendurance;
         int _maxendurance;

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
