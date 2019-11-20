using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;
using System.Data;
using System.Dynamic;
using MongoDB.Driver;

namespace Repository
{
    public class CustomerSearchRepository : MongodbService
    {
        public List<Domain.Customer> Execute()
        {
            var collection = this.GetCollection<Domain.Customer>("Customer");
            return collection.Find(x => x.isCustomer).ToList();
        }
    }
}
