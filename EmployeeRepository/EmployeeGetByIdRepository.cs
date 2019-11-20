using ConnectDataBase;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeGetByIdRepository : MongodbService
    {
        public string EmployeeId { get; set; }
        public List<Domain.Employee> Execute()
        {
            var collection = this.GetCollection<Domain.Employee>("Employee");
            if(this.EmployeeId == null)
            {
                return new List<Domain.Employee>();
            }
            return collection.Find(x => x._id == this.EmployeeId.ToObjectId()).ToList();

        }
    } 
}
