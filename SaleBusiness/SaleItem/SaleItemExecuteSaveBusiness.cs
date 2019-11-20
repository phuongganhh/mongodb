using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectDataBase;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using Repository;

namespace Business
{
    public class SaleItemExecuteSaveBusiness : MongodbService
    {
        public List<SaleItemDTO> Item { get; set; }
        private Sale GetSale(string id)
        {
            return this.GetCollection<Sale>("Sale").Find(x => x._id == id.ToObjectId()).FirstOrDefault();
        }
        private Product GetProduct(string id)
        {
            return this.GetCollection<Product>("Product").Find(x => x._id == id.ToObjectId()).FirstOrDefault();
        }
        public bool Execute()
        {
            try
            {
                var sale = this.Item.FirstOrDefault();
                if(sale == null)
                {
                    throw new ArgumentNullException();
                }
                var SaleData = this.GetSale(sale.SaleId);
                SaleData.SaleItems = this.Item.Select(x =>
                {
                    return new SaleItem
                    {
                        Product = this.GetProduct(x.ProductId),
                        Qty = x.Qty,
                        _id = ObjectId.GenerateNewId()
                    };
                });
                var collection = this.GetCollection<BsonDocument>("Sale");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", SaleData._id);
                var data = Builders<BsonDocument>.Update.Set("SaleItems", SaleData.SaleItems);
                var result = collection.UpdateOne(filter, data);
                return result.ModifiedCount > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
