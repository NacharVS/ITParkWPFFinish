using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WpfApp1
{
    [BsonDiscriminator(Required = true, RootClass = true)]
    [BsonKnownTypes(typeof(Archer), typeof(Warrior), typeof (Shaman))]

    public class BasePersonage : IPersonage
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }

        //public BasePersonage()
        //{
        //    name = "Name";
        //    _profession = "profession";
        //}

        public BasePersonage(string name)
        {
            Name = name;
            Profession = "profession";
            CurrentHelth = health;
            PowerCurrent = 10;
            SkillCurrent = 10;
            IntellectCurrent = 10;
            StaminaCurrent = 10;

        }

        protected double health = 500;
        public string name;

        public string _profession;

        public double _currentHealth;
        protected double _power;
        protected double _skill;
        protected double _intellect;
        protected double _stamina;

        public virtual string Profession { get => _profession; set => _profession = value; }
        public virtual double CurrentHelth { get => _currentHealth; set => _currentHealth = value; }
        public virtual string Name { get => name; set => name = value; }
        public virtual double PowerCurrent { get => _power; set => _power = value; }
        public virtual double SkillCurrent { get => _skill; set => _skill = value; }
        public virtual double IntellectCurrent { get => _intellect; set => _intellect = value; }
        public virtual double StaminaCurrent { get => _stamina; set => _stamina = value; }
        public virtual double PowerMin { get ; set; }
        public virtual double SkillMin { get; set; }
        public virtual double IntellectMin { get; set; }
        public virtual double StaminaMin { get; set; }
        public virtual double PowerMax { get; set; }
        public virtual double SkillMax { get; set; }
        public virtual double IntellectMax { get; set; }
        public virtual double StaminaMax { get; set; }

        
    }
}
