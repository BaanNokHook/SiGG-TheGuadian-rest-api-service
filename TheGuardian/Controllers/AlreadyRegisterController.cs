using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics.Contracts;

namespace AlreadyRegisterController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlreadyRegisterControllerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "userId", "deviceId", "publicKey", "status"
    };

        private readonly ILogger<AlreadyRegisterControllerController> _logger;

        public AlreadyRegisterControllerController(ILogger<AlreadyRegisterControllerController> logger)
        {
            _logger = logger;
        }

      

        [HttpGet(Name = "GetAlreadyRegisterController")]
        public IEnumerable<AlreadyRegisterController> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new AlreadyRegisterController
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

}

