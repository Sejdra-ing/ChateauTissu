
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace ChateauTissu.Models
{
    [DataContract]
    public class Article
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; }

        [BsonElement("Ref")]
        public string Ref { get; set; }

        [BsonElement("ArrivalDate")]
        public string ArrivalDate { get; set; }

        [BsonElement("Unite")]
        public string Unite { get; set; }

        [BsonElement("Quantity")]
        public string Quantity { get; set; }
    }
}


