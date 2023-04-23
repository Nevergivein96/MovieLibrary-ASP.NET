using Movie_Library_Web.Models;

namespace Movie_Library_Web
{
    public interface IMovieRepository
    {
        public IEnumerable<Movie> GetAllMovies();
    }
}
