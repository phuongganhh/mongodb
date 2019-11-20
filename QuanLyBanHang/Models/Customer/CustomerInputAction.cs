using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository;
namespace QuanLyBanHang.Models
{
    public class CustomerInputAction
    {
        public string CustomerId { get; set; }
        public List<Domain.Customer> Execute()
        {
            using(var cmd = new CustomerGetByIdRepository())
            {
                cmd.CustomerId = this.CustomerId;
                return cmd.Execute();
            }
        }
    }
}