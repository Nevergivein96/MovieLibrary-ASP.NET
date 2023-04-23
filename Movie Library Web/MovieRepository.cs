using Dapper;
using Movie_Library_Web.Models;
using System.Data;

namespace Movie_Library_Web
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IDbConnection _conn;
        public MovieRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Movie> GetAllMovies()
        {
            return _conn.Query<Movie>("SELECT * FROM PRODUCTS;");
        }
    }
}
