using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Archer : Personage, IPersonage
    {
        public Archer(string name)
        {
            Name = name;
            CurrentHelth = health;
            PowerCurrent = PowerMin;
            SkillCurrent = SkillMin;
            IntellectCurrent = IntellectMin;
            StaminaCurrent = StaminaMin;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }

        

        public string Profession { get => _profession; set => _profession = "archer"; }
        public double CurrentHelth { get => _currentHealth; set => _currentHealth = value; }
        public string Name { get => name; set => name = value; }
        public double PowerCurrent { get => _power; set => _power = value; }
        public double SkillCurrent { get => _skill; set => _skill = value; }
        public double IntellectCurrent { get => _intellect; set => _intellect = value; }
        public double StaminaCurrent { get => _stamina; set => _stamina = value; }
        public double PowerMin => 20;
        public double SkillMin { get => 30; }
        public double IntellectMin { get => 15; }
        public double StaminaMin { get => 20; }
        public double PowerMax { get => 55; }
        public double SkillMax { get => 250; }
        public double IntellectMax { get => 70; }
        public double StaminaMax { get => 50; }
    }
}
