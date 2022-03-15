
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
        private int _minFreepoints;


        private int _physicalDamage;
        private int _physicalProtection;
        private int _magicalDamage;
        private int _magicalProtection;
        private int _life;
        private int _magic;

        public Warrior(string name, string proffession, int strength, int agility, int intelligence, int endurance, int freePoints)
        {
            Name = name;
            Proffession = proffession;
            _strength = strength;
            _agility = agility;
            _inteligence = intelligence;
            _endurance = endurance;
            _freePoints = freePoints;
        }

        public string Name { get; set; }

        public string Proffession { get; set; }

        public int Strength
        {
            get => _strength;
            set
            {
                if (_strength > value && _strength < _maxStrength)
                {
                    FreePoints += 1; 
                }
                if (_strength < value && _strength > _minStrength)
                {
                    FreePoints -= 1;
                }

                _strength = value;

            }
        }
        public int Agility
        {
            get => _agility;
            set
            {
               _agility = value;
            }
        }
        public int Intelligence
        {
            get => _inteligence;
            set
            {
                _inteligence = value;
            }
        }
        public int Endurance
        {
            get => _endurance;
            set
            {
                _endurance = value;
            }
        }

        public int FreePoints
        {
            get => _freePoints;
            set
            {
                _freePoints = value;
            }
        }

        [BsonIgnoreIfDefault]
        public int PhysicalDamage { get => _strength * 7 + _agility * 2 + _inteligence * 0 + _endurance * 0; }           
        
        [BsonIgnoreIfDefault]
        public int PhysicalProtection { get => _strength * 2 + _agility * 3 + _inteligence * 0 + _endurance * 3; }

        [BsonIgnoreIfDefault]
        public int MagicalDamage { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }
                
        [BsonIgnoreIfDefault]
        public int MagicalProtection { get => _strength * 1 + _agility * 0 + _inteligence * 2 + _endurance * 1; }
        
        [BsonIgnoreIfDefault]
        public int Life { get => _strength * 5 + _agility * 0 + _inteligence * 0 + _endurance * 10; }
        
        [BsonIgnoreIfDefault]
        public int Magic { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }
        
    }
}
