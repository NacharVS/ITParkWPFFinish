using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{ 
    [BsonDiscriminator("Archer")]
    public class Archer : Character
    {
       

        public static int minStr = 20;
        public static int maxStr = 55;
        public static int minAglt = 30;
        public static int maxAglt = 250;
        public static int minInt = 15;
        public static int maxInt = 70;
        public static int minStmn = 20;
        public static int maxStmn = 80;


        public Archer(string name, int power, int agility, int intelligence, int stamina, int level
            , long experiense, int freePoint) : base("Archer")
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
