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
    public class SaleChangeStatusRepository : MongodbService
    {
        public string SaleId { get; set; }
        public bool Execute()
        {
            var collection = this.GetCollection<BsonDocument>("Sale");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", this.SaleId);
            var update = Builders<BsonDocument>.Update.Set("Status", 1);
            var result = collection.UpdateOne(filter, update);
            return result.ModifiedCount > 0;

        }
    }
}
