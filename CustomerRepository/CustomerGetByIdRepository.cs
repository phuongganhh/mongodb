using ConnectDataBase;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerGetByIdRepository : MongodbService
    {
        public string CustomerId { get; set; }
        public List<Domain.Customer> Execute()
        {
            var collection = this.GetCollection<Domain.Customer>("Customer");
            return collection.Find(x => x._id == this.CustomerId.ToObjectId()).ToList();
            
        }
    }
}
