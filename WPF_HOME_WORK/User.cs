using MongoDB.Bson;
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
       public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        

        public static void AddToDB(string name, string profession)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<User>("RPG");
            collection.InsertOne(new User(name, profession));
            

           
        }

        public static List<string> GetNameList()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<User>("RPG");
            var list = collection.Find(x => true).ToList();

            List<string> listToReturn=new List<string>();
            foreach (var item in list)
            {
                listToReturn.Add(item.Name);
            }
            return listToReturn;
        }

        public static User GetUser(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<User>("RPG");
            var foundedUser = collection.Find(x => x.Name== name).FirstOrDefault();
            return foundedUser;
        }

        public static void DeleteToDB(string name, string profession)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Home_Work");
            var collection = database.GetCollection<User>("RPG");
            collection.DeleteOne(x=>x.Name ==name);
        }

        
    }

}
