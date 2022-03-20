﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor
{
    class Sword: Weapon
    {
        public override int PhysicalDamageMin { get => 10; }

        public override int PhysicalDamageMax { get => 50; }

        public override int PhysicalProtectionMin { get => 0; }

        public override int PhysicalProtectionMax { get => 0; }

        public override int MagicalDamageMin { get => 1; }

        public override int MagicalDamageMax { get => 5; }

        public override int MagicalProtectionMin { get => 0; }

        public override int MagicalProtectionMax { get => 0; }
    }
}
