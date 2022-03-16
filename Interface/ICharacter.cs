
using MongoDB.Bson;

namespace WpfCharacterEditor
{
    interface ICharacter
    {
        //public ObjectId _id { get; set; }

        public string Name { get; set; }

        public string Proffession { get; set; }

        public int Strength { get; set; }

        public int StrengthMin { get; }

        public int StrengthMax { get; }

        public int Agility { get; set; }

        public int AgilityMin { get; }

        public int AgilityMax { get; }

        public int Intelligence { get; set; }

        public int IntelligenceMin { get; }

        public int IntelligenceMax { get; }

        public int Endurance { get; set; }

        public int EnduranceMin { get; }

        public int EnduranceMax { get; }

        public int FreePoints { get; set; }

        public int FreePointsMin { get; }

        public int FreePointsMax { get; set; }

        public int PhysicalDamage { get; }

        public int PhysicalProtection { get; }

        public int MagicalDamage { get; }

        public int MagicalProtection { get; }

        public int Life { get; }

        public int Magic { get; }
    }
}
