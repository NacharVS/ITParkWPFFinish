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
        public Сharacter(string name, string proffession, int strength, int agility, int intelligence, int endurance)
        {
            Name = name;

        }

        [BsonIgnoreIfDefault]
        public ObjectId ID { get; set; }
        
        public string Name { get; set; }

        public string Proffession { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Endurance { get; set; }


        public static void AddToDB(string name, string proffession, int strength, int agility, int intelligence, int endurance)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Сharacter");
            collection.InsertOne(new Сharacter(name, proffession, strength, agility, intelligence, endurance));
        }

    }
}
