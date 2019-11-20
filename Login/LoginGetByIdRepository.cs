using ConnectDataBase;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LoginGetByIdRepository : MongodbService
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Domain.User> Execute()
        {
            //using(var cmd = new Query())
            //{
            //    cmd.QueryString = "SELECT [User].*,[Employee].EmployeeName FROM [User] LEFT JOIN [Employee] on [Employee].EmployeeId = [User].EmployeeId WHERE [User].Username = '" + this.Username + "' AND [User].Password='" + this.Password + "'";
            //    return cmd.ExecuteQuery();
            //}
            var collection = this.Database.GetCollection<Domain.User>("User");
            var users = collection.Find(x => x.Username.Equals(this.Username)).ToList();
            return users;
        }
    }
}
