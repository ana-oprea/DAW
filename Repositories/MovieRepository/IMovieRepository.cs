using ProiectASP.Data.Entities;
using ProiectASP.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Repositories.MovieRepository
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        Task<Movie> GetByMovieName(string name);
        Task<List<Movie>> GetMovies();
    }
}
