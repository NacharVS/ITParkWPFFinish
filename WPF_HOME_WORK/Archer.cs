using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    public class Archer:Character
    {
        private double _minStrength = 20;
        private double _maxStrength = 55;
        private double _currentStrength;

        private double _minAgility = 30;
        private double _maxAgility = 250;
        private double _currentAgility;

        private double _currentIntelligence;
        private double _minIntelligence = 15;
        private double _maxIntelligence = 70;

        private double _currentEndurance;
        private double _minEndurance = 20;
        private double _maxEndurance = 80;

        public int Strenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Agility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Intelligence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Endurance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
