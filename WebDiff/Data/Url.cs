using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;


namespace WebDiff.Data
{
    [BsonIgnoreExtraElements]
    public class Url
    {
        public String Uri;
        public String PicturePath;
        public int MsToLoad;
        public String HtmlSourcePath;

        [BsonIgnore]
        public String FileNameBase
        {
            get
            {
                String fileNameBase = Uri;

                foreach (var character in System.IO.Path.GetInvalidFileNameChars())
                {
                    fileNameBase = fileNameBase.Replace(character, '_');
                }

                return fileNameBase;
            }
        }        

        public override string ToString()
        {
            return Uri;
        }
    }
}
