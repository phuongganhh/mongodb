using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDataBase
{
    public class MongodbService : IDisposable
    {
        private static MongodbService _instance { get; set; }
        public static MongodbService Instance
        {
            get
            {
                return _instance ?? (_instance = new MongodbService());
            }
        }
        private IMongoDatabase Database { get; set; }
        public MongodbService()
        {
            this.Database = new MongoClient("mongodb://localhost:27017").GetDatabase("QLBH");
        }
        private IMongoCollection<T> GetCollection<T>(T obj)
        {
            return this.Database.GetCollection<T>(typeof(T).Name);
        }
        public void InsertOne<T>(T data)
        {
            IMongoCollection<T> collection = this.GetCollection<T>(data);
            collection.InsertOne(data);
        }

        public void Dispose()
        {
        }
    }
}
