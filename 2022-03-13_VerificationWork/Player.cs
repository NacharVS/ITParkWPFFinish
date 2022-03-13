using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork
{
    internal class Player
    {
        public Player(string name, string profession, int strenght, int dexterity, int intelligense,
            int physicalDamage, int physicalDefense, int magicalDamage, int magicalDefense, int health, int mana, 
            int level, long experiense)
        {
            Name = name;
            Profession = profession;
            Strenght = strenght;
            Dexterity = dexterity;
            Intelligense = intelligense;
            PhysicalDamage = physicalDamage;
            PhysicalDefense = physicalDefense;
            MagicalDamage = magicalDamage;
            MagicalDefense = magicalDefense;
            Health = health;
            Mana = mana;
            Level = level;
            Experiense = experiense;
        }

        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligense { get; set; }
        public int PhysicalDamage { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalDamage { get; set; }
        public int MagicalDefense   { get; set; }                                               
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }
        public long Experiense { get; set; }

        public static void AddPlayerToDB(string name, string profession, int strenght, int dexterity, int intelligense,
            int physicalDamage, int physicalDefense, int magicalDamage, int magicalDefense, int health, int mana,
            int level, long experiense)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Player>("Players");
            collection.InsertOne(new Player(name, profession, strenght, dexterity, intelligense, physicalDamage,
                physicalDefense, magicalDamage, magicalDefense, health, mana, level, experiense));
        }
    }
}
