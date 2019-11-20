using ConnectDataBase;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerExecuteDeleteByIdRepository : MongodbService
    {
        public string CustomerId { get; set; }
        public bool Execute()
        {
            var collection = this.GetCollection<BsonDocument>("Customer");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", this.CustomerId);
            var result =  collection.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
    }
}
