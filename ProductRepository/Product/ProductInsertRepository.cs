using ConnectDataBase;
using ConnectDataBase.Entity;
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
    public class ProductInsertRepository : MongodbService
    {
        public ProductDTO Item { get; set; }
        private ProductGroup Get(string id)
        {
            var oId = ObjectId.Parse(id);
            var collection = this.GetCollection<ProductGroup>("ProductGroup");
            return collection.Find(x => x._id == oId).FirstOrDefault();
        }
        public bool Execute()
        {
            var product = new Product
            {
                Qty = this.Item.Qty,
                Barcode = this.Item.Barcode,
                Price = this.Item.Price,
                ProductName = this.Item.ProductName,
                ProductGroup = this.Get(this.Item.ProductGroupId)
            };
            var collection = this.GetCollection<Product>("Product");
            collection.InsertOne(product);
            return product._id != ObjectId.Empty;
        }
    }
}
