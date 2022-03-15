
namespace WpfCharacterEditor
{
    interface ICharacter
    {
        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Endurance { get; set; }

        public int PhysicalDamage { get; set; }

        public int PhysicalProtection { get; set; }

        public int MagicalDamage { get; set; }

        public int MagicalProtection { get; set; }

        public int Life { get; set; }

        public int Magic { get; set; }
    }
}
