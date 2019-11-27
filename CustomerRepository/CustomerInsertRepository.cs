using ConnectDataBase;
using Domain;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRepository
{
    public class CustomerInsertRepository : MongodbService
    {
        public Customer Item { get; set; }
        public bool Execute()
        {
            try
            {
                this.InsertOne(this.Item);
                return this.Item._id != ObjectId.Empty;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
