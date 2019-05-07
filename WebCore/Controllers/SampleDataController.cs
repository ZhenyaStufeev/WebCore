using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleDataController : ControllerBase
    {
        [HttpPost("[action]")]
        public string SendData()
        {
            return "Hello Zhenya";
        }

        [HttpPost("GetData")]
        public string GetData()
        {
            return "Hello Zhenya";
        }
    }
}
