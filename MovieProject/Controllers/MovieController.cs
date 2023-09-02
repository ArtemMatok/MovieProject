using Microsoft.AspNetCore.Mvc;
using MovieProject.Serivce;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
        private IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _movieRepository.GetAllMovies();
            return View(movies);
        }
    }
}
