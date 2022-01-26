using Microsoft.EntityFrameworkCore;
using ProiectASP.Data;
using ProiectASP.Data.Entities;
using ProiectASP.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Repositories.MovieRepository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(ProiectContext context) : base(context) { }
        public async Task<List<Movie>> GetMovies()
        {
            return await _context.Movies.Include(a => a.Genre).Include(a => a.Detail).ToListAsync();
        }
        public async Task<Movie> GetByMovieName(string name)
        {
            return await _context.Movies.Where(a => a.Name.Equals(name)).FirstOrDefaultAsync();
        }
    }

}
