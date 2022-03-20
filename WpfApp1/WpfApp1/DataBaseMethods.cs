using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class DataBaseMethods
    {
        public static void AddPersonageToDatabase(Personage personage)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Game");
            var collection = database.GetCollection<Personage>(personage._profession);
            collection.InsertOne(personage);
        }
    }
}
