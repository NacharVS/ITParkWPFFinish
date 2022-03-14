using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior : Personag
    {
        public Warrior(string name, int minstrenght, int minagility, int minintelligence, int minendurance)
        {
            this.name = name;
            _minstrenght = minstrenght;
            _minagility = minagility;
            _minintelligence = minintelligence;
            _minendurance = minendurance;
        }

        public string name;
        private int _minstrenght=30;
        private int _maxstrenght=250;
        private int _minagility=15;
        private int _maxagilityt=80;
        private int _minintelligence=10;
        private int _maxintelligence=50;
        private int _minendurance=25;
        private int _maxendurance=100;



        public int MinStrenght { get => _minstrenght; set => _minstrenght=value; }
        public int MaxStrenght { get => _maxstrenght; set=>_maxstrenght=value; }
        public int MinAgility { get => _minagility; set => _minagility=value; }
        public int MaxAgility { get => _maxagilityt; set => _maxagilityt=value; }
        public int MinIntelligence { get => _minintelligence; set => _minintelligence=value; }
        public int MaxIntelligence { get => _maxintelligence; set => _maxintelligence=value; }
        public int MinEndurance { get => _minendurance; set => _minendurance=value; }
        public int MaxEndurance { get => _maxendurance; set => _maxendurance=value; }
    }
}
