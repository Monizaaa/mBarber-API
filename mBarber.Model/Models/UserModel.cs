using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace mBarber.Model
{
    public class UserModel : BaseDB
    {
        public ObjectId id { get; set; }

        [BsonElement("user")]
        public string user { get; set; }

        [BsonElement("password")]
        public string password { get; set; }

        [BsonElement("first_name")]
        public string first_name { get; set; }

        [BsonElement("last_name")]
        public string last_name { get; set; }

        [BsonElement("birth_date")]
        public string birth_date { get; set; }

        [BsonElement("age")]
        public string age { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("path_profile")]
        public string path_profile { get; set; }

        [BsonElement("create_date")]
        public string create_date { get; set; }

        [BsonElement("update_date")]
        public string update_date { get; set; }
    }
}
