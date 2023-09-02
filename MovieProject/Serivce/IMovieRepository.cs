using MovieProject.Models;

namespace MovieProject.Serivce
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
        Task<IEnumerable<Movie>>GetThreeMovie();
        Task<Movie> GetMovieById(int id);   
        bool Add(Movie movie);
        bool Delete(Movie movie);
        bool Update(Movie movie);
        bool Save();

    }
}
