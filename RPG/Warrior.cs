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

        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonIgnoreIfDefault]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public string Class { get; set; }
        public int Level { get => level; set => level=value; }
        public int Points { get => points; set => points=value; }
        [BsonElement("Strenght")]
        public static int MinStrenght { get {return _minstrenght;}}
        [BsonIgnore]
        public int MaxStrenght { get { return _maxstrenght; } }
        [BsonElement("Agility")]
        public static int MinAgility { get { return _minagility; } }
        [BsonIgnore]
        public int MaxAgility { get { return _maxagilityt; } }
        [BsonElement("Intelligence")]
        public static int MinIntelligence { get { return _minintelligence; } }
        [BsonIgnore]
        public int MaxIntelligence { get { return _maxintelligence; } }
        [BsonElement("Endurance")]
        public static int MinEndurance { get { return _minendurance; } }
        [BsonIgnore]
        public int MaxEndurance { get { return _maxendurance; } }
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
        public int Strenght { get => strenght; set => strenght = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Endurance { get => endurance; set => endurance=value; }


        static int _minstrenght=30;
        int _maxstrenght=250;
        static int _minagility =15;
        int _maxagilityt=80;
        static int _minintelligence =10;
        int _maxintelligence=50;
        static int _minendurance =25;
        int _maxendurance=100;
        int strenght;
        int agility;
        int intelligence;
        int endurance;
        int level;
        int points;

        public Warrior(string name, string @class, int level, int points, int strenght, int agility, int intelligence, int endurance)
        {
            Name = name;
            Class = @class;
            Level = level;
            Points = points;
            Strenght = strenght;
            Agility = agility;
            Intelligence = intelligence;
            Endurance = endurance;
        }











        //public Warrior(string name, string @class, int minstrenght, int minagility, int minintelligence, int minendurance)
        //{
        //    Name = name;
        //    Class = @class;
        //    _minstrenght = minstrenght;
        //    _minagility = minagility;
        //    _minintelligence = minintelligence;
        //    _minendurance = minendurance;
        //}

        //[BsonIgnoreIfDefault]
        //public Object _id { get; set; }
        //[BsonIgnoreIfDefault]
        //public string Name { get; set; }
        //[BsonIgnoreIfDefault]
        //public string Class { get; set; }
        //[BsonElement("Strenght")]
        //public int MinStrenght { get => _minstrenght=30; }
        //[BsonIgnore]
        //public int MaxStrenght { get => _maxstrenght=250; }
        //[BsonIgnore]
        //[BsonElement("Agility")]
        //public int MinAgility { get => _minagility=15; }
        //[BsonIgnore]
        //public int MaxAgility { get => _maxagilityt = 80; }
        //[BsonIgnore]
        //[BsonElement("Intelligence")]
        //public int MinIntelligence { get => _minintelligence = 10; }
        //[BsonIgnore]
        //public int MaxIntelligence { get => _maxintelligence = 50; }
        //[BsonIgnore]
        //[BsonElement("Endurance")]
        //public int MinEndurance { get => 25;  }
        //[BsonIgnore]
        //public int MaxEndurance { get => _maxendurance = 100; }
        //[BsonIgnore]
        //public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[BsonIgnore]
        //public int Protection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[BsonIgnore]
        //public int MagicDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[BsonIgnore]
        //public int MagicProtection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[BsonIgnore]
        //public int Life { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[BsonIgnore]
        //public int Magic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        //int _minstrenght;
        // int _maxstrenght;
        // int _minagility;
        // int _maxagilityt;
        // int _minintelligence;
        // int _maxintelligence;
        // int _minendurance;
        // int _maxendurance;
    }

}
