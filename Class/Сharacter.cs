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


        }

        [BsonIgnoreIfDefault]
        public ObjectId ID { get; set; }
        
        public string Name { get; set; }

        public string Proffession { get; set; }

        public Strength Strength { get; set; }

        public Agility Agility { get; set; }

        public Intelligence Intelligence { get; set; }

        public Endurance Endurance { get; set; }


        

    }
}
