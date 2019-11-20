using ConnectDataBase;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [BsonIgnoreExtraElements]
    public class User
    {

        public ObjectId _id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public string Token { get; set; }
        public Employee Employee { get; set; }
    }
}
