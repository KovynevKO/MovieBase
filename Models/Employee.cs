using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Image> Images { get; set; } = new List<Image>();
        public List<EmployeeEvaluation> EmployeeEvaluations { get; set; } = new List<EmployeeEvaluation>();
        public List<EmployeeReward> EmployeeRewards { get; set; } = new List<EmployeeReward>();
    }
}
