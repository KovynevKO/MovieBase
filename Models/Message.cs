using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBase.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Dialogue Dialogue { get; set; }
        public int DialogueId { get; set; }

        public int SenderId { get; set; }
    }
}
