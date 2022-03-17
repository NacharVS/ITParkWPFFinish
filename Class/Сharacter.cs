using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace WpfCharacterEditor
{
    class Сharacter
    {

        [BsonIgnoreIfDefault]
        public ObjectId _id;

        protected int _strength;
        protected int _minStrength;
        protected int _maxStrength;
        protected int _agility;
        protected int _minAgility;
        protected int _maxAgility;
        protected int _inteligence;
        protected int _minIntelligence;
        protected int _maxIntelligence;
        protected int _endurance;
        protected int _minEndurance;
        protected int _maxEndurance;
        protected int _freePoints;
        protected int _minFreePoints;
        protected int _maxFreePoints;

        public Сharacter(string name, string proffession)
        {
            Name = name;
            Proffession = proffession;
        }

        public virtual string Name { get; set; }

        public virtual string Proffession { get; set; }

        public virtual int Strength { get; set; }

        public virtual int Agility { get; set; }

        public virtual int Intelligence { get; set; }

        public virtual int Endurance { get; set; }

        [BsonIgnore]
        public int StrengthMin => _minStrength;
        [BsonIgnore]
        public int StrengthMax => _maxStrength;

        [BsonIgnore]
        public int AgilityMin => _minAgility;
        [BsonIgnore]
        public int AgilityMax => _maxAgility;

        [BsonIgnore]
        public int IntelligenceMin => _minIntelligence;
        [BsonIgnore]
        public int IntelligenceMax => _maxIntelligence;

        [BsonIgnore]
        public int EnduranceMin => _minEndurance;
        [BsonIgnore]
        public int EnduranceMax => _maxEndurance;

        public int FreePoints { get => _freePoints; set { _freePoints = value; } }
        [BsonIgnore]
        public int FreePointsMin => _minFreePoints;
        [BsonIgnore]
        public int FreePointsMax { get => _maxFreePoints; set => _maxFreePoints = value; }


        public virtual int PhysicalDamage { get; }

        public virtual int PhysicalProtection { get; }

        public virtual int MagicalDamage { get; }

        public virtual int MagicalProtection { get; }

        public virtual int Life { get; }

        public virtual int Magic { get; }






    }
}
