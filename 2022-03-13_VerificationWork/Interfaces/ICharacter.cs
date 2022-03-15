using _2022_03_13_VerificationWork.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork
{
    public interface ICharacter
    {
        
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Strenght { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Stamina { get; set; }
        public int PhysicalDamage { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalDamage { get; set; }
        public int MagicalDefense   { get; set; }                                               
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }
        public long Experiense { get; set; }

        
    }
}
