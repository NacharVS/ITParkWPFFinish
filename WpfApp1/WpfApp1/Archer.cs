using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1
{
    [BsonDiscriminator("Archer")]
    internal class Archer : BasePersonage
    {
        public Archer(string name) : base(name)
        {
            Name = name;
            Profession = "archer";
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
        public override double PowerMin => 20;
        public override double SkillMin { get => 30; }
        public override double IntellectMin { get => 15; }
        public override double StaminaMin { get => 20; }
        public override double PowerMax { get => 55; }
        public override double SkillMax { get => 250; }
        public override double IntellectMax { get => 70; }
        public override double StaminaMax { get => 50; }

    }
}
