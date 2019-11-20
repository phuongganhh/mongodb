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
    public class VenderGetByIdRepository : MongodbService
    {
        public string CustomerId { get; set; }
        public List<Customer> Execute()
        {
            var collection = this.GetCollection<Customer>("Customer");
            return collection.Find(x => x._id == this.CustomerId.ToObjectId()).ToList();
            
        }
    }
}
