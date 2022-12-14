using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mover.Application;
using Mover.Domain;

namespace Mover.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service= service;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var response = _service.GetAllMovies();
            return Ok(response);
        }


        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var Movie = _service.CreateMovie(movie);   
            return Ok(Movie);
        }
    }
}
