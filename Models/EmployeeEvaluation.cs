using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class EmployeeEvaluation
    {
        public int Id { get; set; }

        public EmployeeLabel EmployeeLabel { get; set; }
        public int EmployeeLabelId { get; set; }

        public Evaluation Evaluation { get; set; }
        public int EvaluationId { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}
