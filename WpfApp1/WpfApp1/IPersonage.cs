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
        public double PowerCurrent { get; set; }
        public double SkillCurrent { get; set; }
        public double IntellectCurrent { get; set; }
        public double StaminaCurrent { get; set; }
        public int PowerMin { get; set; }
        public int SkillMin { get; set; }
        public int IntellectMin { get; set; }
        public int StaminaMin { get; set; }
        public int PowerMax { get; set; }
        public int SkillMax { get; set; }
        public int IntellectMax { get; set; }
        public int StaminaMax { get; set; }
        public void ChangeCharateristic () { }
        //public void Show() { }
        public void Update() { }
        public void AddToDB() { }


    }
}
