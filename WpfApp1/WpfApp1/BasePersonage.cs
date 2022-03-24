using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WpfApp1
{
    public class BasePersonage : Personage, IPersonage
    {
        
        public string Profession { get => _profession; set => _profession = value; }
        public double CurrentHelth { get => _currentHealth; set => _currentHealth = value; }
        public string Name { get => name; set => name = value; }
        public double PowerCurrent { get => _power; set => _power = value; }
        public double SkillCurrent { get => _skill; set => _skill = value; }
        public double IntellectCurrent { get => _intellect; set => _intellect = value; }
        public double StaminaCurrent { get => _stamina; set => _stamina = value; }
        public double PowerMin { get ; set; }
        public double SkillMin { get; set; }
        public double IntellectMin { get; set; }
        public double StaminaMin { get; set; }
        public double PowerMax { get; set; }
        public double SkillMax { get; set; }
        public double IntellectMax { get; set; }
        public double StaminaMax { get; set; }

        public BasePersonage(string name)
        {
            Name = name;
            Profession = "profession";
            CurrentHelth = health;
            
        }

        public BasePersonage ConvertToBasePersonage()
        {
            throw new System.NotImplementedException();
        }
    }
}
