using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int DetailId { get; set; }
        public Genre Genre { get; set; }
        public Detail Detail { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
