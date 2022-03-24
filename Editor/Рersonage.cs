using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class Рersonage
    {
        
        public ObjectId _id { get; set; }
        protected virtual string _characterType { get; set; }

        protected int _strength;
        protected int _agility;
        protected int _intelligence;
        protected int _endure;

        protected int _physicalDamage;
        protected int _physicalProtection;
        protected int _magicDamage;
        protected int _magicProtection;
        protected int _life;
        protected int _magic;

        protected int _remainderPoints;
        protected int _countRemainderPoints;
        protected int _level;
        protected int _experience;

        protected virtual int _maxStrength { get; }
        protected virtual int _maxAgility { get; }
        protected virtual int _maxIntelligence { get; }
        protected virtual int _maxEndure { get; }

        protected virtual int _minStrength { get; }
        protected virtual int _minAgility { get; }
        protected virtual int _minIntelligence { get; }
        protected virtual int _minEndure { get; }

        protected int _lastСhangeStrength;
        protected int _lastСhangeAgility;
        protected int _lastСhangeIntelligence;
        protected int _lastСhangeEndure;

        public string Name { set; get; }
        public string CharacterType
        {
            get { return _characterType; }
            private set
            {
                _characterType = value;
            }
        }

        public int MaxStrength => _maxStrength;
        public int MaxAgility => _maxAgility;
        public int MaxIntelligence => _maxIntelligence;
        public int MaxEndure => _maxEndure;

        public int MinStrength => _minStrength;
        public int MinAgility => _minAgility;
        public int MinIntelligence => _minIntelligence ;
        public int MinEndure => _minEndure;

        private int RemainderPoints
        {
            get
            {
                return _remainderPoints;
            }
            set
            {
                if (value >= 0)
                {
                    _remainderPoints = value;
                    _countRemainderPoints += value;
                }
            }
        }
        public int CountRemainderPoints
        {
            get { return _countRemainderPoints; }
            private set
            {
                if (value >= 0)
                    _countRemainderPoints = value;

                if (RemainderPoints == 0 && _countRemainderPoints != 0)
                    _remainderPoints = _countRemainderPoints;
            }
        }      
        public int Level
        {
            get { return _level; }
            private set
            {
                _level = value;
            }
        }
        public int Experience
        {
            get { return _experience; }
            private set
            {
                _experience = value;
            }
        }

        public int Strength
        {
            get { return _strength; }
            private set
            {
                _strength = value;
            }
        }
        public int Agility
        {
            get { return _agility; }
            private set
            {
                _agility = value;
            }
        }
        public int Intelligence
        {
            get { return _intelligence; }
            private set
            {
                _intelligence = value;
            }
        }
        public int Endure
        {
            get { return _endure; }
            private set
            {
                _endure = value;
            }
        }

        private int LastСhangeStrength { set; get; }
        private int LastСhangeAgility { set; get; }
        private int LastСhangeIntelligence { set; get; }
        private int LastСhangeEndure { set; get; }

        public int РhysicalDamage
        {
            get
            {
                return _physicalDamage;
            }
            private set
            {
                _physicalDamage = value;
            }
        }
        public int PhysicalProtection
        {
            get
            {
                return _physicalProtection;
            }
            private set
            {
                _physicalProtection = value;
            }
        }
        public int MagicDamage
        {
            get
            {
                return _magicDamage;
            }
            private set
            {
                _magicDamage = value;
            }
        }
        public int MagicProtection
        {
            get
            {
                return _magicProtection;
            }
            private set
            {
                _magicProtection = value;
            }
        }
        public int Life
        {
            get
            {
                return _life;
            }
            private set
            {
                _life = value;
            }
        }
        public int Magic
        {
            get
            {
                return _magic;
            }
            private set
            {
                _magic = value;
            }
        }

        public Рersonage(string name, int level, int remainderPoints)
        {
            Name = name;
            CharacterType = _characterType;
            Level = level;
            RemainderPoints = remainderPoints;

            _strength = MinStrength;
            _agility = MinAgility;
            _intelligence = MinIntelligence;
            _endure = MinEndure;

            //Расчет дополниельных параметров
            СhangeExtraParameters();
        }

        public void LevelIncrease()
        {

        }

        public void PointsStrengthIncrease()
        {
            var newStrength = Strength + 1;

            if (Strength <= MaxStrength && newStrength >= MinStrength)
            {

                if (_strength < newStrength && CountRemainderPoints > 0)
                {
                    LastСhangeStrength += 1;
                    CountRemainderPoints--;
                    _strength = newStrength;
                }

                СhangeExtraParameters();
            }
        }

        public void PointsAgilityIncrease()
        {
            var newAgility = Agility + 1;

            if (newAgility <= MaxAgility && newAgility >= MinAgility)
            {

                if (_agility < newAgility && CountRemainderPoints > 0)
                {
                    LastСhangeAgility += 1;
                    CountRemainderPoints--;
                    _agility = newAgility;
                }

                СhangeExtraParameters();
            }
        }

        public void PointsIntelligenceIncrease()
        {
            var newIntelligence = Intelligence + 1;

            if (newIntelligence <= MaxIntelligence && newIntelligence >= MinIntelligence)
            {

                if (_intelligence < newIntelligence && CountRemainderPoints > 0)
                {
                    LastСhangeIntelligence += 1;
                    CountRemainderPoints--;
                    _intelligence = newIntelligence;
                }

                СhangeExtraParameters();
            }
        }

        public void PointsEndureIncrease()
        {
            var newEndure = Endure + 1;

            if (newEndure <= MaxEndure && newEndure >= MinEndure)
            {

                if (_endure < newEndure && CountRemainderPoints > 0)
                {
                    LastСhangeEndure += 1;
                    CountRemainderPoints--;
                    _endure = newEndure;
                }

                СhangeExtraParameters();
            }
        }


        public void PointsStrengthDecrease()
        {
            if (LastСhangeStrength == 0)
                return;

            var newStrength = Strength - 1;

            if (Strength <= MaxStrength && newStrength >= MinStrength)
            {

                if (_strength > newStrength && CountRemainderPoints < RemainderPoints && LastСhangeStrength != 0)
                {
                    LastСhangeStrength -= 1;
                    CountRemainderPoints++;
                    _strength = newStrength;
                }

                СhangeExtraParameters();
            }
        }

        public void PointsAgilityDecrease()
        {
            if (LastСhangeAgility == 0)
                return;

            var newAgility = Agility - 1;

            if (newAgility <= MaxAgility && newAgility >= MinAgility)
            {
                if (_agility > newAgility && CountRemainderPoints < RemainderPoints && LastСhangeAgility != 0)
                {
                    LastСhangeAgility -= 1;
                    CountRemainderPoints++;
                    _agility = newAgility;
                }

                СhangeExtraParameters();
            }
        }

        public void PointsIntelligenceDecrease()
        {
            if (LastСhangeIntelligence == 0)
                return;

            var newIntelligence = Intelligence - 1;

            if (newIntelligence <= MaxIntelligence && newIntelligence >= MinIntelligence)
            {
                if (_intelligence > newIntelligence && CountRemainderPoints < RemainderPoints && LastСhangeIntelligence != 0)
                {
                    LastСhangeIntelligence -= 1;
                    CountRemainderPoints++;
                    _intelligence = newIntelligence;
                }

                СhangeExtraParameters();
            }
        }

        public void PointsEndureDecrease()
        {
            if (LastСhangeEndure == 0)
                return;

            var newEndure = Endure - 1;

            if (newEndure <= MaxEndure && newEndure >= MinEndure)
            {

                if (_endure > newEndure && CountRemainderPoints < RemainderPoints && LastСhangeEndure != 0)
                {
                    LastСhangeEndure -= 1;
                    CountRemainderPoints++;
                    _endure = newEndure;
                }

                СhangeExtraParameters();
            }
        }

        public void ExperienceIncrease(int experience)
        {
            var newExperience = Experience + experience;

            while (newExperience > _experience)
            {
                //Перерасчет
                var experienceNewLevel = 0;
                var levelUpExperience = 1000;
                for (int i = 1; i < Level + 1; i++)
                {
                    experienceNewLevel += levelUpExperience;
                    levelUpExperience += 1000;
                }

                if (newExperience >= experienceNewLevel)
                {
                    Level++;
                    RemainderPoints += 5;
                    _experience += 1000;
                }
                else
                {
                    _experience = newExperience;
                }
            }
        }

        public void СhangeExtraParameters()
        {
            BoostExtraParameters StrengthPoints = new BoostExtraParameters("Strength", Strength, CharacterType);
            BoostExtraParameters AgilityPoints = new BoostExtraParameters("Agility", Agility, CharacterType);
            BoostExtraParameters IntelligencePoints = new BoostExtraParameters("Intelligence", Intelligence, CharacterType);
            BoostExtraParameters EndurePoints = new BoostExtraParameters("Endure", Endure, CharacterType);

            РhysicalDamage = StrengthPoints.РhysicalDamageValue + AgilityPoints.РhysicalDamageValue + IntelligencePoints.РhysicalDamageValue + EndurePoints.РhysicalDamageValue;
            PhysicalProtection = StrengthPoints.PhysicalProtectionValue + AgilityPoints.PhysicalProtectionValue + IntelligencePoints.PhysicalProtectionValue + EndurePoints.PhysicalProtectionValue;
            MagicDamage = StrengthPoints.MagicDamageValue + AgilityPoints.MagicDamageValue + IntelligencePoints.MagicDamageValue + EndurePoints.MagicDamageValue;
            MagicProtection = StrengthPoints.MagicProtectionValue + AgilityPoints.MagicProtectionValue + IntelligencePoints.MagicProtectionValue + EndurePoints.MagicProtectionValue;
            Life = StrengthPoints.LifeValue + AgilityPoints.LifeValue + IntelligencePoints.LifeValue + EndurePoints.LifeValue;
            Magic = StrengthPoints.MagicValue + AgilityPoints.MagicValue + IntelligencePoints.MagicValue + EndurePoints.MagicValue;
        }

        /// <summary>
        /// Изменённые поля
        /// </summary>
        public Dictionary<string, object> ComparisonObjects(Рersonage рersonage)
        {
            Dictionary<string, object> propertiesChange = new Dictionary<string, object>();

            var propertyName = this.Name != рersonage.Name ? рersonage.Name : null;
            var propertyCharacterType = this.CharacterType != рersonage.CharacterType ? рersonage.CharacterType : null;
            
            var propertyCountRemainderPoints = this.CountRemainderPoints != рersonage.CountRemainderPoints ? (object)рersonage.CountRemainderPoints : null;
            var propertyLevel = this.Level != рersonage.Level ? (object)рersonage.Level : null;
            var propertyExperience = this.Experience != рersonage.Experience ? (object)рersonage.Experience : null;
            
            var propertyStrength = this.Strength != рersonage.Strength ? (object)рersonage.Strength : null;
            var propertyAgility = this.Agility != рersonage.Agility ? (object)рersonage.Agility : null;
            var propertyIntelligence = this.Intelligence != рersonage.Intelligence ? (object)рersonage.Intelligence : null;
            var propertyEndure = this.Endure != рersonage.Endure ? (object)рersonage.Endure : null;
            var propertyРhysicalDamage = this.РhysicalDamage != рersonage.РhysicalDamage ? (object)рersonage.РhysicalDamage : null;
            var propertyPhysicalProtection = this.PhysicalProtection != рersonage.PhysicalProtection ? (object)рersonage.PhysicalProtection : null;
            var propertyMagicDamage = this.MagicDamage != рersonage.MagicDamage ? (object)рersonage.MagicDamage : null;
            var propertyMagicProtection = this.MagicProtection != рersonage.MagicProtection ? (object)рersonage.MagicProtection : null;
            var propertyLife = this.Life != рersonage.Life ? (object)рersonage.Life : null;
            var propertyMagic = this.Level != рersonage.Magic ? (object)рersonage.Magic : null;

            propertiesChange.Add(nameof(Name), propertyName);
            propertiesChange.Add(nameof(CharacterType), propertyCharacterType);           
            propertiesChange.Add(nameof(CountRemainderPoints), propertyCountRemainderPoints);
            propertiesChange.Add(nameof(Level), propertyLevel);
            propertiesChange.Add(nameof(Experience), propertyExperience);
            propertiesChange.Add(nameof(Strength), propertyStrength);
            propertiesChange.Add(nameof(Agility), propertyAgility);
            propertiesChange.Add(nameof(Intelligence), propertyIntelligence);
            propertiesChange.Add(nameof(Endure), propertyEndure);
            propertiesChange.Add(nameof(РhysicalDamage), propertyРhysicalDamage);
            propertiesChange.Add(nameof(PhysicalProtection), propertyPhysicalProtection);
            propertiesChange.Add(nameof(MagicDamage), propertyMagicDamage);
            propertiesChange.Add(nameof(MagicProtection), propertyMagicProtection);
            propertiesChange.Add(nameof(Life), propertyLife);
            propertiesChange.Add(nameof(Magic), propertyMagic);

            return propertiesChange;
        }
    }
}
