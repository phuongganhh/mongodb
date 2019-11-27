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
    public class SaleUpdateRepository : MongodbService
    {
        public SaleDTO Item { get; set; }
        private Employee GetEmployee(ObjectId id)
        {
            var collection = this.GetCollection<Employee>("Employee");
            return collection.Find(x => x._id == id).FirstOrDefault();
        }
        private CustomerDTO GetCustomer(ObjectId id)
        {
            var collection = this.GetCollection<CustomerDTO>("Customer");
            return collection.Find(x => x._id == id).FirstOrDefault();
        }
        public bool Execute()
        {
            var sale = new Sale
            {
                Employee = this.GetEmployee(ObjectId.Parse(this.Item.EmployeeId)),
                Customer = this.GetCustomer(ObjectId.Parse(this.Item.CustomerId)),
                Note = this.Item.Note,
                SaleDate = DateTime.Now,
                Status = this.Item.Status
            };
            var collection = this.GetCollection<BsonDocument>("Sale");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", this.Item._id);
            var data = Builders<BsonDocument>.Update.Set("Employee", sale.Employee);
            var result = collection.UpdateOne(filter, data);
            data = Builders<BsonDocument>.Update.Set("Customer", sale.Customer);
            result = collection.UpdateOne(filter, data);
            data = Builders<BsonDocument>.Update.Set("Note", sale.Note);
            result = collection.UpdateOne(filter, data);
            data = Builders<BsonDocument>.Update.Set("SaleDate", sale.SaleDate);
            result = collection.UpdateOne(filter, data);
            data = Builders<BsonDocument>.Update.Set("Status", sale.Status);
            result = collection.UpdateOne(filter, data);
            return result.ModifiedCount > 0;
        }
    }
}
