
using MongoDB.Bson.Serialization.Attributes;

namespace WpfCharacterEditor
{
    class Warrior : Сharacter
    {
<<<<<<< HEAD
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
=======
        public Warrior(string name, string proffession, int freePoints) : base(name, proffession)
>>>>>>> New
        {
            _strength = StrengthMin;
            _agility = AgilityMin;
            _inteligence = IntelligenceMin;
            _endurance = EnduranceMin;
            _freePoints = freePoints;
            _maxFreePoints = freePoints;

            SetMinMax(proffession);
            
        }

        public Warrior(string name, string proffession, int strength, int agility, int intelligence, int endurance, int freePoints) : base (name, proffession)
        {
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
        
        [BsonIgnore]
        public override int StrengthMin { get => 30; }
        [BsonIgnore]
        public override int StrengthMax { get => 250; }

        [BsonIgnore]
        public override int AgilityMin { get => 15; }
        [BsonIgnore]
        public override int AgilityMax { get => 80; }

        [BsonIgnore]
        public override int IntelligenceMin { get => 10; }
        [BsonIgnore]
        public override int IntelligenceMax { get => 50; }

        [BsonIgnore]
        public override int EnduranceMin { get => 25; }
        [BsonIgnore]
        public override int EnduranceMax { get => 100; }

<<<<<<< HEAD
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

        
=======
        [BsonIgnore]
        public override int PhysicalDamage { get => _strength * 7 + _agility * 2 + _inteligence * 0 + _endurance * 0; }           
        
        [BsonIgnore]
        public override int PhysicalProtection { get => _strength * 2 + _agility * 3 + _inteligence * 0 + _endurance * 3; }

        [BsonIgnore]
        public override int MagicalDamage { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }
                
        [BsonIgnore]
        public override int MagicalProtection { get => _strength * 1 + _agility * 0 + _inteligence * 2 + _endurance * 1; }
        
        [BsonIgnore]
        public override int Life { get => _strength * 5 + _agility * 0 + _inteligence * 0 + _endurance * 10; }
        
        [BsonIgnore]
        public override int Magic { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }
   
>>>>>>> New
    }
}
