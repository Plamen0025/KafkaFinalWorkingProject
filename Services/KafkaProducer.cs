using KafkaFinalWorkingProject.Models;

namespace KafkaFinalWorkingProject.Services
{
    public class KafkaProducer
    {
        public void Publish(Movie movie)
        {
            // ����������� ��� ��������� Kafka ������
            InMemoryKafkaQueue.Queue.Enqueue(movie);
            Console.WriteLine($"[KafkaProducer] Published: {movie.Title}");
        }
    }
}