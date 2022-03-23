using _2022_03_13_VerificationWork.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_13_VerificationWork.MongoDB
{
    internal class MongoDataBase
    {
        public static void AddCharacterToDB(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Character>("Characters");
            collection.InsertOne(character);
        }
        public static List<string> GetCharacterNameList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection1 = database.GetCollection<Warrior>("Characters");
            var collection2 = database.GetCollection<Archer>("Characters");
            var collection3 = database.GetCollection<Mage>("Characters");
            var listUsersFromDB1 = collection1.Find(x => true).ToList();
            var listUsersFromDB2 = collection2.Find(x => true).ToList();
            var listUsersFromDB3 = collection3.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUsersFromDB1)
            {
                listToReturn.Add(item._name);
            }
            foreach (var item in listUsersFromDB2)
            {
                listToReturn.Add(item._name);
            }
            foreach (var item in listUsersFromDB3)
            {
                listToReturn.Add(item._name);
            }
            return listToReturn;
        }
        public static void ReplaceCharacterToDB(string nameToReplace, Character update)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Character>("Characters");
            collection.ReplaceOne(x => x._name == nameToReplace, update);
        }
        //public static void ReplaceArcher(string nameToReplace, Archer update)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Character_Editor");
        //    var collection = database.GetCollection<Archer>("Characters");
        //    collection.ReplaceOne(x => x.Name == nameToReplace, update);
        //}
        //public static void ReplaceWizard(string nameToReplace, Wizard update)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Character_Editor");
        //    var collection = database.GetCollection<Wizard>("Characters");
        //    collection.ReplaceOne(x => x.Name == nameToReplace, update);
        //}
        public static Character ShowCharacterInfo(string nameCharacter)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Character>("Characters");
            var foundedClient = collection.Find(x => x._name == nameCharacter).FirstOrDefault();
            return foundedClient;
        }
        public static void RemoveCharacter(string nameToDelete)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Character>("Characters");
            collection.DeleteOne(x => x._name == nameToDelete);
        }
        public static void DeleteAllCharacter()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Character>("Characters");
            collection.DeleteMany(x => true);
        }
    }
}
