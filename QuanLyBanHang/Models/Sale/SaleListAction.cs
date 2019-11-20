﻿using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class SaleListAction
    {
        public List<Domain.Sale> Execute()
        {
            using(var cmd = new SaleSearchRepository())
            {
                return cmd.Execute();
            }
        }
    }
}