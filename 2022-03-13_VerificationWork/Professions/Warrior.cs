using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork.Interfaces
{
    internal class Warrior : Character,ICharacter
    {
        public Warrior(string name, string profession, int strenght, int agility, int intelligence,int stamina)
        {
            Name = name;
            Profession = profession;
            Strenght = strenght;
            Agility = agility;
            Intelligence = intelligence;
            Stamina = stamina;
        }
        public string Name { get => _name; set => _name=value; }
        public string Profession { get => _profession; set => _profession=value; }
        public int Strenght { get => _strenght; set => _strenght = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Stamina { get => _stamina; set => _stamina=value; }
        public int PhysicalDamage { get => _physicalDamage; set => _physicalDamage=value; }
        public int PhysicalDefense { get => _physicalDefense; set => _physicalDefense=value; }
        public int MagicalDamage { get => _magicalDamage; set => _magicalDamage=value; }
        public int MagicalDefense { get => _magicalDefense; set => _magicalDefense=value; }
        public int Health { get => _health; set => _health=value; }
        public int Mana { get => _mana; set => _mana=value; }
        public int Level { get => _level; set => _level=value; }
        public long Experiense { get => _experiense; set => _experiense=value; }
    }
}
