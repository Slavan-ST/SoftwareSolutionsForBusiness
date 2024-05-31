using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet("{message}")]
        public HttpStatusCode Get(string message)
        {
            Console.WriteLine(message);
            Debug.WriteLine(message);
            return HttpStatusCode.OK;
        }
    }
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
            new()
            {
                PersonCode = 917984,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 3,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:16"
            },

            new()
            {
                PersonCode = 271778,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:19"
            },

            new()
            {
                PersonCode = 456937,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:44"
            },

            new()
            {
                PersonCode = 616174,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 19,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:03"
            },

            new()
            {
                PersonCode = 552417,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:18"
            },

            new()
            {
                PersonCode = 889414,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 6,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:21"
            },

            new()
            {
                PersonCode = 934220,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 16,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:26"
            },

            new()
            {
                PersonCode = 644481,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 18,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:59"
            },

            new()
            {
                PersonCode = 222257,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 20,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:26"
            },

            new()
            {
                PersonCode = 535513,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 4,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:59"
            },

            new()
            {
                PersonCode = 431628,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:46"
            },

            new()
            {
                PersonCode = 731342,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:06"
            },

            new()
            {
                PersonCode = 835398,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 4,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:50"
            },

            new()
            {
                PersonCode = 953050,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 18,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:29"
            },

            new()
            {
                PersonCode = 475367,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 2,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:43"
            },

            new()
            {
                PersonCode = 975989,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:51"
            },

            new()
            {
                PersonCode = 712353,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 15,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:11"
            },

            new()
            {
                PersonCode = 915522,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:44"
            },

            new()
            {
                PersonCode = 708507,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 2,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:58"
            },

            new()
            {
                PersonCode = 102086,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 6,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:42"
            },

            new()
            {
                PersonCode = 795983,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 18,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:29"
            },

            new()
            {
                PersonCode = 616566,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 22,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:01"
            },

            new()
            {
                PersonCode = 998014,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 16,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:03"
            },

            new()
            {
                PersonCode = 574670,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:54"
            },

            new()
            {
                PersonCode = 283569,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 11,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:07"
            },

            new()
            {
                PersonCode = 984251,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 16,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:14"
            },

            new()
            {
                PersonCode = 230069,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 9,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:52"
            },

            new()
            {
                PersonCode = 838801,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 15,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:29"
            },

            new()
            {
                PersonCode = 409117,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 4,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:07"
            },

            new()
            {
                PersonCode = 563202,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 19,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:52"
            },

            new()
            {
                PersonCode = 589545,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 14,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:52"
            },

            new()
            {
                PersonCode = 756981,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:11"
            },

            new()
            {
                PersonCode = 483710,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 3,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:01"
            },

            new()
            {
                PersonCode = 142584,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 0,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:44"
            },

            new()
            {
                PersonCode = 232024,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 7,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:48"
            },

            new()
            {
                PersonCode = 473842,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 2,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:59"
            },

            new()
            {
                PersonCode = 633045,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:03"
            },

            new()
            {
                PersonCode = 602242,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 21,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:17"
            },

            new()
            {
                PersonCode = 122674,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 5,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:56"
            },

            new()
            {
                PersonCode = 475170,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 3,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:25"
            },

            new()
            {
                PersonCode = 900151,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 16,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:29:23"
            },

            new()
            {
                PersonCode = 130838,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 2,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:50"
            },

            new()
            {
                PersonCode = 516831,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 15,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:17"
            },

            new()
            {
                PersonCode = 616387,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 2,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:49"
            },

            new()
            {
                PersonCode = 383432,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 18,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:47"
            },

            new()
            {
                PersonCode = 183118,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 5,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:29:16"
            },

            new()
            {
                PersonCode = 533062,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 22,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:50"
            },

            new()
            {
                PersonCode = 951010,
                PersonRole ="Сотрудник",
                LastSecurityPointNumber = 1,
                LastSecurityPointDirection= "out",
                LastSecurityPointTime = "2024-03-17 00:28:59"
            },

            new()
            {
                PersonCode = 133475,
                PersonRole ="Клиент",
                LastSecurityPointNumber = 8,
                LastSecurityPointDirection= "in",
                LastSecurityPointTime = "2024-03-17 00:28:57"
            },
        };
    }
}
