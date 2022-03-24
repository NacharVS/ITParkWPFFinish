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
            Profession = "archer";
            CurrentHelth = health;
            PowerCurrent = PowerMin;
            SkillCurrent = SkillMin;
            IntellectCurrent = IntellectMin;
            StaminaCurrent = StaminaMin;
        }

        public string Profession { get => _profession; set => _profession = value; }
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

        public BasePersonage ConvertToBasePersonage()
        {
            BasePersonage personageToReturn = new BasePersonage("Name");
            personageToReturn.Name = this.Name;
            personageToReturn.Profession = this.Profession;
            personageToReturn.CurrentHelth = this.CurrentHelth;
            personageToReturn.PowerCurrent = this.PowerCurrent;
            personageToReturn.SkillCurrent = this.SkillCurrent;
            personageToReturn.IntellectCurrent = this.IntellectCurrent;
            personageToReturn.StaminaCurrent = this.StaminaCurrent;
            personageToReturn.PowerMin = this.PowerMin;
            personageToReturn.PowerMax = this.PowerMax;
            personageToReturn.SkillMin = this.SkillMin;
            personageToReturn.SkillMax = this.SkillMax;
            personageToReturn.IntellectMin = this.IntellectMin;
            personageToReturn.IntellectMax = this.IntellectMax;
            personageToReturn.StaminaMin = this.StaminaMin;
            personageToReturn.StaminaMax = this.StaminaMax;

            return personageToReturn;
        }
    }
}
