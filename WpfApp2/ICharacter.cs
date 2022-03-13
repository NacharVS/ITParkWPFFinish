using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public interface ICharacter
    {
        public double CurrentHealth { get; set; }
        public double MaxHealth { get; set; }
        public double MinHealth { get; set; }


        void UnitInfo();


    }
}
