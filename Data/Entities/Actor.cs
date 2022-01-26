using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Data.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
