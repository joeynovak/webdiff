using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using WebDiff.Data;

namespace WebDiff
{
    public class DataSource
    {
        private MongoClient _mongoClient = null;
        private MongoClient mongo
        {
            get
            {
                if (_mongoClient == null)
                {
                    _mongoClient = new MongoClient();
                }
                return _mongoClient;                
            }
            set { _mongoClient = value; }
        }

        public List<Data.Session> GetSessions()
        {
            List<Session> results = new List<Session>();
            IMongoCollection<BsonDocument> collection =
                mongo.GetDatabase("web-diff").GetCollection<BsonDocument>("sessions");
            var documents = collection.Find(
                new BsonDocument()
            ).ToList();

            foreach (var document in documents)
            {
                results.Add(BsonSerializer.Deserialize<Session>(document));
            }

            return results;
        }
    }
}