// Add the following references
using System.Web.Http;
//Add any references to sibling projects that you have to directly instantiate
//Add local project references (non in this example)
using API.Utilities;

namespace API.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult DefaultAction()
        {
            return Ok(new StatusResponse() { Status = StatusResponse.STATUS.FOUND, MessageType = MESSAGE_TYPE.RESULT, Message = "Welcome to our Web API" } );
        }
    }
}
