using ConnectDataBase;
using Domain;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class SaleSearchRepository : MongodbService
    {
        public List<Sale> Execute()
        {
            var collection = this.Database.GetCollection<Sale>("Sale");
            return collection.Find(x => true).ToList();
        }
    }
}
