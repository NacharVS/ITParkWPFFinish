
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1
{
    [BsonDiscriminator("Shaman")]
    public class Shaman : BasePersonage
    {
        public Shaman(string shamanName):base(shamanName)
        {
            Name = shamanName;
            Profession = "shaman";
            CurrentHelth = health;
            PowerCurrent = PowerMin;
            SkillCurrent = SkillMin;
            IntellectCurrent = IntellectMin;
            StaminaCurrent = StaminaMin;
        }

        public override string Profession { get => _profession; set => _profession = value; }

        public override double CurrentHelth { get => _currentHealth; set => _currentHealth = value; }
        public override string Name { get => name; set => name = value; }
        public override double PowerCurrent { get => _power; set => _power = value; }
        public override double SkillCurrent { get => _skill; set => _skill = value; }
        public override double IntellectCurrent { get => _intellect; set => _intellect = value; }
        public override double StaminaCurrent { get => _stamina; set => _stamina = value; }
        public override double PowerMin => 15; 
        public override double SkillMin => 20;
        public override double IntellectMin => 35;
        public override double StaminaMin => 20;
        public override double PowerMax => 45;
        public override double SkillMax => 85;
        public override double IntellectMax => 250;
        public override double StaminaMax { get => 80; }

        
    }
}
