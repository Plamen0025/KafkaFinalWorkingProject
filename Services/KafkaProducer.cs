using KafkaFinalWorkingProject.Models;

namespace KafkaFinalWorkingProject.Services
{
    public class KafkaProducer
    {
        public void Publish(Movie movie)
        {
            // Публикуване във фалшивата Kafka опашка
            InMemoryKafkaQueue.Queue.Enqueue(movie);
            Console.WriteLine($"[KafkaProducer] Published: {movie.Title}");
        }
    }
}