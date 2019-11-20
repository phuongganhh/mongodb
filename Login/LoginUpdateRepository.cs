using ConnectDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LoginUpdateRepository : Connection
    {
        public Domain.User Item { get; set; }
        public bool Execute()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
