using MongoDB.Bson;

namespace MongoBackend2.Models
{
	public class Movie
	{
		public ObjectId? _id { get; set; }
		public string? title { get; set; }
		public string? description { get; set; }
		public DateTime dateRelease { get; set;}
		public char __v { get; set; }
	}
}
