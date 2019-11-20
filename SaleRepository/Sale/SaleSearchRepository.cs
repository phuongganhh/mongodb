using ConnectDataBase;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleSearchRepository : MongodbService
    {
        public List<Domain.Sale> Execute()
        {
            var collection = this.Database.GetCollection<Domain.Sale>("Sale");
            return collection.Find(x => true).ToList();
        }
    }
}
