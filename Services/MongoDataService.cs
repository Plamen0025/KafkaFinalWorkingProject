using MongoDB.Driver;
using KafkaFinalWorkingProject.Models;

namespace KafkaFinalWorkingProject.Services
{
    public class MongoDataService
    {
        private readonly IMongoCollection<Movie> _movies;

        public MongoDataService(IConfiguration config)
        {
            var client = new MongoClient(config["MongoDB:ConnectionString"]);
            var database = client.GetDatabase(config["MongoDB:DatabaseName"]);
            _movies = database.GetCollection<Movie>(config["MongoDB:CollectionName"]);
        }

        public async Task<List<Movie>> GetAllAsync() =>
            await _movies.Find(_ => true).ToListAsync();

        public async Task<Movie> GetByIdAsync(string id) =>
            await _movies.Find(m => m.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Movie movie) =>
            await _movies.InsertOneAsync(movie);
    }
}