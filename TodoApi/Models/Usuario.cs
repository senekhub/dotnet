using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TodoApi.Models{
    public class Usuario{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get;set;}

        [BsonElement]
        public string Name{get;set;}
        [BsonElement]
        public bool Completed{get;set;}
    }
}