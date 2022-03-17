
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Shaman : Personage, IPersonage
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }

        public Shaman(string name)
        {
            Name = name;
            PowerCurrent = PowerMin;
            SkillCurrent = SkillMin;
            IntellectCurrent = IntellectMin;
            StaminaCurrent = StaminaMin;
        }

        
  
        public double CurrentHelth { get => _currentHealth; set => _currentHealth = health; }
        public string Name { get => name; set => name = value; }
        public double PowerCurrent { get => _power; set => _power = value; }
        public double SkillCurrent { get => _skill; set => _skill = value; }
        public double IntellectCurrent { get => _intellect; set => _intellect = value; }
        public double StaminaCurrent { get => _stamina; set => _stamina = value; }
        public int PowerMin { get => _minPower; set => _minPower = 15; }
        public int SkillMin { get => _minSkill; set => _minSkill = 20; }
        public int IntellectMin { get => _minIntellect; set => _minIntellect = 35; }
        public int StaminaMin { get => _minStamina; set => _minStamina = 20; }
        public int PowerMax { get => _maxPower; set => _maxPower = 45; }
        public int SkillMax { get => _maxSkill; set => _maxSkill = 85; }
        public int IntellectMax { get => _maxIntellect; set => _maxIntellect = 250; }
        public int StaminaMax { get => _maxStamina; set => _maxStamina = 80; }
    }
}
