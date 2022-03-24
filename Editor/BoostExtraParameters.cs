using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    class BoostExtraParameters
    {
        public string NameMainParameter { set; get; }
        public int ValueMainParametr { set; get; }
        public string CharacterType { set; get; }

        public int РhysicalDamageValue { set; get; }
        public int PhysicalProtectionValue { set; get; }
        public int MagicDamageValue { set; get; }
        public int MagicProtectionValue { set; get; }
        public int LifeValue { set; get; }
        public int MagicValue { set; get; }

        public BoostExtraParameters(string nameMainParameter, int valueMainParametr, string characterType)
        {
            NameMainParameter = nameMainParameter;
            ValueMainParametr = valueMainParametr;
            CharacterType = characterType;

            switch (CharacterType)
            {
                case "Воин":
                    if(NameMainParameter == "Strength")
                        SetExtraParameters(7, 2, 0, 1, 5, 0);
                    if (NameMainParameter == "Agility")
                        SetExtraParameters(2, 3, 0, 0, 0, 0);
                    if (NameMainParameter == "Intelligence")
                        SetExtraParameters(0, 0, 1, 2, 0, 1);
                    if (NameMainParameter == "Endure")
                        SetExtraParameters(0, 3, 0, 1, 10, 0);
                    break;
                case "Лучник":
                    if (NameMainParameter == "Strength")
                        SetExtraParameters(3, 1, 0, 0, 2, 0);
                    if (NameMainParameter == "Agility")
                        SetExtraParameters(7, 5, 0, 3, 0, 0);
                    if (NameMainParameter == "Intelligence")
                        SetExtraParameters(0, 0, 3, 3, 0, 1);
                    if (NameMainParameter == "Endure")
                        SetExtraParameters(0, 2, 0, 1, 5, 0);
                    break;
                case "Волшебник":
                    if (NameMainParameter == "Strength")
                        SetExtraParameters(1, 1, 0, 0, 1, 0);
                    if (NameMainParameter == "Agility")
                        SetExtraParameters(1, 1, 0, 0, 0, 0);
                    if (NameMainParameter == "Intelligence")
                        SetExtraParameters(0, 1, 7, 5, 0, 2);
                    if (NameMainParameter == "Endure")
                        SetExtraParameters(0, 2, 0, 1, 3, 0);
                    break;
                default:
                    throw new Exception("Неверный тип персонажа");

            }
        }

        public void SetExtraParameters(int physicalDamageValue, int physicalProtectionValue, int magicDamageValue, int magicProtectionValue, int lifeValue, int magicValue)
        {
            РhysicalDamageValue = ValueMainParametr * physicalDamageValue;
            PhysicalProtectionValue = ValueMainParametr * physicalProtectionValue;
            MagicDamageValue = ValueMainParametr * magicDamageValue;
            MagicProtectionValue = ValueMainParametr * magicProtectionValue;
            LifeValue = ValueMainParametr * lifeValue;
            MagicValue = ValueMainParametr * magicValue;
        }
    }
}
