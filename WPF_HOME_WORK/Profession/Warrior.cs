using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    [BsonDiscriminator("Warrior")]
    public class Warrior : Character
    {
        
        public static int minStr = 30;
        public static int maxStr = 250;
        public static int minAglt = 15;
        public static int maxAglt = 80;
        public static int minInt = 10;
        public static int maxInt = 50;
        public static int minStmn = 25;
        public static int maxStmn = 100;

        public Warrior(string name, int power, int agility, int intelligence, int stamina, int level
            , long experiense, int freePoint) : base("Warrior")
        {
            _name = name;
            _level = level;
            _experiense = experiense;
            _freePoint = freePoint;
            _strenght = power;
            _agility = agility;
            _intelligence = intelligence;
            _stamina = stamina;
        }
    }
}
