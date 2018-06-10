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

                var config = json.Property("mongodb").Value;
                var mode = json.Property("mode").Value.ToString();

                if (mode == "dev")
                {
                    var devModel = config["mode"];
                    _client = new MongoClient("mongodb://localhost:27017");
                    _db = _client.GetDatabase("");
                }else if (mode == "product")
                {
                    _client = new MongoClient("mongodb://localhost:27017");
                    _db = _client.GetDatabase("");
                }

                
            }
            
        }
    }
}
