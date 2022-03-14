using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal interface Personag
    {
        public int MinStrenght { get; set; }  //мин сила
        public int MaxStrenght { get; set; }  //макс сила
        public int MinAgility { get; set; }  //мин ловкость
        public int MaxAgility { get; set; }  //макс ловкость
        public int MinIntelligence { get; set; }  //мин интелект
        public int MaxIntelligence { get; set; }  //макс интелект
        public int MinEndurance { get; set; }  //мин выносливость
        public int MaxEndurance { get; set; }  //макс выносливость

    }
}
