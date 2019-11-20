using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductGroup
    {
        public ObjectId _id { get; set; }
        public Product Product { get; set; }
        public string ProductGroupName { get; set; }
        public string Remark { get; set; }
    }
}
