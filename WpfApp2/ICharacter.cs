using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public string Proffesion { get; set; }


        public double MaxStrength { get; }
        public double MinStrength { get; }
        public double CurrentStrength { get; set; }
        public double CurrentAgility { get; set; }
        public double MaxAgility { get; }
        public double MinAgility { get; }
        public double CurrentIntelligence { get; set; }
        public double MaxIntelligence { get; }
        public double MinIntelligence { get; }
        public double CurrentEndurance { get; set; }
        public double MaxEndurance { get; }
        public double MinEndurance { get; }


        public double PhysicDamage { get;  }
        public double PhysicDefense { get;}
        public double MagicDamage { get; }
        public double MagicDefense { get;  }
        public double Life { get; }
        public double Mana { get; }


    }
}
