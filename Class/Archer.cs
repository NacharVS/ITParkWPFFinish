
using MongoDB.Bson.Serialization.Attributes;

namespace WpfCharacterEditor
{
    class Archer : Сharacter, ICharacter
    {
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

        [BsonIgnore]
        public override int StrengthMin { get => _minStrength; set => _minStrength = 20; }
        [BsonIgnore]
        public override int StrengthMax { get => _maxStrength; set => _maxStrength = 55; }

        [BsonIgnore]
        public override int AgilityMin { get => _minAgility; set => _minAgility = 30; }
        [BsonIgnore]
        public override int AgilityMax { get => _maxAgility; set => _maxAgility = 250; }

        [BsonIgnore]
        public override int IntelligenceMin => 15;
        [BsonIgnore]
        public override int IntelligenceMax => 70;

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
