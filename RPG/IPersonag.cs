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
        public int Damage { get; set; }  //Физ.Урон	
        public int Protection { get; set; }  //Физ.Защита
        public int MagicDamage { get; set; }  //Маг.Урон
        public int MagicProtection { get; set; }  //Маг.Защита
        public int Life { get; set; }  //Жизнь
        public int Magic { get; set; }  //Магия
    }
}
