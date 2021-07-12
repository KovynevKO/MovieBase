using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public ServicesRating ServicesRating { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<Image> Images { get; set; } = new List<Image>();
        public List<MovieReward> MovieRewards { get; set; } = new List<MovieReward>();
    }
}
