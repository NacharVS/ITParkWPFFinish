using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork.Interfaces
{
    public interface IWarrior: IPlayer
    {
        public string Profession { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligense { get; set; }
        
    }
}
