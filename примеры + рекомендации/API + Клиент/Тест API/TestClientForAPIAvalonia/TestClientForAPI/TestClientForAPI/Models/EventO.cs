using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models.Main
{
    public class EventO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? Location { get; set; } = string.Empty;
        public string? Organizer { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public string ShortDateTime { get => Date.ToShortDateString() + " " + Date.ToShortTimeString(); }
    }
}
