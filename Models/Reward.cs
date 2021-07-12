using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class Reward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<MovieReward> MovieRewards { get; set; } = new List<MovieReward>();
        public List<EmployeeReward> EmployeeRewards { get; set; } = new List<EmployeeReward>();
    }
}
