using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace WpfCharacterEditor
{
    class Сharacter
    {
        public Сharacter(string name, string proffession)
        {
            Name = name;
            Proffession = proffession;
        }

        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        
        public string Name { get; set; }

        public string Proffession { get; set; }

        


        

    }
}
