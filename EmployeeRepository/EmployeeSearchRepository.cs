using ConnectDataBase;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeSearchRepository : MongodbService
    {
        public List<Domain.Employee> Execute()
        {
            var collection = this.Database.GetCollection<Domain.Employee>("Employee");
            return collection.Find(x => true).ToList();
        }
    }
}
