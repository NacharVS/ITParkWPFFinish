﻿
using MongoDB.Bson.Serialization.Attributes;

namespace WpfCharacterEditor
{
    class Wizard : Сharacter, ICharacter
    {
        private int _strength;
        private int _minStrength = 15;
        private int _maxStrength = 45;
        private int _agility;
        private int _minAgility = 20;
        private int _maxAgility = 85;
        private int _inteligence;
        private int _minIntelligence = 35;
        private int _maxIntelligence = 250;
        private int _endurance;
        private int _minEndurance = 20;
        private int _maxEndurance = 80;
        private int _freePoints;
        private int _minFreePoints = 0;
        private int _maxFreePoints;

        public Wizard(string name, string proffession, int freePoints) : base(name, proffession)
        {
            _strength = StrengthMin;
            _agility = AgilityMin;
            _inteligence = IntelligenceMin;
            _endurance = EnduranceMin;
            _freePoints = freePoints;
            _maxFreePoints = freePoints;
        }

        public Wizard(string name, string proffession, int strength, int agility, int intelligence, int endurance, int freePoints) : base(name, proffession)
        {
            _strength = strength;
            _agility = agility;
            _inteligence = intelligence;
            _endurance = endurance;
            _freePoints = freePoints;
            _maxFreePoints = freePoints;
        }

        public string Name { get; set; }

        public string Proffession { get; set; }

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
        public int PhysicalDamage { get => _strength * 1 + _agility * 1 + _inteligence * 0 + _endurance * 0; }           
        
        [BsonIgnore]
        public int PhysicalProtection { get => _strength * 1 + _agility * 1 + _inteligence * 1 + _endurance * 2; }

        [BsonIgnore]
        public int MagicalDamage { get => _strength * 0 + _agility * 0 + _inteligence * 7 + _endurance * 0; }
                
        [BsonIgnore]
        public int MagicalProtection { get => _strength * 0 + _agility * 0 + _inteligence * 5 + _endurance * 1; }
        
        [BsonIgnore]
        public int Life { get => _strength * 1 + _agility * 0 + _inteligence * 0 + _endurance * 3; }
        
        [BsonIgnore]
        public int Magic { get => _strength * 0 + _agility * 0 + _inteligence * 2 + _endurance * 0; }

        
    }
}