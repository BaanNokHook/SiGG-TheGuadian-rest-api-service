using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics.Contracts;

namespace NotRegisterController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotRegisterControllerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "userId", "deviceId", "publicKey", "status"
    };

        private readonly ILogger<NotRegisterControllerController> _logger;

        public NotRegisterControllerController(ILogger<NotRegisterControllerController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostNotRegisterController")]
        public IEnumerable<NotRegisterController> Post()
        {
            return Enumerable.Range(1, 5).Select(index => new NotRegisterController
            {
                userId = "1111",
                deviceId = "d2Rhc2RzYXNkc2Fkc2Fk",
                publicKey = "*d*sad7597984%%4343eq#",
                status = ""
            })
            .ToArray();
        }


        [HttpPut(Name = "PutNotRegisterController")]
        public IEnumerable<NotRegisterController> Put()
        {
            return Enumerable.Range(1, 5).Select(index => new NotRegisterController
            {
                userId = "1111",
                deviceId = "d2Rhc2RzYXNkc2Fkc2Fk",
                publicKey = "*d*sad7597984%%4343eq#",
                status = ""
            })
            .ToArray();
        }

        [HttpGet(Name = "GetNotRegisterController")]
        public IEnumerable<NotRegisterController> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new NotRegisterController
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

}

