using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    public class Character
    {

        //[BsonId]
        //public ObjectId _id;

        //public string _name;
        //public string _profession;
        //public int _strenght;
        //public int _agility;
        //public int _intelligence;
        //public int _stamina;
        //public int _level;
        //public long _experiense;
        //public int _freePoint;
        //public Character(string profession)
        //{
        //    _profession = profession;
        //}




        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonElement]
        protected int _strength;
        //protected int _minStrength;
        //protected int _maxStrength;
        [BsonElement]
        protected int _agility;
        //protected int _minAgility;
        //protected int _maxAgility;
        [BsonElement]
        protected int _inteligence;
        //protected int _minIntelligence;
        //protected int _maxIntelligence;
        [BsonElement]
        protected int _endurance;
        //protected int _minEndurance;
        //protected int _maxEndurance;
        protected int _freePoints;
        protected int _minFreePoints=0;
        protected int _maxFreePoints;

        [BsonElement]
        public Weapon weapon;
        public Character(string name, int strength, int agility, string proffession)
        {
            Name = name;
            Proffession = proffession;
        }

        public Character(string name, int strength, int agility, int intelligence, int endurance)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            Endurance = endurance;
        }

        public virtual string Name { get; set; }

        public virtual string Proffession { get; set; }

        public double Attack()
        {
            return PhysicalDamage / 100 * weapon.PhysicalDamage+ MagicalDamage / 100 * weapon.MagicalDamage; ;


        }
        [BsonIgnore]
        public int Strength
        {
            get => _strength;
            set
            {
                if (_strength > value && _strength > StrengthMin && _freePoints < _maxFreePoints)
                {
                    _strength = value;
                    _freePoints += 1;
                }
                if (_strength < value && _strength < StrengthMax && _freePoints > _minFreePoints)
                {
                    _strength = value;
                    _freePoints -= 1;
                }
                //else _strength = value;

            }
        }


        public int Agility
        {
            get => _agility;
            set
            {
                if (_agility > value && _agility > AgilityMin && _freePoints < _maxFreePoints)
                {
                    _agility = value;
                    FreePoints += 1;
                }
                if (_agility < value && _agility < AgilityMax && _freePoints > _minFreePoints)
                {
                    _agility = value;
                    _freePoints -= 1;
                }
                //else _agility = value;
            }
        }

        public int Intelligence
        {
            get => _inteligence;
            set
            {
                if (_inteligence > value && _inteligence > IntelligenceMin && _freePoints < _maxFreePoints)
                {
                    _inteligence = value;
                    FreePoints += 1;
                }
                if (_inteligence < value && _inteligence < IntelligenceMax && _freePoints > _minFreePoints)
                {
                    _inteligence = value;
                    _freePoints -= 1;
                }
                //else _inteligence = value;
            }
        }


        public int Endurance
        {
            get => _endurance;
            set
            {
                if (_endurance > value && _endurance > EnduranceMin && _freePoints < _maxFreePoints)
                {
                    _endurance = value;
                    FreePoints += 1;
                }
                if (_endurance < value && _endurance < EnduranceMax && _freePoints > _minFreePoints)
                {
                    _endurance = value;
                    _freePoints -= 1;
                }
                //else _endurance = value;
            }
        }



        [BsonIgnore]
        public virtual int StrengthMin { get; }
        [BsonIgnore]
        public virtual int StrengthMax { get; }

        [BsonIgnore]
        public virtual int AgilityMin { get; }
        [BsonIgnore]
        public virtual int AgilityMax { get; }

        [BsonIgnore]
        public virtual int IntelligenceMin { get; }
        [BsonIgnore]
        public virtual int IntelligenceMax { get; }

        [BsonIgnore]
        public virtual int EnduranceMin { get; }
        [BsonIgnore]
        public virtual int EnduranceMax { get; }

        public int FreePoints { get => _freePoints; set { _freePoints = value; } }
        [BsonIgnore]
        public int FreePointsMin => _minFreePoints;
        [BsonIgnore]
        public int FreePointsMax { get => _maxFreePoints; set => _maxFreePoints = value; }


        public virtual int PhysicalDamage { get; }

        public virtual int PhysicalProtection { get; }

        public virtual int MagicalDamage { get; }

        public virtual int MagicalProtection { get; }

        public virtual int Life { get; }

        public virtual int Magic { get; }


    }
}
