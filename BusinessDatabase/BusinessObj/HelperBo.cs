using BusinessDatabase.DataObject;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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

        public List<FoodDto> GetAll(string collectionName)
        {
            var conn = new GCloudDbConnection();
            conn.database.GetCollection<BsonDocument>(collectionName);
            var collection = conn.database.GetCollection<BsonDocument>(collectionName);
            var list = collection.Find<BsonDocument>(new BsonDocument()).ToList();

            List<FoodDto> objList = objList = new List<FoodDto>();
            foreach (var item in list)
            {
                objList.Add(BsonSerializer.Deserialize<FoodDto>(item));
            }


            return objList;
        }

    }
}
