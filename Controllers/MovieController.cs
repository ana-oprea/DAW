using Microsoft.AspNetCore.Mvc;
using ProiectASP.Data.Entities;
using ProiectASP.Data.Entities.DTOs;
using ProiectASP.Repositories.MovieRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _repository;
        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _repository.GetMovies();
            var moviesToReturn = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                moviesToReturn.Add(new MovieDTO(movie));
            }
            return Ok(moviesToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieDTO dto)
        {
            Movie newMovie = new Movie();
            newMovie.Name = dto.Name;
            newMovie.Genre = dto.Genre;
            newMovie.Detail = dto.Detail;
            newMovie.MovieActors = new List<MovieActor>();

            _repository.Create(newMovie);
            await _repository.SaveAsync();

            return Ok(new MovieDTO(newMovie));
        }
    }
}
