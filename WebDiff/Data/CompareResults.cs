using System;
using MongoDB.Bson;
using WebDiff.Data;

public class CompareResults
{
    public BsonObjectId OriginalSessionId;
    public BsonObjectId NewSessionId;
    public UrlResults[] UrlResults;

    public CompareResults(Session originalSession, Session newSession)
    {
        OriginalSessionId = originalSession._id;
        NewSessionId = newSession._id;        
    }    
}