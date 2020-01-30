using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDatabase
{
    public class GCloudDbConnection
    {
        public IMongoDatabase database;
        public MongoClient client;
        public GCloudDbConnection()
        {
            if (client == null)
            {
                client = new MongoClient(System.Configuration.ConfigurationSettings.AppSettings.Get("HealthCareDb"));
                database = client.GetDatabase(System.Configuration.ConfigurationSettings.AppSettings.Get("DbName"));
            }
        }
    }
}
