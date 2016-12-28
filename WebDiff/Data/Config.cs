using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebDiff.Data
{
   [BsonIgnoreExtraElements]
   public class Config : MongoDocument
   {            
      public String Title;
      public string[] StartUrls;
      public string[] CapturePagesLinkedInTheseDomains;
      public String[] AllowedDomains;
      
      public override string ToString()
      {
         return Title;
      }

      public override string GetCollectionName()
      {
         return "configs";
      }
   }
}
