using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonLocationsController : ControllerBase
    {

        [HttpGet(Name = "PersonLocations")]
        public IEnumerable<Person> Get()
        {
            return _persons;
        }

        private static Person[] _persons = new Person[]
        {
            new Person()
            {
                PersonCode = 554427,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 20,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:03"
            },

            new Person()
            {
                PersonCode = 361510,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 19,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:10"
            },

            new Person()
            {
                PersonCode = 648699,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:28"
            },

            new Person()
            {
                PersonCode = 212993,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 14,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:25"
            },

            new Person()
            {
                PersonCode = 933282,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:39"
            },

            new Person()
            {
                PersonCode = 188659,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:02"
            },

            new Person()
            {
                PersonCode = 899469,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 0,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:38"
            },

            new Person()
            {
                PersonCode = 633030,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 12,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:09"
            },

            new Person()
            {
                PersonCode = 359698,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:10"
            },

            new Person()
            {
                PersonCode = 662792,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 22,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:19"
            },

            new Person()
            {
                PersonCode = 368642,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 15,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:06"
            },

            new Person()
            {
                PersonCode = 849795,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 20,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:34"
            },

            new Person()
            {
                PersonCode = 773212,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:14"
            },

            new Person()
            {
                PersonCode = 181189,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 22,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:43"
            },

            new Person()
            {
                PersonCode = 275510,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:29"
            },

            new Person()
            {
                PersonCode = 565896,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:31"
            },

            new Person()
            {
                PersonCode = 711859,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:08"
            },

            new Person()
            {
                PersonCode = 522204,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 17,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:25"
            },

            new Person()
            {
                PersonCode = 118212,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:19"
            },

            new Person()
            {
                PersonCode = 598043,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 17,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:39"
            },

            new Person()
            {
                PersonCode = 687135,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 3,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:02:57"
            },

            new Person()
            {
                PersonCode = 557847,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:26"
            },

            new Person()
            {
                PersonCode = 664279,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 18,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:41"
            },

            new Person()
            {
                PersonCode = 962453,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 18,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:20"
            },

            new Person()
            {
                PersonCode = 965707,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 17,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:42"
            },

            new Person()
            {
                PersonCode = 986594,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 0,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:30"
            },

            new Person()
            {
                PersonCode = 906902,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:02:54"
            },

            new Person()
            {
                PersonCode = 891969,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 20,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:36"
            },

            new Person()
            {
                PersonCode = 596913,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:09"
            },

            new Person()
            {
                PersonCode = 804054,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 3,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:32"
            },

            new Person()
            {
                PersonCode = 513007,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 17,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:04"
            },

            new Person()
            {
                PersonCode = 959022,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:17"
            },

            new Person()
            {
                PersonCode = 415188,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:36"
            },

            new Person()
            {
                PersonCode = 293244,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 0,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:02:59"
            },

            new Person()
            {
                PersonCode = 500853,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 12,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:24"
            },

            new Person()
            {
                PersonCode = 221239,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 6,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:21"
            },

            new Person()
            {
                PersonCode = 999171,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 19,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:43"
            },

            new Person()
            {
                PersonCode = 233267,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:05"
            },

            new Person()
            {
                PersonCode = 936251,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:02:53"
            },

            new Person()
            {
                PersonCode = 797088,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:27"
            },

            new Person()
            {
                PersonCode = 113757,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 2,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:20"
            },

            new Person()
            {
                PersonCode = 167696,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 0,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:02:53"
            },

            new Person()
            {
                PersonCode = 506780,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:11"
            },

            new Person()
            {
                PersonCode = 580809,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:14"
            },

            new Person()
            {
                PersonCode = 760905,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 3,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:01"
            },

            new Person()
            {
                PersonCode = 293026,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 12,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:21"
            },

            new Person()
            {
                PersonCode = 259078,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 14,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:38"
            },

            new Person()
            {
                PersonCode = 544634,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 5,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:19"
            },

            new Person()
            {
                PersonCode = 890356,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 10,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:11"
            },

            new Person()
            {
                PersonCode = 509635,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 19,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:12"
            },

            new Person()
            {
                PersonCode = 239369,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 0,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:38"
            },

            new Person()
            {
                PersonCode = 598323,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 4,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:31"
            },

            new Person()
            {
                PersonCode = 474294,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 13,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:04"
            },

            new Person()
            {
                PersonCode = 958333,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 18,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:08"
            },

            new Person()
            {
                PersonCode = 860865,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:43"
            },

            new Person()
            {
                PersonCode = 282540,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:03"
            },

            new Person()
            {
                PersonCode = 699657,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 22,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:15"
            },

            new Person()
            {
                PersonCode = 443304,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 5,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:02"
            },

            new Person()
            {
                PersonCode = 318606,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 5,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:33"
            },

            new Person()
            {
                PersonCode = 335537,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:35"
            },

            new Person()
            {
                PersonCode = 148413,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 4,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:25"
            },

            new Person()
            {
                PersonCode = 567270,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 22,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:15"
            },

            new Person()
            {
                PersonCode = 519395,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 4,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:33"
            },

            new Person()
            {
                PersonCode = 277833,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 12,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:02:57"
            },

            new Person()
            {
                PersonCode = 798174,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 2,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:02:58"
            },

            new Person()
            {
                PersonCode = 951421,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 14,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:42"
            },

            new Person()
            {
                PersonCode = 435383,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:02:58"
            },

            new Person()
            {
                PersonCode = 689399,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 13,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:13"
            },

            new Person()
            {
                PersonCode = 223472,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 14,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:14"
            },

            new Person()
            {
                PersonCode = 807294,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 13,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:30"
            },

            new Person()
            {
                PersonCode = 832945,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 21,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:25"
            },

            new Person()
            {
                PersonCode = 169661,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 13,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:02:53"
            },

            new Person()
            {
                PersonCode = 354054,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:03:30"
            },

            new Person()
            {
                PersonCode = 479648,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 10,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:05"
            },

            new Person()
            {
                PersonCode = 176774,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 15,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-19 13:02:58"
            },

            new Person()
            {
                PersonCode = 451175,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 20,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:28"
            },

            new Person()
            {
                PersonCode = 163484,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:10"
            },

            new Person()
            {
                PersonCode = 821742,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 3,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:09"
            },

            new Person()
            {
                PersonCode = 557724,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 17,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:03:31"
            },

            new Person()
            {
                PersonCode = 429233,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-19 13:02:56"
            }
        };
    }
}
