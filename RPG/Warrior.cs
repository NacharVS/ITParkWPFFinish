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
        public Warrior(string name, string @class, int minstrenght, int minagility, int minintelligence, int minendurance)
        {
            Name = name;
            Class = @class;
            _minstrenght = minstrenght;
            _minagility = minagility;
            _minintelligence = minintelligence;
            _minendurance = minendurance;
        }

        [BsonIgnoreIfDefault]
        public Object _id { get; set; }
        [BsonIgnoreIfDefault]
        public string Name { get; set; }
        [BsonIgnoreIfDefault]
        public string Class { get; set; }
        [BsonElement("Strenght")]
        public int MinStrenght { get => _minstrenght=30; set => _minstrenght = value; }
        public int MaxStrenght { set => _maxstrenght = 250; }
        [BsonElement("Agility")]
        public int MinAgility { get => _minagility=15; set => _minagility = value; }
        public int MaxAgility { set => _maxagilityt = 80; }
        [BsonElement("Intelligence")]
        public int MinIntelligence { get => _minintelligence=10; set => _minintelligence = value; }
        public int MaxIntelligence { set => _maxintelligence = 50; }
        [BsonElement("Endurance")]
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

    }
}
