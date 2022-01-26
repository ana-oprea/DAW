﻿using ProiectASP.Data.Entities;
using ProiectASP.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Repositories.ActorRepository
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        Task<Actor> GetByName(string name);
        Task<List<Actor>> GetActors();
    }
}
