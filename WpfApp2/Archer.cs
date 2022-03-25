﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
   public class Archer : ICharacter
    {
       
        private double _minStrength = 20;
        private double _maxStrength = 55;
        [BsonIgnore]
        public double _currentStrength;
        private double _minAgility = 30;
        private double _maxAgility = 250;
        [BsonIgnore]
        public double _currentAgility;
        [BsonIgnore]
        public double _currentIntelligence;
        private double _minIntelligence = 15;
        private double _maxIntelligence = 70;
        [BsonIgnore]
        public double _currentEndurance;
        private double _minEndurance = 20;
        private double _maxEndurance = 80;

        private string _name;
        private string _proffesion = "Archer";

        public Archer(string name, string proffesion, double minStrength, double minAgility, double minIntelligence, double minEndurance)
        {
            _minStrength = minStrength;
            _minAgility = minAgility;
            _minIntelligence = minIntelligence;
            _minEndurance = minEndurance;
            _name = name;
            _proffesion = proffesion;
        }
       [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId ID { get; set; }
        public string Name { get => _name; set => _name = value; }
        public string Proffesion { get => _proffesion; set => _proffesion = value; }

        public double MaxStrength { get => _maxStrength; }
        public double MinStrength { get => _minStrength; }
        [BsonElement("Strength")]
        public double CurrentStrength
        {
            get => _minStrength;

            set
            {
                if (value < _minStrength)
                {
                    _currentStrength = _minStrength;
                }
                else if (value > _maxStrength)
                {
                    _currentStrength = _maxStrength;
                }
                else
                {
                    _currentStrength =  value;
                }

            }
        }
        public double MaxAgility { get => _maxAgility; }

        public double MinAgility { get => _minAgility; }
        [BsonElement("Agility")]
        public double CurrentAgility
        {
            get => _minAgility;

            set
            {
                if (value < _minAgility)
                {
                    _currentAgility = _minAgility;
                }
                else if (value > _maxAgility)
                {
                    _currentAgility = _maxAgility;
                }
                else
                {
                    _currentAgility = value;
                }

            }
        }
        public double MaxIntelligence { get => _maxIntelligence; }
        public double MinIntelligence { get => _minIntelligence; }
      
        [BsonElement("Intelligence")]
        public double CurrentIntelligence
        {
            get => _minIntelligence;

            set
            {
                if (value < _minIntelligence)
                {
                    _currentIntelligence = _minIntelligence;
                }
                else if (value > _maxStrength)
                {
                    _currentIntelligence = _maxIntelligence;
                }
                else
                {
                    _currentIntelligence =  value;
                }

            }
        }
        public double MaxEndurance { get => _maxEndurance; }
        public double MinEndurance { get => _minEndurance; }

        [BsonElement("Endurance")]
        public double CurrentEndurance
        {
            get => _minEndurance;

            set
            {
                if (value < _minEndurance)
                {
                    _currentEndurance = _minEndurance;
                }
                else if (value > _maxEndurance)
                {
                    _currentEndurance = _maxEndurance;
                }
                else
                {
                    _currentEndurance =  value;
                }

            }
        }

       
        [BsonIgnore]
        public double PhysicDamage  { get => (_currentStrength * 3) + (_currentAgility * 7); }
        
       

        [BsonIgnore]
        public double PhysicDefense   { get => (_currentStrength * 1) + (_currentAgility * 5) + (_currentEndurance * 2); }
      
        [BsonIgnore]
        public double MagicDefense { get => (_currentAgility * 3) + (_currentIntelligence * 3) + (_currentEndurance * 1); }

        [BsonIgnore]
        public double MagicDamage { get =>  _currentIntelligence * 3; }
  
        [BsonIgnore]
        public double Life { get => (_currentStrength * 2) + (_currentEndurance * 5); }

        [BsonIgnore]
        public  double Mana {  get => _currentIntelligence; }
        
        private double _currentLevel;
        [BsonIgnore]
        public double Level
        {
            get => _currentLevel;
            set
            {
                _currentLevel = value;
            }
        }
    }
}