using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    class Character
    {

        [BsonId]
        public ObjectId _id;

        public string _name;
        public string _profession;
        public int _strenght;
        public int _agility;
        public int _intelligence;
        public int _stamina;
        public int _level;
        public long _experiense;
        public int _freePoint;
        public Character(string profession)
        {
            _profession = profession;
        }
    }
}
