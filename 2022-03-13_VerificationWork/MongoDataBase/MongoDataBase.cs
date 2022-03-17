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
        public static void AddWarriorToDB(string name, string profession, int strenght, int agility, int intelligenсe
            ,int stamina, int level, long experiense, int freePoint)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Warrior>("Characters");
            collection.InsertOne(new Warrior(name, profession, strenght, agility, intelligenсe,stamina
                , level, experiense, freePoint));
        }
        public static void AddArcherToDB(string name, string profession, int strenght, int agility, int intelligenсe
            , int stamina, int level, long experiense, int freePoint)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Archer>("Characters");
            collection.InsertOne(new Archer(name, profession, strenght, agility, intelligenсe, stamina
                , level, experiense, freePoint));
        }
        public static void AddWizardToDB(string name, string profession, int strenght, int agility, int intelligenсe
           , int stamina, int level, long experiense, int freePoint)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Wizard>("Characters");
            collection.InsertOne(new Wizard(name, profession, strenght, agility, intelligenсe, stamina
                , level, experiense, freePoint));
        }
        public static List<string> GetCharacterNameList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Warrior>("Characters");
            var listUsersFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listUsersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
        public static void ReplaceWarrior(string nameToReplace, Warrior update)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Warrior>("Characters");
            collection.ReplaceOne(x => x.Name == nameToReplace, update);
        }
        public static void ReplaceArcher(string nameToReplace, Archer update)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Archer>("Characters");
            collection.ReplaceOne(x => x.Name == nameToReplace, update);
        }
        public static void ReplaceWizard(string nameToReplace, Wizard update)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Wizard>("Characters");
            collection.ReplaceOne(x => x.Name == nameToReplace, update);
        }
        public static Warrior ShowWarriorInfo(string nameCharacter)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Warrior>("Characters");
            var foundedClient = collection.Find(x => x.Name == nameCharacter).FirstOrDefault();
            return foundedClient;
        }
        public static string FindDuplicate(string nameCharacter)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Warrior>("Characters");
            var foundedCharacter = collection.Find(x => x.Name == nameCharacter).FirstOrDefault();
            string foundedName = foundedCharacter.Name;
            return foundedName;

        }
        public static void RemoveCharacter(string nameToDelete)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Warrior>("Characters");
            collection.DeleteOne(x => x.Name == nameToDelete);
        }
        public static void DeleteAllCharacter()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Character_Editor");
            var collection = database.GetCollection<Warrior>("Characters");
            collection.DeleteMany(x => true);
        }
    }
}
