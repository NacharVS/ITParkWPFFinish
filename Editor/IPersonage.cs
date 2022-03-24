using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    public interface IPersonage
    {
        string Name { set; get; }
        string CharacterType { get; }

        int CountRemainderPoints { set; get; }
        int Level { set; get; }
        int Experience { set; get; }

        int Strength { set; get; }
        int Agility { set; get; }
        int Intelligence { set; get; }
        int Endure { set; get; }

        int MaxStrength { get; }
        int MaxAgility { get; }
        int MaxIntelligence { get; }
        int MaxEndure {  get; }

        int MinStrength { get; }
        int MinAgility { get; }
        int MinIntelligence { get; }
        int MinEndure { get; }

        int РhysicalDamage { get; }
        int PhysicalProtection { get; }
        int MagicDamage { get; }
        int MagicProtection { get; }
        int Life { get; }
        int Magic { get; }

        void LevelIncrease();
        void СhangeExtraParameters();

        void PointsStrengthIncrease();
        void PointsAgilityIncrease();
        void PointsIntelligenceIncrease();
        void PointsEndureIncrease();


        void PointsStrengthDecrease();
        void PointsAgilityDecrease();
        void PointsIntelligenceDecrease();
        void PointsEndureDecrease();

        void ExperienceIncrease(int experience);
    }
}
