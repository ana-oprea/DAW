using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Data.Entities.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public Detail Detail { get; set; }
        public List<MovieActor> MovieActors { get; set; }

        public MovieDTO(Movie movie)
        {
            this.Id = movie.Id;
            this.Name = movie.Name;
            this.Genre = movie.Genre;
            this.Detail = movie.Detail;
            this.MovieActors = new List<MovieActor>();
        }
    }
}
