using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleItemDeleteBySaleIdRepository : Connection
    {
        public string SaleId { get; set; }
        public bool Execute()
        {
            return true;
        }
    }
}
