using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics.Contracts;

namespace Register.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "userId", "deviceId", "publicKey"
    };

        private readonly ILogger<RegisterController> _logger;

        public RegisterController(ILogger<RegisterController> logger)
        {
            _logger = logger;
        }


        [HttpPost(Name = "PostRegister")]
        public IEnumerable<Register> Post()
        {
            return Enumerable.Range(1, 5).Select(index => new Register
            {
                userId = "1111",
                deviceId = "d2Rhc2RzYXNkc2Fkc2Fk",
                publicKey = "*d*sad7597984%%4343eq#"
            })
            .ToArray();
        }

    }
}



