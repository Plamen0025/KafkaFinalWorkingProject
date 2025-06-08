using KafkaFinalWorkingProject.Models;
using KafkaFinalWorkingProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KafkaFinalWorkingProject.Controllers
{
    [ApiController]
    [Route("kafka")]
    public class KafkaController : ControllerBase
    {
        private readonly KafkaProducer _producer;
        private readonly KafkaConsumer _consumer;

        public KafkaController(KafkaProducer producer, KafkaConsumer consumer)
        {
            _producer = producer;
            _consumer = consumer;
        }

        [HttpPost("publish")]
        public async Task<IActionResult> Publish([FromBody] Movie movie)
        {
            await Task.Run(() => _producer.Publish(movie)); // симулира async
            return Ok("Published to Kafka (in-memory)");
        }

        [HttpPost("consume")]
        public async Task<IActionResult> Consume()
        {
            await Task.Run(() => _consumer.Consume());
            return Ok("Consumed all messages from Kafka (in-memory)");
        }

        [HttpGet("cache")]
        public IActionResult GetCachedMovies()
        {
            var cached = _consumer.GetCachedMovies();
            return Ok(cached);
        }
    }
}