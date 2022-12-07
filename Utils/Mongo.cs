using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;
using System.Windows.Forms;
using MongoDB.Driver.Core.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Tour.Utils
{
    public class Mongo
    {
        private static Mongo instance;

        public static Mongo Instance
        {
            get { if (instance == null) instance = new Mongo(); return Mongo.instance; }
            private set { Mongo.instance = value; }
        }
        private Mongo()
        {
        }


        static string connectionString = @"mongodb+srv://unknow0:unknow0@cluster0.mhdru87.mongodb.net/?retryWrites=true&w=majority";
        static string databasename = "_db";
        static string collectionname = "_collection";
        static MongoClient client = new MongoClient(connectionString);
        static IMongoDatabase db = client.GetDatabase(databasename);
        IMongoCollection<Info> collection = db.GetCollection<Info>(collectionname);


        Info t = new Info { IP = ComputerInfo.Instance.ComIP, ComName = ComputerInfo.Instance.ComName, Port = ComputerInfo.Instance.ComPort };

        public async void DoSomeStuff()
        {
            try
            {
                await collection.InsertOneAsync(t);

            }
            catch
            {

            }
        }
    }
}
