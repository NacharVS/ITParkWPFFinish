using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor
{
    class Сharacter
    {
        public Сharacter(string name, int strength, int agility, int intelligence, int endurance)
        {
            Name = name;
            Proffession = "Character";
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            Endurance = endurance;
        }

        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        
        public string Name { get; set; }

        public string Proffession { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Endurance { get; set; }


        

    }
}
