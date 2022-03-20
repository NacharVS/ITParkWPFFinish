using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WpfApp1
{
    public class BasePersonage : Personage, IPersonage
    {
        

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }

        //double _minSPower = 10;

        public string Profession { get => _profession; set => _profession = value; }
        public double CurrentHelth { get => _currentHealth; set => _currentHealth = value; }
        public string Name { get => name; set => name = value; }
        public double PowerCurrent { get => _power; set => _power = value; }
        public double SkillCurrent { get => _skill; set => _skill = value; }
        public double IntellectCurrent { get => _intellect; set => _intellect = value; }
        public double StaminaCurrent { get => _stamina; set => _stamina = value; }
        public double PowerMin  =>  10;
        public double SkillMin { get => 10; }
        public double IntellectMin { get => 10; }
        public double StaminaMin { get => 10; }
        public double PowerMax { get; }
        public double SkillMax { get; }
        public double IntellectMax { get; }
        public double StaminaMax { get; }

        public BasePersonage(string name)
        {
            Name = name;
            Profession = "Profession";
            CurrentHelth = health;
            PowerCurrent = PowerMin;
            SkillCurrent = SkillMin;
            IntellectCurrent = IntellectMin;
            StaminaCurrent = StaminaMin;

        }

    }
}
