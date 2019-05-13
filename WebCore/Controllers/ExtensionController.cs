
using Business_Logic_Layer.ServiceCreator;
using Business_Logic_Layer.ServiceDir;
using IPluginLibrary.Entity;
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
        public ActionResult ExequteExtension(ExtensionRequest request) //ExtensionResponce
        {
            
            if (request == null)
                return BadRequest(new { error = "Request is null" });

            //Передать данные исполнителю 

            Context.Exequte();


                

            return null;
        }

    }
}
