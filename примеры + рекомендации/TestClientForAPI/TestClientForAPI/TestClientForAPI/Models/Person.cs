using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClientForAPI.Models
{
    public class Person
    {

        // РЕГИСТР СОБЛЮДАТЬ!!

        public int personCode { get; set; }
        public string personRole { get; set; } = null!;
        public int lastSecurityPointNumber { get; set; }
        public string lastSecurityPointDirection { get; set; } = null!;
        public string lastSecurityPointTime { get; set; } = null!;

    }
}
