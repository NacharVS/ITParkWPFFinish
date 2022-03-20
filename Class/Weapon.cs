using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor
{
    class Weapon
    {
        public int PhysicalDamage { get; }

        public int PhysicalProtection { get; }

        public int MagicalDamage { get; }

        public int MagicalProtection { get; }



        public virtual int PhysicalDamageMin { get; }

        public virtual int PhysicalDamageMax { get; }

        public virtual int PhysicalProtectionMin { get; }

        public virtual int PhysicalProtectionMax { get; }

        public virtual int MagicalDamageMin { get; }

        public virtual int MagicalDamageMax { get; }

        public virtual int MagicalProtectionMin { get; }

        public virtual int MagicalProtectionMax { get; }


    }
}
