
namespace WpfCharacterEditor
{
    interface ICharacter
    {

        public string Name { get; set; }

        public string Proffession { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Endurance { get; set; }

        public int FreePoints { get; set; }

        public int PhysicalDamage { get; }

        public int PhysicalProtection { get; }

        public int MagicalDamage { get; }

        public int MagicalProtection { get; }

        public int Life { get; }

        public int Magic { get; }
    }
}
