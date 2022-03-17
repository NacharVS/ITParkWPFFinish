
using MongoDB.Bson.Serialization.Attributes;

namespace WpfCharacterEditor
{
    class Archer : Сharacter, ICharacter
    {
        private int _strength;
        private int _minStrength = 20;
        private int _maxStrength = 55;
        private int _agility;
        private int _minAgility = 30;
        private int _maxAgility = 250;
        private int _inteligence;
        private int _minIntelligence = 15;
        private int _maxIntelligence = 70;
        private int _endurance;
        private int _minEndurance = 20;
        private int _maxEndurance = 80;
        private int _freePoints;
        private int _minFreePoints = 0;
        private int _maxFreePoints;

        public Archer(string name, string proffession, int freePoints) : base(name, proffession)
        {
            _strength = StrengthMin;
            _agility = AgilityMin;
            _inteligence = IntelligenceMin;
            _endurance = EnduranceMin;
            _freePoints = freePoints;
            _maxFreePoints = freePoints;
        }

        public Archer(string name, string proffession, int strength, int agility, int intelligence, int endurance, int freePoints) : base(name, proffession)
        {
            _strength = strength;
            _agility = agility;
            _inteligence = intelligence;
            _endurance = endurance;
            _freePoints = freePoints;
            _maxFreePoints = freePoints;
        }

        public override int Strength
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
        public override int StrengthMin => 20;
        [BsonIgnore]
        public override int StrengthMax => 55;

        public override int Agility
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
        public override int AgilityMin => 30;
        [BsonIgnore]
        public override int AgilityMax => 250;

        public override int Intelligence
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
        public override int IntelligenceMin => 15;
        [BsonIgnore]
        public override int IntelligenceMax => 70;

        public override int Endurance
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
        public override int EnduranceMin => 20;
        [BsonIgnore]
        public override int EnduranceMax => 80;

        [BsonIgnore]
        public override int PhysicalDamage { get => _strength * 3 + _agility * 7 + _inteligence * 0 + _endurance * 0; }           
        
        [BsonIgnore]
        public override int PhysicalProtection { get => _strength * 1 + _agility * 5 + _inteligence * 0 + _endurance * 2; }

        [BsonIgnore]
        public override int MagicalDamage { get => _strength * 0 + _agility * 0 + _inteligence * 3 + _endurance * 0; }
                
        [BsonIgnore]
        public override int MagicalProtection { get => _strength * 0 + _agility * 3 + _inteligence * 3 + _endurance * 1; }
        
        [BsonIgnore]
        public override int Life { get => _strength * 2 + _agility * 0 + _inteligence * 0 + _endurance * 5; }
        
        [BsonIgnore]
        public override int Magic { get => _strength * 0 + _agility * 0 + _inteligence * 1 + _endurance * 0; }

        
    }
}
