using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Personage
    {

        public Personage()
        {
            name = "Name";
        }

        protected double health = 500;
        public string name;

        protected string _profession = "Profession";
        
        public double _currentHealth;
        protected double _power;
        protected double _skill;
        protected double _intellect;
        protected double _stamina;
        
    }
}
