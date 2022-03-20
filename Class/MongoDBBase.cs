﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor.Class
{
    class MongoDBBase
    {
<<<<<<< HEAD
        public static void SetWarrior(Warrior warrior)
=======
        public static void SetWarrior(Сharacter warrior)
>>>>>>> New
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Warriors");
            collection.InsertOne(warrior);
        }

        public static List<string> GetListWarriors()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Warriors");
            var listCharactersFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listCharactersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }

<<<<<<< HEAD
        public static Warrior GetWarrior(string name)
=======
        public static Сharacter GetWarrior(string name)
>>>>>>> New
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Warriors");
            var foundedWarrior = collection.Find(x => x.Name == name).FirstOrDefault();
            return foundedWarrior;
        }

        public static void ReplaseWarrior(string name, Warrior update)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Registration");
            var collection = database.GetCollection<Warrior>("Warriors");
            collection.ReplaceOne(x => x.Name == name, update);
        }

        public static void RemoveWarrior(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Registration");
            var collection = database.GetCollection<Warrior>("Warriors");
            collection.DeleteOne< Warrior>(x => x.Name == name);
        }
    }
}
