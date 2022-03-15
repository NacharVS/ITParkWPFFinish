using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_HOME_WORK
{
    class User
    {
        public User(string name,string profession)
        {
            Name = name;
            Profession = profession;
        }
       
        public string Name { get; set; }
        public string Profession { get; set; }

        public static void AddToDB(string name, string profession)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(new User(name,profession));
           
        }

    }
}
