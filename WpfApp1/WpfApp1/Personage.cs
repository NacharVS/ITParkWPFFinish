﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Personage 
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }

        public Personage()
        {
            name = "Name";
            _profession = " ";
        }

        protected double health = 500;
        public string name;

        public string _profession;
        
        public double _currentHealth;
        protected double _power;
        protected double _skill;
        protected double _intellect;
        protected double _stamina;

    }
}
