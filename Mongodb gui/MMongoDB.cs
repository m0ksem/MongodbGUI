using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongodb_gui
{
    public class MMongoDB
    {
        private MongoClient dbClient;
        public bool connected = false;

        public void ConnectUsingIPAndPort(string ip = "127.0.0.1", string port = "27017")
        {
            dbClient = new MongoClient("mongodb://" + ip + ":" + port);
            var database = dbClient.GetDatabase("testing");
            bool isMongoLive = database.RunCommandAsync((Command<BsonDocument>)"{ping:1}")
                    .Wait(1000);

            if (isMongoLive)
            {
                connected = true;
            }
        }

        public void ConnectUsingURL(string url)
        {
            dbClient = new MongoClient(url);
            var database = dbClient.GetDatabase("test");
            bool isMongoLive = database.RunCommandAsync((Command<BsonDocument>)"{ping:1}")
                    .Wait(1000);

            if (isMongoLive)
            {
                connected = true;
            }
        }

        public List<BsonDocument> GetDataBases()
        {
            return dbClient.ListDatabases().ToList();
        }

        public IMongoDatabase GetDataBase(string databaseName)
        {
            return dbClient.GetDatabase(databaseName);
        }

        public List<BsonDocument> GetCollectionsList(IMongoDatabase database)
        {
            return database.ListCollections().ToList();
        }

        public List<BsonDocument> GetItems(IMongoCollection<BsonDocument> collection)
        {
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}
