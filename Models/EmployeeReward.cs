using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class EmployeeReward
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Reward Reward { get; set; }
        public int RewardId { get; set; }

        public int Year { get; set; }
    }
}
