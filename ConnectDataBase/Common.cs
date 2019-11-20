using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDataBase
{
    public static class Common
    {
        public static ObjectId ToObjectId(this string s)
        {
            return ObjectId.Parse(s);
        }
    }
}
