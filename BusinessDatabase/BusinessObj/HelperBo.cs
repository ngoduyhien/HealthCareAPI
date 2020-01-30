using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDatabase.BusinessObj
{
    public class HelperBo
    {

        public List<BsonDocument> GetAll(string collectionName)
        {
            var conn = new GCloudDbConnection();
            conn.database.GetCollection<BsonDocument>(collectionName);
            var collection = conn.database.GetCollection<BsonDocument>(collectionName);
            var list = collection.Find<BsonDocument>(new BsonDocument()).ToList();
            return list;
        }

    }
}
