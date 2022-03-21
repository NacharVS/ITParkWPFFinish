using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Personage //: IPersonage
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }

        public Personage()
        {
            name = "Name";
            _profession = " ";
        }

        protected double health = 500;
        public string name;

        public string _profession;
        
        public double _currentHealth;
        protected double _power;
        protected double _skill;
        protected double _intellect;
        protected double _stamina;

        //public string Profession { get => _profession; set => _profession = value; }
        //public double CurrentHelth { get => _currentHealth; set => _currentHealth = value; }
        //public string Name { get => name; set => name = value; }
        //public double PowerCurrent { get => _power; set => _power = value; }
        //public double SkillCurrent { get => _skill; set => _skill = value; }
        //public double IntellectCurrent { get => _intellect; set => _intellect = value; }
        //public double StaminaCurrent { get => _stamina; set => _stamina = value; }

        //public double PowerMin => throw new NotImplementedException();

        //public double SkillMin => throw new NotImplementedException();

        //public double IntellectMin => throw new NotImplementedException();

        //public double StaminaMin => throw new NotImplementedException();

        //public double PowerMax => throw new NotImplementedException();

        //public double SkillMax => throw new NotImplementedException();

        //public double IntellectMax => throw new NotImplementedException();

        //public double StaminaMax => throw new NotImplementedException();
    }
}
