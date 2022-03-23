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
        public Character(string name, int power, int agility, int intelligence, int endurance)
        {
            Name = name;
            Power = power;
            
        }
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string Name { get; set; }

        public string Proffession { get; set; }
        public int Power { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Endurance { get; set; }
    }
}
