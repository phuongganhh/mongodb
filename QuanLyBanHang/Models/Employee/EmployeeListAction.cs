﻿using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class EmployeeListAction
    {
        public List<Domain.Employee> Execute()
        {
            using(var cmd = new EmployeeSearchRepository())
            {
                return cmd.Execute();
            }
        }
    }
}