using ConnectDataBase;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeDeleteByIdRepository : MongodbService
    {
        public string EmployeeId { get; set; }
        public bool Execute()
        {
            var collection = this.GetCollection<BsonDocument>("Employee");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", this.EmployeeId.ToObjectId());
            var result = collection.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
    }
}
