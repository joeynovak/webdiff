using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebDiff.Data
{
   public abstract class MongoDocument
   {
      [BsonIgnoreIfNull]
      public BsonObjectId _id;

      public void Save()
      {
         DataSource.GetInstance().Save(this);
      }

      public void Load(string id)
      {
         
      }

      public abstract string GetCollectionName();
   }
}