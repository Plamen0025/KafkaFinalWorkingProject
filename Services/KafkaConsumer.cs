using KafkaFinalWorkingProject.Models;

namespace KafkaFinalWorkingProject.Services
{
    public class KafkaConsumer
    {
        private readonly List<Movie> _cache = new List<Movie>();

        public void Consume()
        {
            while (InMemoryKafkaQueue.Queue.Any())
            {
                var movie = InMemoryKafkaQueue.Queue.Dequeue();
                _cache.Add(movie);
                Console.WriteLine($"[KafkaConsumer] Consumed and cached: {movie.Title}");
            }
        }

        public List<Movie> GetCachedMovies()
        {
            return _cache;
        }
    }
}