using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkWPFFinish
{
    class Mage:Character
    {
        public Mage() : base(15, 20)
        {
        }
        [BsonIgnore]
        public override int PDamage { get => Strength; }
        public int MaxStrength => 45;
    }
}
