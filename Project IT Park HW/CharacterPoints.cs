using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IT_Park_HW
{
    class CharacterPoints: MainWindow
    {
        int physDamage;
        int physProtection;
        int magDamage;
        int magProtection;
        int health;
        int mana;

        public int PhysDamage { get; }
        public int PhysProtection { get; }
        public int MagDamage { get; }
        public int MagProtection { get; }
        public int Health { get; }
        public int Mana { get; }

        public CharacterPoints character = new CharacterPoints();
        public CharacterPoints()/*(int physDamage, int physProtection, int magDamage, int magProtection, int health, int mana)*/
        {
            PhysDamage = physDamage;
            PhysProtection = physProtection;
            MagDamage = magDamage;
            MagProtection = magProtection;
            Health = health;
            Mana = mana;
        }
        public void AddStatChange()
        {
            if (cmbClass.SelectedIndex == 0)
            {
                AddArcherStat();
            }
            else if (cmbClass.SelectedIndex == 1)
            {
                AddMageStat();
            }
            else if (cmbClass.SelectedIndex == 2)
            {
                AddWarriorStat();
            }
        }
        public void AddArcherStat()
        {
            physDamage = Convert.ToInt32(3 * Convert.ToInt32(lblStrength.Content) + 7 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content));
            physProtection = 1 * Convert.ToInt32(lblStrength.Content) + 5 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 2 * Convert.ToInt32(lblEndurance.Content);
            magDamage = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 3 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            magProtection = 0 * Convert.ToInt32(lblStrength.Content) + 3 * Convert.ToInt32(lblAgility.Content) + 3 * Convert.ToInt32(lblIntellect.Content) + 1 * Convert.ToInt32(lblEndurance.Content);
            health = 2 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 5 * Convert.ToInt32(lblEndurance.Content);
            mana = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
        }
        public void AddMageStat()
        {
            physDamage = 1 * Convert.ToInt32(lblStrength.Content) + 1 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            physProtection = 1 * Convert.ToInt32(lblStrength.Content) + 1 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 2 * Convert.ToInt32(lblEndurance.Content);
            magDamage = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 7 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            magProtection = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 5 * Convert.ToInt32(lblIntellect.Content) + 1 * Convert.ToInt32(lblEndurance.Content);
            health = 1 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 3 * Convert.ToInt32(lblEndurance.Content);
            mana = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 2 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
        }
        public void AddWarriorStat()
        {
            physDamage = 7 * Convert.ToInt32(lblStrength.Content) + 2 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            physProtection = 2 * Convert.ToInt32(lblStrength.Content) + 3 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 3 * Convert.ToInt32(lblEndurance.Content);
            magDamage = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
            magProtection = 1 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 2 * Convert.ToInt32(lblIntellect.Content) + 1 * Convert.ToInt32(lblEndurance.Content);
            health = 5 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 0 * Convert.ToInt32(lblIntellect.Content) + 10 * Convert.ToInt32(lblEndurance.Content);
            mana = 0 * Convert.ToInt32(lblStrength.Content) + 0 * Convert.ToInt32(lblAgility.Content) + 1 * Convert.ToInt32(lblIntellect.Content) + 0 * Convert.ToInt32(lblEndurance.Content);
        }

    }
}
