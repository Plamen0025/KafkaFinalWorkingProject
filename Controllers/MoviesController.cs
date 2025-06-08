using KafkaFinalWorkingProject.Models;
using KafkaFinalWorkingProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KafkaFinalWorkingProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly InMemoryMovieService _movieService;

        public MoviesController(InMemoryMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET /movies
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = await _movieService.GetAllAsync();
            return Ok(movies);
        }

        // POST /movies
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Movie movie)
        {
            if (string.IsNullOrWhiteSpace(movie.Title))
                return BadRequest("Title is required.");

            await _movieService.AddAsync(movie);

            return Ok(movie);
        }
    }
}