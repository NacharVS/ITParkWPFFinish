
using MongoDB.Bson.Serialization.Attributes;

namespace WpfCharacterEditor
{
    class Wizard : Сharacter
    {
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

        [BsonIgnore]
        public override int StrengthMin { get => _minStrength; set => _minStrength = 15; }
        [BsonIgnore]
        public override int StrengthMax { get => _maxStrength; set => _maxStrength = 45; }

        [BsonIgnore]
        public override int AgilityMin { get => _minAgility; set => _minAgility = 20; }
        [BsonIgnore]
        public override int AgilityMax { get => _maxAgility; set => _maxAgility = 85; }

        [BsonIgnore]
        public override int IntelligenceMin { get => _minIntelligence; set => _minIntelligence = 35; }
        [BsonIgnore]
        public override int IntelligenceMax { get => _maxIntelligence; set => _maxIntelligence = 250; }

        [BsonIgnore]
        public override int EnduranceMin { get => _minEndurance; set => _minEndurance = 20; }
        [BsonIgnore]
        public override int EnduranceMax { get => _maxEndurance; set => _maxEndurance = 80; }

        [BsonIgnore]
        public override int PhysicalDamage { get => _strength * 1 + _agility * 1 + _inteligence * 0 + _endurance * 0; }           
        
        [BsonIgnore]
        public override int PhysicalProtection { get => _strength * 1 + _agility * 1 + _inteligence * 1 + _endurance * 2; }

        [BsonIgnore]
        public override int MagicalDamage { get => _strength * 0 + _agility * 0 + _inteligence * 7 + _endurance * 0; }
                
        [BsonIgnore]
        public override int MagicalProtection { get => _strength * 0 + _agility * 0 + _inteligence * 5 + _endurance * 1; }
        
        [BsonIgnore]
        public override int Life { get => _strength * 1 + _agility * 0 + _inteligence * 0 + _endurance * 3; }
        
        [BsonIgnore]
        public override int Magic { get => _strength * 0 + _agility * 0 + _inteligence * 2 + _endurance * 0; }

        
    }
}
