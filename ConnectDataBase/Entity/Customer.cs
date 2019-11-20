using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CustomerDTO : Customer
    {
        public string CustomerId { get; set; }
    }
    public class Customer
    {
        public ObjectId _id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CustomerName { get; set; }
        public bool isVender { get; set; }
        public bool isCustomer { get; set; }
        public DateTime WriteDate { get; set; }
        public DateTime EditDate { get; set; }
        public int WriterId { get; set; }
        public int EditorId { get; set; }
    }
}
