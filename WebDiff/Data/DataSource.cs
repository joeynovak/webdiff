using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using WebDiff.Data;

namespace WebDiff
{
   public class DataSource : IDisposable
   {
      /* STATIC STUFF */
      private static DataSource _instance = new DataSource();

      public static DataSource GetInstance()
      {
         return _instance;
      }

      /* NON-STATIC STUFF */
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

      public List<T> GetAll<T>() where T : MongoDocument, new()
      {
         MongoDocument t = new T();
         List<T> results = new List<T>();
         IMongoCollection<BsonDocument> collection =
             mongo.GetDatabase("web-diff").GetCollection<BsonDocument>(t.GetCollectionName());
         var documents = collection.Find(
             new BsonDocument()
         ).ToList();

         foreach (var document in documents)
         {
            results.Add(BsonSerializer.Deserialize<T>(document));
         }

         return results;
      }

      public List<T> GetAllForConfig<T>(Config config) where T : MongoDocument, new()
      {
         MongoDocument t = new T();
         List<T> results = new List<T>();
         IMongoCollection<BsonDocument> collection =
             mongo.GetDatabase("web-diff").GetCollection<BsonDocument>(t.GetCollectionName());
         var documents = collection.Find(
             new BsonDocument() { { "Config",  config._id}}
         ).ToList();

         foreach (var document in documents)
         {
            results.Add(BsonSerializer.Deserialize<T>(document));
         }
         return results;
      }     

      public void Dispose()
      {
         mongo = null;
      }

      public void Save(MongoDocument document)
      {
         IMongoDatabase database = mongo.GetDatabase("web-diff");
         IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(document.GetCollectionName());
         if (document._id == null)
            collection.InsertOne(document.ToBsonDocument());
         else
         {
            collection.FindOneAndReplace(
               new BsonDocument{
                  {"_id", document._id }
               },
               document.ToBsonDocument()
            );
         }
      }
   }
}