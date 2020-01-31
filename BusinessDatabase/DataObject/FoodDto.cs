using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDatabase.DataObject
{
    [BsonIgnoreExtraElements] 
    public class FoodDto
    {

        [BsonElement("name")]
        public string _name { get; set; }

        [BsonElement("donvi")]
        public string _donvi { get; set; }

        [BsonElement("carb")]
        public string _carb { get; set; }

    }
}
