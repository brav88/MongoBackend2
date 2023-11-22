using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoBackend2.Models;
using System.Text.Json.Nodes;

namespace MongoBackend2.Database
{
	public static class DatabaseHelper
	{
		public static List<Movie> getMovies()
		{
			//MongoClient mongoClient = new MongoClient("mongodb+srv://root:Admin$1234@cluster0.emo1wm3.mongodb.net/test");

			MongoClient mongoClient = new MongoClient("mongodb://localhost:27017/");

			IMongoDatabase db = mongoClient.GetDatabase("AngularMediaBD");

			var movies = db.GetCollection<BsonDocument>("movies");

			List<BsonDocument> movieArray = movies.Find(new BsonDocument()).ToList();

			List<Movie> movieList = new List<Movie>();

			foreach (BsonDocument bsonMovie in movieArray)
			{
				Movie movie = BsonSerializer.Deserialize<Movie>(bsonMovie);
				movieList.Add(movie);
			}

			return movieList;
		}
	}
}
