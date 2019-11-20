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
    public class ProductGetByIdRepository : MongodbService
    {
        public string ProductId { get; set; }
        public List<Product> Execute()
        {
            var collection = this.GetCollection<Product>("Product");
            return collection.Find(x => x._id == ObjectId.Parse(this.ProductId)).ToList();
        }
    }
}
