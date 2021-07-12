using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class GroupingMark
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SmallImagePath { get; set; }
        public string LargeImagePath { get; set; }
        public List<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}
