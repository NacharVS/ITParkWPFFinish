using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkWPFFinish
{
    class Character
    {
        [BsonId]
        private ObjectId _id;
        [BsonElement("Strength")]
        private int _strength;
        private int _dexterity;

        protected Character(int strength, int dexterity)
        {
            _strength = strength;
            _dexterity = dexterity;
        }
        [BsonIgnore]
        public int Strength { get => _strength; set => _strength = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public virtual int PDamage { get; set; }

    }
}
