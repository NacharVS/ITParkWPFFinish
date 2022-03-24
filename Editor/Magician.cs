using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class Magician : Рersonage
    {
        protected override string _characterType => "Волшебник";

        protected override int _maxStrength => 45;
        protected override int _maxAgility => 85;
        protected override int _maxIntelligence => 250;
        protected override int _maxEndure => 80;

        protected override int _minStrength => 15;
        protected override int _minAgility => 20;
        protected override int _minIntelligence => 35;
        protected override int _minEndure => 20;

        public Magician(string name, int level, int remainderPoints) : base(name, level, remainderPoints)
        {

        }
    }
}
