using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork
{
    internal class Character
    {
        [BsonIgnoreIfDefault]
        ObjectId _id;
        internal string _name;
        internal string _profession;
        internal int _strenght;
        internal int _agility;
        internal int _intelligence;
        internal int _stamina;
        internal int _physicalDamage;
        internal int _physicalDefense;
        internal int _magicalDamage;
        internal int _magicalDefense;
        internal int _health;
        internal int _mana;
        internal int _level;
        internal long _experiense;
    }
}
