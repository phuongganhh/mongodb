using ConnectDataBase;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRepository
{
    public class CustomerUpdateRepository : MongodbService
    {
        public Customer Item { get; set; }
        public bool Execute()
        {
            var collection = this.GetCollection<BsonDocument>("Customer");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", this.Item._id);
            var update = Builders<BsonDocument>.Update.Set("CustomerName", this.Item.CustomerName);
            var result = collection.UpdateOne(filter, update);
            return result.ModifiedCount > 0;
        }
    }
}
