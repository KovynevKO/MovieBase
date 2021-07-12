using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class EmployeeLabel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<EmployeeEvaluation> EmployeeEvaluations { get; set; } = new List<EmployeeEvaluation>();
    }
}
