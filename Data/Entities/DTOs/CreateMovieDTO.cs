using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Data.Entities.DTOs
{
    public class CreateMovieDTO
    {
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public Detail Detail { get; set; }
    }
}
