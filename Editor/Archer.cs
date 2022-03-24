using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class Archer : Рersonage
    {
        protected override string _characterType => "Лучник";

        protected override int _maxStrength => 55;
        protected override int _maxAgility => 250;
        protected override int _maxIntelligence => 70;
        protected override int _maxEndure => 80;

        protected override int _minStrength => 20;
        protected override int _minAgility => 30;
        protected override int _minIntelligence => 15;
        protected override int _minEndure => 20;

        public Archer(string name, int level, int remainderPoints) : base(name, level, remainderPoints)
        {

        }
    }
}
