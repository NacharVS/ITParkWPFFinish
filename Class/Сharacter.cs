﻿using MongoDB.Bson;
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
        protected int _minFreePoints = 0;
        protected int _maxFreePoints;

        public Сharacter(string name, string proffession)
        {
            Name = name;
            Proffession = proffession;
        }

        public virtual string Name { get; set; }

        public virtual string Proffession { get; set; }

        public int Strength
        {
            get => _strength;
            set
            {
                if (_strength > value && _strength > _minStrength && _freePoints < _maxFreePoints)
                {
                    _strength = value;
                    _freePoints += 1;
                }
                if (_strength < value && _strength < _maxStrength && _freePoints > _minFreePoints)
                {
                    _strength = value;
                    _freePoints -= 1;
                }
                else _strength = value;

            }
        }

        public int Agility
        {
            get => _agility;
            set
            {
                if (_agility > value && _agility > _minAgility && _freePoints < _maxFreePoints)
                {
                    _agility = value;
                    FreePoints += 1;
                }
                if (_agility < value && _agility < _maxAgility && _freePoints > _minFreePoints)
                {
                    _agility = value;
                    _freePoints -= 1;
                }
                else _agility = value;
            }
        }

        public int Intelligence
        {
            get => _inteligence;
            set
            {
                if (_inteligence > value && _inteligence > _minIntelligence && _freePoints < _maxFreePoints)
                {
                    _inteligence = value;
                    FreePoints += 1;
                }
                if (_inteligence < value && _inteligence < _maxIntelligence && _freePoints > _minFreePoints)
                {
                    _inteligence = value;
                    _freePoints -= 1;
                }
                else _inteligence = value;
            }
        }

        public int Endurance
        {
            get => _endurance;
            set
            {
                if (_endurance > value && _endurance > _minEndurance && _freePoints < _maxFreePoints)
                {
                    _endurance = value;
                    FreePoints += 1;
                }
                if (_endurance < value && _endurance < _maxEndurance && _freePoints > _minFreePoints)
                {
                    _endurance = value;
                    _freePoints -= 1;
                }
                else _endurance = value;
            }
        }

        [BsonIgnore]
        public virtual int StrengthMin { get; set; }
        [BsonIgnore]
        public virtual int StrengthMax { get; set; }

        [BsonIgnore]
        public virtual int AgilityMin { get; set; }
        [BsonIgnore]
        public virtual int AgilityMax { get; set; }

        [BsonIgnore]
        public virtual int IntelligenceMin { get; set; }
        [BsonIgnore]
        public virtual int IntelligenceMax { get; set; }

        [BsonIgnore]
        public virtual int EnduranceMin { get; set; }
        [BsonIgnore]
        public virtual int EnduranceMax { get; set; }

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
