using ConnectDataBase;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleGetByIdRepository : MongodbService
    {
        public string SaleId { get; set; }
        public List<Domain.Sale> Execute()
        {
            var collection = this.GetCollection<Domain.Sale>("Sale");
            return collection.Find(x => x._id == this.SaleId.ToObjectId()).ToList();
        }
    }
}
