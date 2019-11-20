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
    public class ProductGroupGetByIdRepository : MongodbService
    {
        public string ProductGroupId { get; set; }
        public List<ProductGroup> Execute()
        {
            return this.GetCollection<ProductGroup>("ProductGroup").Find(x => x._id == ObjectId.Parse(this.ProductGroupId)).ToList();
            
        }
    }
}
