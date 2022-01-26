using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectASP.Data.Entities;
using ProiectASP.Data.Entities.DTOs;
using ProiectASP.Repositories.ActorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorRepository _repository;
        public ActorController(IActorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllActors() 
        {
            var actors = await _repository.GetActors();
            var actorsToReturn = new List<ActorDTO>();
            foreach (var actor in actors)
            {
                actorsToReturn.Add(new ActorDTO(actor));
            }
            return Ok(actorsToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActor(CreateActorDTO dto) {
            Actor newActor = new Actor();
            newActor.Name = dto.Name;

            _repository.Create(newActor);
            await _repository.SaveAsync();

            return Ok(new ActorDTO(newActor));
        }
    }
}
