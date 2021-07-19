using MovieBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.ViewModels
{
    public class FullMovieInfo
    {
        public Movie Movie { get; set; }
        public ServicesRating ServicesRating { get; set; }
        public List<Country> Countries { get; set; }
        public List<Image> MovieImages { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Reward> Rewards { get; set; }
        public Evaluation Evaluation { get; set; }
    } 
}
