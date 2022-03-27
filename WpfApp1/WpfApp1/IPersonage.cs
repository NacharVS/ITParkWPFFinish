using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public interface IPersonage
    {
        public double CurrentHelth { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public double PowerCurrent { get; set; }
        public double SkillCurrent { get; set; }
        public double IntellectCurrent { get; set; }
        public double StaminaCurrent { get; set; }
        public double PowerMin { get; }
        public double SkillMin { get;}
        public double IntellectMin { get;}
        public double StaminaMin { get;}
        public double PowerMax { get; }
        public double SkillMax { get; }
        public double IntellectMax { get; }
        public double StaminaMax { get; }
        
        
    }
}
