using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    internal interface Character
    {
        //public int Strenght { get; set; }
        //public int Agility { get; set; }
        //public int Intelligence { get; set; }
        //public int Endurance { get; set; }

        public string Name { get; }
        public int MinStrenght { get; set; }  //мин сила
        public int MaxStrenght { set; }  //макс сила
        public int MinAgility { get; set; }  //мин ловкость
        public int MaxAgility { set; }  //макс ловкость
        public int MinIntelligence { get; set; }  //мин интелект
        public int MaxIntelligence { set; }  //макс интелект
        public int MinEndurance { get; set; }  //мин выносливость
        public int MaxEndurance { set; }  //макс выносливость
        public int Damage { get; set; }  //Физ.Урон	
        public int Protection { get; set; }  //Физ.Защита
        public int MagicDamage { get; set; }  //Маг.Урон
        public int MagicProtection { get; set; }  //Маг.Защита
        public int Life { get; set; }  //Жизнь
        public int Magic { get; set; }  //Магия

    }
}
