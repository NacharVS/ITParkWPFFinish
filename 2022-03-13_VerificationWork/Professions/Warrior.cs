using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork.Interfaces
{
    class Warrior : Character
    {
        [BsonIgnoreIfDefault]
        public Object _id;
        public Warrior(string name, int strenght, int agility, int intelligence, int stamina, int level
            , long experiense, int freePoint) : base ("Warrior")
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
        //public string name { get => _name; set => _name = value; }
        //public string profession { get => _profession; set => _profession = value; }
        //public int strenght { get => _strenght; set => _strenght = value; }
        //public int agility { get => _agility; set => _agility = value; }
        //public int intelligence { get => _intelligence; set => _intelligence = value; }
        //public int stamina { get => _stamina; set => _stamina = value; }
        //public int level { get => _level; set => _level = value; }
        //public long experiense { get => _experiense; set => _experiense = value; }
        //public int freePoint { get => _freePoint; set => _freePoint = value; }
    }
}
