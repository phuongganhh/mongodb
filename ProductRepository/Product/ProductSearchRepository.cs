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
    public class ProductSearchRepository : MongodbService
    {
        public List<Product> Execute()
        {
            var collection = this.GetCollection<Product>("Product");
            return collection.Find(x => true).ToList();
        }
    }
}
