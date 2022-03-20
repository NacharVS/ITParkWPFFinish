using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor
{
    class Property
    {
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                if (_value > value && _value > Min)
                {
                    _value = value;
                   
                }
                if (_value < value && _value < Max)
                {
                    _value = value;
                    
                }
                //else _strength = value;

            }
        }

        public int Min { get; }

        public int Max { get; }
    }
}
