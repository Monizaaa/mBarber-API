using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace mBarber.Model
{
    public class BaseDB
    {
        public MongoClient _client;
        public IMongoDatabase _db;

        private class mongoConfig
        {
            public string url { get; set; }
            public string db_name { get; set; }
        }

        public BaseDB()
        {
            using (StreamReader file = File.OpenText(@"appsetting.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);

                var mode = json.Property("mode").Value.ToString();

                if (mode == "dev")
                {
                    var devUrl = json.SelectToken("mongodb.dev.url").ToString();
                    var devDBName = json.SelectToken("mongodb.dev.db_name").ToString();
                    _client = new MongoClient(devUrl);
                    _db = _client.GetDatabase(devDBName);
                }
                else if (mode == "product") {
                    var proUrl = json.SelectToken("mongodb.product.url").ToString();
                    var proDBName = json.SelectToken("mongodb.product.db_name").ToString();
                    _client = new MongoClient(proUrl);
                    _db = _client.GetDatabase(proDBName);
                }

                
            }
            
        }
    }
}
