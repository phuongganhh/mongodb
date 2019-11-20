using ConnectDataBase;
using Domain;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductGroupInsertRepository : MongodbService
    {
        public ProductGroup Item { get; set; }
        public bool Execute()
        {
            if(this.Item != null)
            {
                this.GetCollection<ProductGroup>("ProductGroup").InsertOne(this.Item);
                return this.Item._id != ObjectId.Empty;
            }
            return false;
        }
    }
}
