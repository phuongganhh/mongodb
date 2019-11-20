using ConnectDataBase;
using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class ProductGetByIdAction
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