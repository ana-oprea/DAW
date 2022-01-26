using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectASP.Data.Entities
{
    public class Detail
    {
        public int Id { get; set; }
        public string Synopsis { get; set; }
        public string NumeDirector { get; set; }
        // public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
