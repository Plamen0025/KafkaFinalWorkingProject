using KafkaFinalWorkingProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace KafkaFinalWorkingProject.Controllers
{
    [ApiController]
    [Route("api/external/movies")]
    public class FakeMovieApiController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetFakeMovies()
        {
            var movies = await Task.FromResult(new List<Movie>
    {
        new Movie { Id = "1", Title = "Fake Movie 1", Genre = "Drama", Year = 2021 },
        new Movie { Id = "2", Title = "Fake Movie 2", Genre = "Action", Year = 2020 }
    });

            return Ok(movies);
        }
    }
}