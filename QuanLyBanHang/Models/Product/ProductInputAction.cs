using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Repository;
namespace QuanLyBanHang.Models
{
    public class ProductInputAction
    {
        public string ProductId { get; set; }
        public List<Product> Execute()
        {
            using(var cmd = new ProductGetByIdRepository())
            {
                cmd.ProductId = this.ProductId;
                return cmd.Execute();
            }
        }
    }
}