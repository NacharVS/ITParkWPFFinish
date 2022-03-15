
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

        private int _physicalDamage;
        private int _physicalProtection;
        private int _magicalDamage;
        private int _magicalProtection;
        private int _life;
        private int _magic;

        public Warrior(string name, string proffession, int strength, int agility, int intelligence, int endurance): base(name, proffession)
        {
            _strength = strength;
            _agility = agility;
            _inteligence = intelligence;
            _endurance = endurance;
        }

        public int Strength
        {
            get => _strength;
            set
            {

                Strength();
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

        [BsonIgnoreIfDefault]
        public int PhysicalDamage
        {
            get => _physicalDamage;
            set
            {
                _physicalDamage = _strength * 7 + _agility * 2 + _inteligence * 0 + _endurance * 0;
            }
        }
        [BsonIgnoreIfDefault]
        public int PhysicalProtection
        {
            get => _physicalProtection;
            set
            {
                _physicalProtection = _strength * 2 + _agility * 3 + _inteligence * 0 + _endurance * 3;
            }
        }
        [BsonIgnoreIfDefault]
        public int MagicalDamage
        {
            get => _magicalDamage;
            set
            {
                _magicalDamage = _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0;
            }
        }
        [BsonIgnoreIfDefault]
        public int MagicalProtection
        {
            get => _magicalProtection;
            set
            {
                _magicalProtection = _strength * 1 + _agility * 0 + _inteligence * 2 + _endurance * 1;
            }
        }
        [BsonIgnoreIfDefault]
        public int Life
        {
            get => _life;
            set
            {
                _life = _strength * 5 + _agility * 0 + _inteligence * 0 + _endurance * 10;
            }
        }
        [BsonIgnoreIfDefault]
        public int Magic
        {
            get => _magic;
            set
            {
                _magic = _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0;
            }
        }
    }
}
