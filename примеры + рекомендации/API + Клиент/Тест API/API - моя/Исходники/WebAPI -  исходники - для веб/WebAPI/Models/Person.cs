using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Person
    {

        public int PersonCode { get; set; }
        public string PersonRole { get; set; } = null!;
        public int LastSecurityPointNumber { get; set; }
        public string LastSecurityPointDirection { get; set; } = null!;
        public string LastSecurityPointTime { get; set; } = null!;

    }
}
