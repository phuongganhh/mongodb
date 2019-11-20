using ConnectDataBase;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleDeleteByIdRepository : MongodbService
    {
        public string SaleId { get; set; }
        public bool Execute()
        {
            var collection = this.GetCollection<Domain.Sale>("Sale");
            var result =  collection.DeleteOne(x => x._id == this.SaleId.ToObjectId());
            return result.DeletedCount > 0;
        }
    }
}
