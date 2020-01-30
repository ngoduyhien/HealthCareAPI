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
        /// <summary>
        /// get all items in "collectionName"
        /// </summary>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public List<BsonDocument> GetAll(string collectionName)
        {
            var conn = new GCloudDbConnection();
            var collection = conn.database.GetCollection<BsonDocument>(collectionName);
            var list = collection.Find<BsonDocument>(new BsonDocument()).ToList();
            return list;
        }
        /// <summary>
        /// insert "document" to "collectionName"
        /// </summary>
        /// <param name="document"></param>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public bool Insert(BsonDocument document, string collectionName)
        {
            var conn = new GCloudDbConnection();
            var collection = conn.database.GetCollection<BsonDocument>(collectionName);
            var isOk = false;
            try
            {
                collection.InsertOneAsync(document);
                isOk = true;
             
            }
            catch (Exception ex)
            {
                isOk = false;
            }
            return isOk;
        }
        /// <summary>
        /// delete multiple data by "filter"
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public bool Delete(FilterDefinition<BsonDocument> filter,string collectionName)
        {
            var conn = new GCloudDbConnection();
            var collection = conn.database.GetCollection<BsonDocument>(collectionName);
            var isOk = false;
            try
            {
                collection.DeleteMany(filter);
                isOk = true;
            }
            catch (Exception ex)
            {
                
            }
            return isOk;
        }
    }
}
