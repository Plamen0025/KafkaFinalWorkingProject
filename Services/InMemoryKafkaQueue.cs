using KafkaFinalWorkingProject.Models;
using System.Collections.Generic;

namespace KafkaFinalWorkingProject.Services
{
    public static class InMemoryKafkaQueue
    {
        // Това ще бъде нашата Kafka-опашка – паметно базирана
        public static Queue<Movie> Queue { get; } = new Queue<Movie>();
    }
}