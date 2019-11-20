using ConnectDataBase;
using Domain;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductGroupSearchRepository : MongodbService
    {
        public List<ProductGroup> Execute()
        {
            var collection = this.GetCollection<ProductGroup>("ProductGroup");
            return collection.Find(x => true).ToList();
        }
    }
}
