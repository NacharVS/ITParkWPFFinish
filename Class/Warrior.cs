
using MongoDB.Bson.Serialization.Attributes;

namespace WpfCharacterEditor
{
    class Warrior : Сharacter, ICharacter
    {
        private int _strength;
        private int _minStrength;
        private int _maxStrength;
        private int _agility;
        private int _minAgility;
        private int _maxAgility;
        private int _inteligence;
        private int _minIntelligence;
        private int _maxIntelligence;
        private int _endurance;
        private int _minEndurance;
        private int _maxEndurance;
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

            SetMinMax(proffession);
            
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

            SetMinMax(proffession);
        }

        private void SetMinMax(string proffession)
        {
            if (Proffession == "Warrior")
            {
                _minStrength = 30;
                _maxStrength = 250;
                _minAgility = 15;
                _maxAgility = 80;
                _minIntelligence = 10;
                _maxIntelligence = 50;
                _minEndurance = 25;
                _maxEndurance = 100;
            }
            if (Proffession == "Archer")
            {
                _minStrength = 20;
                _maxStrength = 55;
                _minAgility = 30;
                _maxAgility = 250;
                _minIntelligence = 15;
                _maxIntelligence = 70;
                _minEndurance = 20;
                _maxEndurance = 80;
            }
            if (Proffession == "Wizard")
            {
                _minStrength = 15;
                _maxStrength = 45;
                _minAgility = 20;
                _maxAgility = 85;
                _minIntelligence = 35;
                _maxIntelligence = 250;
                _minEndurance = 20;
                _maxEndurance = 80;
            }
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

        public int PhysicalDamageMethod()
        {
            if (Proffession == "Warrior") return _strength * 7 + _agility * 2 + _inteligence * 0 + _endurance * 0;

            else if (Proffession == "Archer") return _strength * 3 + _agility * 7 + _inteligence * 0 + _endurance * 0;

            else if (Proffession == "Wizard") return _strength * 7 + _agility * 2 + _inteligence * 0 + _endurance * 0;

            else return 0;
        }

        public int PhysicalProtectionMethod()
        {
            if (Proffession == "Warrior") return _strength * 2 + _agility * 3 + _inteligence * 0 + _endurance * 3;

            else if (Proffession == "Archer") return _strength * 1 + _agility * 5 + _inteligence * 0 + _endurance * 2;

            else if (Proffession == "Wizard") return _strength * 1 + _agility * 1 + _inteligence * 1 + _endurance * 2;

            else return 0;
        }

        public int MagicalDamageMethod()
        {
            if (Proffession == "Warrior") return _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0;

            else if (Proffession == "Archer") return _strength * 0 + _agility * 0 + _inteligence * 3 + _endurance * 0;

            else if (Proffession == "Wizard") return _strength * 0 + _agility * 0 + _inteligence * 7 + _endurance * 0;

            else return 0;
        }

        public int MagicalProtectionMethod()
        {
            if (Proffession == "Warrior") return _strength * 1 + _agility * 0 + _inteligence * 2 + _endurance * 1;

            else if (Proffession == "Archer") return _strength * 0 + _agility * 3 + _inteligence * 3 + _endurance * 1;

            else if (Proffession == "Wizard") return _strength * 0 + _agility * 0 + _inteligence * 5 + _endurance * 1;

            else return 0;
        }

        public int LifeMethod()
        {
            if (Proffession == "Warrior") return _strength * 5 + _agility * 0 + _inteligence * 0 + _endurance * 10;

            else if (Proffession == "Archer") return _strength * 2 + _agility * 0 + _inteligence * 0 + _endurance * 5;

            else if (Proffession == "Wizard") return _strength * 1 + _agility * 0 + _inteligence * 0 + _endurance * 3;

            else return 0;
        }

        public int MagicMethod()
        {
            if (Proffession == "Warrior") return _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0;

            else if (Proffession == "Archer") return _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0;

            else if (Proffession == "Wizard") return _strength * 0 + _agility * 0 + _inteligence * 2 + _endurance * 0;

            else return 0;
        }

        public int ProffessioMethod()
        {
            if (Proffession == "Warrior")
            {
                return 1;
            }
            else if (Proffession == "Archer")
            {
                return 2;
            }
            else if (Proffession == "Wizard")
            {
                return 3;
            }
            else return 0;
        }





        //[BsonIgnore]
        //public int PhysicalDamage { get => _strength * 7 + _agility * 2 + _inteligence * 0 + _endurance * 0; }           

        //[BsonIgnore]
        //public int PhysicalProtection { get => _strength * 2 + _agility * 3 + _inteligence * 0 + _endurance * 3; }

        //[BsonIgnore]
        //public int MagicalDamage { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }

        //[BsonIgnore]
        //public int MagicalProtection { get => _strength * 1 + _agility * 0 + _inteligence * 2 + _endurance * 1; }

        //[BsonIgnore]
        //public int Life { get => _strength * 5 + _agility * 0 + _inteligence * 0 + _endurance * 10; }
        
        //[BsonIgnore]
        //public int Magic { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }

        
    }
}
