using Microsoft.EntityFrameworkCore;
using MovieProject.Data;
using MovieProject.Models;

namespace MovieProject.Serivce
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Movie movie)
        {
            _context.Movies.Add(movie);
            return Save();
        }

        public bool Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            return Save();
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Movie>>GetThreeMovie()
        {
            return  await _context.Movies.Take(3).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Movie movie)
        {
            _context.Movies.Update(movie);
            return Save();
        }
    }
}
