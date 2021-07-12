using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public List<Dialogue> Dialogues { get; set; } = new List<Dialogue>();
        public List<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}
