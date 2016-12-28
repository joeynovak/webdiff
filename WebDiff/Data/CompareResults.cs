using MongoDB.Bson;

namespace WebDiff.Data
{
   public class CompareResults : MongoDocument
   {   
      public BsonObjectId OriginalSessionId;
      public BsonObjectId NewSessionId;
      public UrlResults[] UrlResults;

      public CompareResults(Session originalSession, Session newSession)
      {
         OriginalSessionId = originalSession._id;
         NewSessionId = newSession._id;
      }

      public override string GetCollectionName()
      {
         return "compare-results";
      }
   }
}