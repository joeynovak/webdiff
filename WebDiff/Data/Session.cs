using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebDiff.Data
{
   [BsonIgnoreExtraElements]
   public class Session : MongoDocument
   {
      [BsonIgnoreIfNull]      
      public Url[] Urls;
      public Config ConfigAtTimeOfSession;
      public BsonObjectId Config;      
      public DateTime Time;      

      public override string ToString()
      {
         return (ConfigAtTimeOfSession != null ? ConfigAtTimeOfSession.Title : "Unknown Config") + " " + Time.ToShortDateString() + " " + Time.ToShortTimeString();
      }

      public override string GetCollectionName()
      {
         return "sessions";
      }
   }
}
