using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public float UserRating { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public Movie Movie { get; set; }
        public int MovieId { get; set; }

        public GroupingMark GroupingMark { get; set; }
        public int GroupingMarkId { get; set; }
        public List<EmployeeEvaluation> EmployeeEvaluations { get; set; } = new List<EmployeeEvaluation>();
    }
}
