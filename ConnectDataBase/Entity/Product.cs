using ConnectDataBase.Entity;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductDTO : Product
    {
        public string ProductGroupId { get; set; }
    }
    public class Product : Base
    {
        public ProductGroup ProductGroup { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Barcode { get; set; }
        public int Qty { get; set; }
    }
}
