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
        public List<Domain.CustomerDTO> Execute()
        {
            try
            {
                var collection = this.GetCollection<Domain.CustomerDTO>("Customer");
                return collection.Find(x => x.isCustomer).ToList();
            }
            catch (Exception)
            {
                return new List<CustomerDTO>();
            }
            
        }
    }
}
