using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics.Contracts;

namespace FindUser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FindUserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "userId", "publicKey"
    };

        private readonly ILogger<FindUserController> _logger;

        public FindUserController(ILogger<FindUserController> logger)
        {
            _logger = logger;
        }

        [HttpPut(Name = "PutFindUser")]
        public IEnumerable<FindUser> Put()
        {
            return Enumerable.Range(1, 5).Select(index => new FindUser
            {
                userId = "1111",
                publicKey = "*d*sad7597984%%4343eq#"
            })
            .ToArray();
        }

    }
}

