using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork
{
    class Mage : Character
    {
        //[BsonIgnoreIfDefault]
        //public Object _id;
        public Mage(string name, int strenght, int agility, int intelligence, int stamina, int level
            , long experiense, int freePoint) : base("Mage")
        {
            _name = name;
            _level = level;
            _experiense = experiense;
            _freePoint = freePoint;
            _strenght = strenght;
            _agility = agility;
            _intelligence = intelligence;
            _stamina = stamina;
        }
       
        //public string Name { get => _name; set => _name = value; }
        //public string Profession { get => _profession; set => _profession = value; }
        //public int Strenght { get => _strenght; set => _strenght = value; }
        //public int Agility { get => _agility; set => _agility = value; }
        //public int Intelligence { get => _intelligence; set => _intelligence = value; }
        //public int Stamina { get => _stamina; set => _stamina = value; }
        //public int Level { get => _level; set => _level = value; }
        //public long Experiense { get => _experiense; set => _experiense = value; }
        //public int FreePoint { get => _freePoint; set => _freePoint = value; }
    }
}
