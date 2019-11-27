using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SaleDTO : Sale
    {
        public string EmployeeId { get; set; }
        public string CustomerId { get; set; }
    }
    public class Sale
    {
        public ObjectId _id { get; set; }
        public Employee Employee { get; set; }
        public CustomerDTO Customer { get; set; }
        public DateTime SaleDate { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public IEnumerable<SaleItem> SaleItems { get; set; }
    }
}
