﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IT_Park_HW
{
    class Unit
    {
        
        //public Unit(string name, string classes, int strength, int agility, int intellect, int endurance)
        public Unit(string name, string classes)
        {
            Name = name;
            Classes = classes;
            //Strength = strength;
            //Agility = agility;
            //Intellect = intellect;
            //Endurance = endurance;
        }
        [BsonIgnoreIfDefault]
        public string Name;
        public string Classes;
        //public int Strength;
        //public int Agility;
        //public int Intellect;
        //public int Endurance;

        //public static void AddUnitToDB(string name, string classes, int strength, int agility, int intellect, int endurance)
        public static void AddUnitToDB(string name, string classes)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Unit>("Units");
            collection.InsertOne(new Unit(name, classes));
        }
        public static List<string> GetUnitList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("RPG");
            var collection = database.GetCollection<Unit>("Units");
            var listUsersFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUsersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
    }
}

