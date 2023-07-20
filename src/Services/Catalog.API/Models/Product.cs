﻿using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.API.Models
{
    public class Product
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string summary { get; set; }
        public string ImageFile { get; set; }
        public double Price { get; set; }
    }
}