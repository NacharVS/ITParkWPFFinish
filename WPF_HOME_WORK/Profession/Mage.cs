using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    public class Mage : Character
    {
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
    }
}
