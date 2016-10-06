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
    public class Session
    {
        [BsonIgnoreIfNull]
        public BsonObjectId _id;
        public Url[] Urls;        

        public DateTime Time;

        public override string ToString()
        {
            return Time.ToString();
        }
    }
}
