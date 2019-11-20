using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class SaleGetByIdAction
    {
        public string SaleId { get; set; }
        public string EditFlag { get; set; }
        public List<Domain.Sale> Execute()
        {
            using(var cmd = new SaleGetByIdRepository())
            {
                cmd.SaleId = this.SaleId;
                return cmd.Execute();
            }
        }
    }
}