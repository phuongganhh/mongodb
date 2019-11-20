using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Repository;
namespace QuanLyBanHang.Models
{
    public class SaleViewAction
    {
        public string SaleId { get; set; }
        public List<SaleItem> Execute()
        {
            using(var cmd = new SaleItemGetByIdRepository())
            {
                cmd.SaleId = this.SaleId;
                return cmd.Execute();
            }
        }
    }
}