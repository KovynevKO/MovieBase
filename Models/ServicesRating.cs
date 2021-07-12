using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class ServicesRating
    {
        public int Id { get; set; }
        public float Imdb { get; set; }
        public float Kinopoisk { get; set; }
        public float RottenTomatoes { get; set; }
        public float Metacritic { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
