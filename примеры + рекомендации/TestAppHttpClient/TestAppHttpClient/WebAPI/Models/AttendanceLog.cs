using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class AttendanceLog:BaseModel
    {
        public int StudentId { get; set; }
        public int MarkerId { get; set; }
        public DateTime Date { get; set; }
    }
}
