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
    public class ProductGroupDeleteByIdRepository : MongodbService
    {
        public string ProductGroupId { get; set; }
        public bool Execute()
        {
            var collection = this.GetCollection<BsonDocument>("ProductGroup");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", this.ProductGroupId.ToObjectId());
            var result = collection.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
    }
}
