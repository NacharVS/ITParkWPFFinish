using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IT_Park_HW
{
    class Warrior : Character
    {
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public Warrior(string name, string classes, int strenght, int agility, int intellect, int endurance, int level, int experience, int point)
        {
            Name = name;
            Classes = classes;
            Strenght = strenght;
            Agility = agility;
            Intellect = intellect;
            Endurance = endurance;
            Level = level;
            Experience = experience;
            Point = point;
        }
        public string Name { get => name; set => name = value; }
        public string Classes { get => classes; set => classes = value; }
        public int Strenght { get => strenght; set => strenght = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Intellect { get => intellect; set => intellect = value; }
        public int Endurance { get => endurance; set => endurance = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Point { get => point; set => point = value; }
    }
}
