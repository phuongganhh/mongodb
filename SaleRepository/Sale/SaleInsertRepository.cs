using ConnectDataBase;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SaleInsertRepository : MongodbService
    {
        public SaleDTO Item { get; set; }
        private Employee GetEmployee(ObjectId id)
        {
            var collection = this.GetCollection<Employee>("Employee");
            return collection.Find(x => x._id == id).FirstOrDefault();
        }
        private Customer GetCustomer(ObjectId id)
        {
            var collection = this.GetCollection<Customer>("Customer");
            return collection.Find(x => x._id == id).FirstOrDefault();
        }
        public bool Execute()
        {
            try
            {
                var sale = new Sale
                {
                    Employee = this.GetEmployee(ObjectId.Parse(this.Item.EmployeeId)),
                    Customer = this.GetCustomer(ObjectId.Parse(this.Item.CustomerId)),
                    Note = this.Item.Note,
                    SaleDate = DateTime.Now,
                    Status = 0
                };
                this.InsertOne(sale);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
            //using(var cmd = new Query())
            //{
            //    cmd.QueryString = "INSERT INTO [dbo].[Sale]([SaleId] ,[CustomerId] ,[EmployeeId] ,[SaleDate],[Note],[Status]) VALUES ((SELECT isnull(MAX(SaleId),0) + 1 from [Sale])," + Item.CustomerId + "," + Item.EmployeeId + ",'" + Convert.ToDateTime(Item.SaleDate).ToString("yyyy-MM-dd") + "',N'"+Item.Note+"',0)";
            //    return cmd.ExecuteQueryNonReader();
            //}
        }
    }
}
