using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class VenderInputAction
    {
        public string CustomerId { get; set; }
        public List<Customer> Execute()
        {
            using(var cmd = new VenderGetByIdRepository())
            {
                cmd.CustomerId = this.CustomerId;
                return cmd.Execute();
            }
        }
    }
}