using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    public class Warrior : Character
    {
        private double _minStrength = 30;
        private double _maxStrength = 50;
        private double _currentStrength;

        private double _minAgility = 15;
        private double _maxAgility = 80;
        private double _currentAgility;

        private double _currentIntelligence;
        private double _minIntelligence = 10;
        private double _maxIntelligence = 50;

        private double _currentEndurance;
        private double _minEndurance = 25;
        private double _maxEndurance = 100;

        public int Strenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Agility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Intelligence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Endurance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
