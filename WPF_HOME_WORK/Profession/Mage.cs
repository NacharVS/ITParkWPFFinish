using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{ 
    [BsonDiscriminator("Mage")]
    public class Mage : Character
    {
      
        public static int minStr = 15;
        public static int maxStr = 45;
        public static int minAglt = 20;
        public static int maxAglt = 85;
        public static int minInt = 35;
        public static int maxInt = 250;
        public static int minStmn = 20;
        public static int maxStmn = 80;
       





        public Mage(string name, int power, int agility, int intelligence, int stamina, int level
            , long experiense, int freePoint) : base("Mage")
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
