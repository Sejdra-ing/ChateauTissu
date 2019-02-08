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
        [DataMember]
        public string Name { get; set; }

        [BsonElement("Price")]
        [DataMember]
        public decimal Price { get; set; }

        [BsonElement("Category")]
        [DataMember]
        public string Category { get; set; }

        [BsonElement("Ref")]
        [DataMember]
        public string Ref { get; set; }

        [BsonElement("ArrivalDate")]
        [DataMember]
        public string ArrivalDate { get; set; }

        [BsonElement("Unite")]
        [DataMember]
        public string Unite { get; set; }

        [BsonElement("Quantity")]
        [DataMember]
        public string Quantity { get; set; }
    }
}