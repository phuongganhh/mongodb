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
    public class ProductDeleteByIdRepository : MongodbService
    {
        public string ProductId { get; set; }
        public bool Execute()
        {
            var collection = this.GetCollection<BsonDocument>("Product");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", this.ProductId);
            var result = collection.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
    }
}
