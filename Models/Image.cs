using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
