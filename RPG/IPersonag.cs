using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal interface IPersonag
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; } 
        public int Points { get; set; }
        public static int MinStrenght { get; }  //мин сила
        public int MaxStrenght { get; }  //макс сила
        public int Strenght { get; set; }
        public static int MinAgility { get; }  //мин ловкость
        public int MaxAgility { get; }  //макс ловкость
        public int Agility { get; set; }
        public static int MinIntelligence { get;  }  //мин интелект
        public int MaxIntelligence { get; }  //макс интелект
        public int Intelligence { get; set; }
        public static int MinEndurance { get; }  //мин выносливость
        public int MaxEndurance { get; }  //макс выносливость
        public int Endurance { get; set; }
        public static int Damage { get;}  //Физ.Урон	
        public static int Protection { get; }  //Физ.Защита
        public static int MagicDamage { get;  }  //Маг.Урон
        public static int MagicProtection { get;  }  //Маг.Защита
        public static int Life { get;  }  //Жизнь
        public static int Magic { get;  }  //Магия
    }
}
