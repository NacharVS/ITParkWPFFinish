using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    internal class User
    {

        public static void AddToDB(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<Character>("User");
            collection.InsertOne(character);
        }

        public static List<string> ListName()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection1 = database.GetCollection<Character>("User");

            var listUsersFromDB1 = collection1.Find(x => true).ToList();

            List<string> listToReturn = new List<string>();
            foreach (var item in listUsersFromDB1)
            {
                listToReturn.Add(item._name);
            }
            return listToReturn;
        }
        public static void ReplaceCharacterToDB(string nameToReplace, Character update)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<Character>("User");
            collection.ReplaceOne(x => x._name == nameToReplace, update);
        }
        public static Character ShowCharacterInfo(string nameCharacter)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<Character>("User");
            var foundedClient = collection.Find(x => x._name == nameCharacter).FirstOrDefault();
            return foundedClient;
        }

        public static void RemoveCharacter(string nameToDelete)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<Character>("User");
            collection.DeleteOne(x => x._name == nameToDelete);
        }
        public static void DeleteAllCharacter()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<Character>("User");
            collection.DeleteMany(x => true);
        }
    }
}
