using ProiectASP.Data;
using ProiectASP.Data.Entities;
using ProiectASP.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Repositories.ActorRepository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(ProiectContext context) : base(context) { }
        public async Task<List<Actor>> GetActors()
        {
            return await _context.Actors.ToListAsync();
        }
        public async Task<Actor> GetByName(string name)
        {
            return await _context.Actors.Where(a => a.Name.Equals(name)).FirstOrDefaultAsync();
        }
    }
}
