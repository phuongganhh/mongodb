using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class ProductGroupListAction
    {
        public List<ProductGroup> Execute()
        {
            using (var cmd = new ProductGroupSearchRepository())
            {
                return cmd.Execute();
            }
        }
    }
}