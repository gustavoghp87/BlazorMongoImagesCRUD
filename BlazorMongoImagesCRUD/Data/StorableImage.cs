using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorMongoImagesCRUD.Data
{
    public class StorableImage
    {
        [BsonId]
        public ObjectId Id { get; set; }
        
        public byte[] Content { get; set; }

        [BsonElement("filename")]
        public string Name { get; set; }

        [BsonElement("length")]
        public int Length { get; set; }

        [BsonElement("chunkSize")]
        public int ChunkSize { get; set; }

        [BsonElement("uploadDate")]
        public DateTime UploadDate { get; set; }

        [BsonElement("md5")]
        public string Md5 { get; set; }

        public string Url { get; set; }
    }
}
