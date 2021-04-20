﻿using MongoDB.Driver;

namespace BlazorMongoImagesCRUD.Repositories
{
    public class MongoDBRepository
    {
        public MongoClient client;
        public IMongoDatabase db;

        public MongoDBRepository()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("BlazorMongoImagesCRUD");
        }
    }
}
