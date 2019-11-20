using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Repository;
namespace QuanLyBanHang.Models
{
    public class ProductGroupInputAction
    {
        public string ProductGroupId { get; set; }
        public List<ProductGroup> Execute()
        {
            using(var cmd = new ProductGroupGetByIdRepository())
            {
                cmd.ProductGroupId = this.ProductGroupId;
                return cmd.Execute();
            }
        }
    }
}