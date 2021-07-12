using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class MovieReward
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        
        public Reward Reward { get; set; }
        public int RewardId { get; set; }

        public int Year { get; set; }
    }
}
