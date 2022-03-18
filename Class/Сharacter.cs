using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace WpfCharacterEditor
{
    class Сharacter
    {

        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonElement]
        protected int _strength;
        [BsonElement]
        protected int _agility;
        [BsonElement]
        protected int _inteligence;
        [BsonElement]
        protected int _endurance;
        
        protected int _freePoints;
        protected int _minFreePoints = 0;
        protected int _maxFreePoints;

        public Сharacter(string name, string proffession)
        {
            Name = name;
            Proffession = proffession;
        }

        public virtual string Name { get; set; }

        public virtual string Proffession { get; set; }
        [BsonIgnore]
        public int Strength
        {
            get => _strength;
            set
            {
                if (_strength > value && _strength > StrengthMin && FreePoints < _maxFreePoints)
                {
                    _strength = value;
                    _freePoints += 1;
                }
                if (_strength < value && _strength < StrengthMax && FreePoints > _minFreePoints)
                {
                    _strength = value;
                    FreePoints -= 1;
                }
                //else _strength = value;

            }
        }
        [BsonIgnore]
        public int Agility
        {
            get => _agility;
            set
            {
                if (_agility > value && _agility > AgilityMin && FreePoints < _maxFreePoints)
                {
                    _agility = value;
                    FreePoints += 1;
                }
                if (_agility < value && _agility < AgilityMax && FreePoints > _minFreePoints)
                {
                    _agility = value;
                    FreePoints -= 1;
                }
                //else _agility = value;
            }
        }
        [BsonIgnore]
        public int Intelligence
        {
            get => _inteligence;
            set
            {
                if (_inteligence > value && _inteligence > IntelligenceMin && FreePoints < _maxFreePoints)
                {
                    _inteligence = value;
                    FreePoints += 1;
                }
                if (_inteligence < value && _inteligence < IntelligenceMax && FreePoints > _minFreePoints)
                {
                    _inteligence = value;
                    FreePoints -= 1;
                }
                //else _inteligence = value;
            }
        }
        [BsonIgnore]
        public int Endurance
        {
            get => _endurance;
            set
            {
                if (_endurance > value && _endurance > EnduranceMin && FreePoints < _maxFreePoints)
                {
                    _endurance = value;
                    FreePoints += 1;
                }
                if (_endurance < value && _endurance < EnduranceMax && FreePoints > _minFreePoints)
                {
                    _endurance = value;
                    FreePoints -= 1;
                }
                //else _endurance = value;
            }
        }

        [BsonIgnore]
        public virtual int StrengthMin { get; }
        [BsonIgnore]
        public virtual int StrengthMax { get; }

        [BsonIgnore]
        public virtual int AgilityMin { get; }
        [BsonIgnore]
        public virtual int AgilityMax { get; }

        [BsonIgnore]
        public virtual int IntelligenceMin { get; }
        [BsonIgnore]
        public virtual int IntelligenceMax { get; }

        [BsonIgnore]
        public virtual int EnduranceMin { get; }
        [BsonIgnore]
        public virtual int EnduranceMax { get; }

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
