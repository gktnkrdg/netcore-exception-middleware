using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExceptionHandling.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DivideController : ControllerBase
    {
        private readonly ILogger<DivideController> _logger;
        public DivideController(ILogger<DivideController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{number}")]
        public int Get(int number)
        {
            _logger.LogInformation("Divide Method Call");
            int result = 12 / number;
            return result;
        }
    }
}
