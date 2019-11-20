using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeInsertRepository : MongodbService
    {
        public Employee Item { get; set; }
        public bool Execute()
        {
            try
            {
                this.InsertOne(this.Item);
                return this.Item._id != null;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
