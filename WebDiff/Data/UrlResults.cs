using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDiff.Data
{
   public class UrlResults : MongoDocument
   {
      public Url OriginalUrl { get; set; }
      public Url NewUrl { get; set; }
      public string Result { get; set; }
      public string ResultPicturePath { get; set; }

      public override string GetCollectionName()
      {
         return "url-results";
      }
   }
}
