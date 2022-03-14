using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCharacterEditor.Class
{
    class MongoDBBase
    {
        public static void SetCharacter(string name, int strength, int agility, int intelligence, int endurance)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Сharacters");
            collection.InsertOne(new Сharacter(name, strength, agility, intelligence, endurance));
        }

        public static List<string> GetListCharacters()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Сharacters");
            var collection = database.GetCollection<Сharacter>("Сharacters");
            var listCharactersFromDB = collection.Find(x => true).ToList();
            List<string> listToReturn = new List<string>();
            foreach (var item in listCharactersFromDB)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }
    }
}
