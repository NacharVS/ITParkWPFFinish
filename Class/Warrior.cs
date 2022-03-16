﻿
using MongoDB.Bson.Serialization.Attributes;

namespace WpfCharacterEditor
{
    class Warrior : Сharacter, ICharacter
    {
        private int _strength;
        private int _minStrength = 30;
        private int _maxStrength = 250;
        private int _agility;
        private int _minAgility = 15;
        private int _maxAgility = 80;
        private int _inteligence;
        private int _minIntelligence = 10;
        private int _maxIntelligence = 50;
        private int _endurance;
        private int _minEndurance = 25;
        private int _maxEndurance = 100;
        private int _freePoints;
        private int _minFreePoints = 0;
        private int _maxFreePoints;

        public Warrior(string name, string proffession, int freePoints)
        {
            Name = name;
            Proffession = proffession;
            _strength = _minStrength;
            _agility = _minAgility;
            _inteligence = _minIntelligence;
            _endurance = _minEndurance;
            _freePoints = freePoints;
            _maxFreePoints = freePoints;
        }

        public Warrior(string name, string proffession, int strength, int agility, int intelligence, int endurance, int freePoints)
        {
            Name = name;
            Proffession = proffession;
            _strength = strength;
            _agility = agility;
            _inteligence = intelligence;
            _endurance = endurance;
            _freePoints = freePoints;
            _maxFreePoints = freePoints;
        }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Proffession { get; set; }
        [BsonElement("Strength")]
        public int Strength
        {
            get => _strength;
            set
            {
                if (_strength > value && _strength > StrengthMin && FreePoints < FreePointsMax)
                {
                    _strength = value;
                    FreePoints += 1; 
                }
                if (_strength < value && _strength < StrengthMax && FreePoints > FreePointsMin)
                {
                    _strength = value;
                    FreePoints -= 1;
                }
                else _strength = value;

            }
        }

        [BsonIgnore]
        public int StrengthMin => _minStrength;
        [BsonIgnore]
        public int StrengthMax => _maxStrength;
        [BsonElement("Agility")]
        public int Agility
        {
            get => _agility;
            set
            {
                if (_agility > value && _agility > AgilityMin && FreePoints < FreePointsMax)
                {
                    _agility = value;
                    FreePoints += 1;
                }
                if (_agility < value && _agility < AgilityMax && FreePoints > FreePointsMin)
                {
                    _agility = value;
                    FreePoints -= 1;
                }
                else _agility = value;
            }
        }

        [BsonIgnore]
        public int AgilityMin => _minAgility;
        [BsonIgnore]
        public int AgilityMax => _maxAgility;
        [BsonElement("Intelligence")]
        public int Intelligence
        {
            get => _inteligence;
            set
            {
                if (_inteligence > value && _inteligence > IntelligenceMin && FreePoints < FreePointsMax)
                {
                    _inteligence = value;
                    FreePoints += 1;
                }
                if (_inteligence < value && _inteligence < IntelligenceMax && FreePoints > FreePointsMin)
                {
                    _inteligence = value;
                    FreePoints -= 1;
                }
                else _inteligence = value;
            }
        }

        [BsonIgnore]
        public int IntelligenceMin => _minIntelligence;
        [BsonIgnore]
        public int IntelligenceMax => _maxIntelligence;
        [BsonElement("Endurance")]
        public int Endurance
        {
            get => _endurance;
            set
            {
                if (_endurance > value && _endurance > EnduranceMin && FreePoints < FreePointsMax)
                {
                    _endurance = value;
                    FreePoints += 1;
                }
                if (_endurance < value && _endurance < EnduranceMax && FreePoints > FreePointsMin)
                {
                    _endurance = value;
                    FreePoints -= 1;
                }
                else _endurance = value;
            }
        }

        [BsonIgnore]
        public int EnduranceMin => _minEndurance;
        [BsonIgnore]
        public int EnduranceMax => _maxEndurance;
        [BsonElement]
        public int FreePoints
        {
            get => _freePoints;
            set
            {
                _freePoints = value;
            }
        }

        [BsonIgnore]
        public int FreePointsMin => _minFreePoints;
        [BsonIgnore]
        public int FreePointsMax { get => _maxFreePoints; set => _maxFreePoints = value; }

        [BsonIgnore]
        public int PhysicalDamage { get => _strength * 7 + _agility * 2 + _inteligence * 0 + _endurance * 0; }           
        
        [BsonIgnore]
        public int PhysicalProtection { get => _strength * 2 + _agility * 3 + _inteligence * 0 + _endurance * 3; }

        [BsonIgnore]
        public int MagicalDamage { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }
                
        [BsonIgnore]
        public int MagicalProtection { get => _strength * 1 + _agility * 0 + _inteligence * 2 + _endurance * 1; }
        
        [BsonIgnore]
        public int Life { get => _strength * 5 + _agility * 0 + _inteligence * 0 + _endurance * 10; }
        
        [BsonIgnore]
        public int Magic { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }

        
    }
}
