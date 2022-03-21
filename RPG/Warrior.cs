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
        [BsonIgnore]
        public static int MinStrenght { get {return _minstrenght;}}
        [BsonIgnore]
        public int MaxStrenght { get { return _maxstrenght; } }
        [BsonIgnore]
        public static int MinAgility { get { return _minagility; } }
        [BsonIgnore]
        public int MaxAgility { get { return _maxagilityt; } }
        [BsonIgnore]
        public static int MinIntelligence { get { return _minintelligence; } }
        [BsonIgnore]
        public int MaxIntelligence { get { return _maxintelligence; } }
        [BsonIgnore]
        public static int MinEndurance { get { return _minendurance; } }
        [BsonIgnore]
        public int MaxEndurance { get { return _maxendurance; } }
        [BsonIgnore]
        public static int Damage { get => strenght * 7 + agility * 2 + intelligence * 0 + endurance * 0; }
        [BsonIgnore]
        public static int Protection { get => strenght * 2 + agility * 3 + intelligence * 0 + endurance * 3; }
        [BsonIgnore]
        public static int MagicDamage { get => strenght * 0 + agility * 0 + intelligence * 1 + endurance * 0; }
        [BsonIgnore]
        public static int MagicProtection { get => strenght * 1 + agility * 0 + intelligence * 2 + endurance * 1; }
        [BsonIgnore]
        public static int Life { get => strenght * 5 + agility * 0 + intelligence * 0 + endurance * 10; }
        [BsonIgnore]
        public static int Magic { get => strenght * 0 + agility * 0 + intelligence * 1 + endurance * 0; }
        public int Strenght { get => strenght; set => strenght = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Endurance { get => endurance; set => endurance=value; }

        public int  Exp { get => _exp; set => _exp = value; }

        private static int _minstrenght=30;
        int _maxstrenght=250;
        static int _minagility =15;
        int _maxagilityt=80;
        static int _minintelligence =10;
        int _maxintelligence=50;
        static int _minendurance =25;
        int _maxendurance=100;
        static int strenght ;
        static int agility ;
        static int intelligence ;
        static int endurance ;
        static int level =1;
        static int points =0;
        static int _exp=0;
        

        public Warrior(string name, string @class, int _exp, int level, int points, int strenght, int agility, int intelligence, int endurance)
        {
            Name = name;
            Class = @class;
            Level = level;
            Points = points;
            Strenght = strenght;
            Agility = agility;
            Intelligence = intelligence;
            Endurance = endurance;
            Exp = _exp;
        }

    }

}
