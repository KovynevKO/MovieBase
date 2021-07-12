using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class Country
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string SmallImagePath { get; set; }
        public string LargeImagePath { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
