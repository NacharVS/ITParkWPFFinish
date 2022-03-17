using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkWPFFinish
{
    class Warrior : Character
    {
        public Warrior() : base(30, 15)
        {
        }

        public int MaxStrength => 250;

        public override int PDamage { get => Strength * 7; }
    }
}
