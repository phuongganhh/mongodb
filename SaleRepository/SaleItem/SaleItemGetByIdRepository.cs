using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDataBase;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Repository
{
    public class SaleItemGetByIdRepository : MongodbService
    {
        public string SaleId { get; set; }
        public List<SaleItem> Execute()
        {
            var collection = this.GetCollection<Sale>("Sale");
            var item = collection.Find(x => x._id == ObjectId.Parse(this.SaleId)).FirstOrDefault();
            return item.SaleItems?.ToList() ?? new List<SaleItem>();
        }
    }
}
