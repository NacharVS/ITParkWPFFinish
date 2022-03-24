using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public class Warrior : Рersonage
    {
        protected override string _characterType => "Воин";

        protected override int _maxStrength => 250;
        protected override int _maxAgility => 80;
        protected override int _maxIntelligence => 50;
        protected override int _maxEndure => 100;

        protected override int _minStrength => 30;
        protected override int _minAgility => 15;
        protected override int _minIntelligence => 10;
        protected override int _minEndure => 25;

        public Warrior(string name, int level, int remainderPoints) : base(name, level, remainderPoints)
        {

        }
    }
}
