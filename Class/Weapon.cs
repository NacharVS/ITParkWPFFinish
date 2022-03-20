using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor
{
    class Weapon
    {
        
        public virtual int StrengthMin { get; }
        
        public virtual int AgilityMin { get; }
        
        public virtual int IntelligenceMin { get; }
        
        public virtual int EnduranceMin { get; }



        public int PhysicalDamage
        {
            get
            {
                Random rnd = new Random();
                int _damage = rnd.Next(PhysicalDamageMin, PhysicalDamageMax + 1);
                return _damage;
            }
        }

        public int PhysicalProtection { get; }

        public int MagicalDamage
        {
            get
            {
                Random rnd = new Random();
                int _damage = rnd.Next(MagicalDamageMin, MagicalDamageMax + 1);
                return _damage;
            }
        }

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
