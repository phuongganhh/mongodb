using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SaleItemDTO : SaleItem
    {
        public string ProductId { get; set; }
        public string SaleId { get; set; }
    }
    public class SaleItem
    {
        public ObjectId _id { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
        public Sale Sale { get; set; }
    }
}
