﻿using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class ProductListAction
    {
        public List<Product> Execute()
        {
            using (var cmd = new ProductSearchRepository())
            {
                return cmd.Execute();
            }
        }
    }
}