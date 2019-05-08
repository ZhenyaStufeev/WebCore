using Business_Logic_Layer.Entity;
using Business_Logic_Layer.ServiceCreator;
using Business_Logic_Layer.ServiceDir;
using Microsoft.AspNetCore.Mvc;

namespace WebCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtensionController : ControllerBase
    {
        private IService Context { get; set; }
        public ExtensionController()
        {
            var creator = new ServiceCreator();
            Context = creator.Create();
        }

        [HttpPost("[action]")]
        public ExtensionResponce ExequteExtension(ExtensionRequest request)
        {

            return null;
        }

        [HttpPost("[action]")]
        public ExtensionInfo GetExtensionInfo(string ExtensionName)
        {
            return null;
        }
    }
}
