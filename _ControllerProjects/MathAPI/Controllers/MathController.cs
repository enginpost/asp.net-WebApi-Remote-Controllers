// Add the following references
using System.Web.Http;
//Add any references to sibling projects that you have to directly instantiate
using API.Utilities;

namespace API.Controllers
{
    //Set the root route for this class
    [RoutePrefix("api/math")]
    public class MathController : ApiController
    {
        //Add HTTP Verb and custom route
        [HttpGet]
        [Route("{first}/{second}/add")]
        public IHttpActionResult Add(decimal first, decimal second)
        {
            decimal val = first + second;
            return Ok(new StatusResponse() { Status = StatusResponse.STATUS.FOUND, MessageType = MESSAGE_TYPE.RESULT,  Message = val.ToString() });
        }

        [HttpGet]
        [Route("{first}/{second}/subtract")]
        public IHttpActionResult Subtract(decimal first, decimal second)
        {
            decimal val = first - second;
            return Ok(new StatusResponse() { Status = StatusResponse.STATUS.FOUND, MessageType = MESSAGE_TYPE.RESULT, Message = val.ToString() });
        }

        [HttpGet]
        [Route("{first}/{second}/multiply")]
        public IHttpActionResult multiply(decimal first, decimal second)
        {
            decimal val = first * second;
            return Ok(new StatusResponse() { Status = StatusResponse.STATUS.FOUND, MessageType = MESSAGE_TYPE.RESULT, Message = val.ToString() });
        }

        [HttpGet]
        [Route("{first}/{second}/divide")]
        public IHttpActionResult Divide(decimal first, decimal second)
        {
            if( second != 0)
            {
                decimal val = first / second;
                return Ok(new StatusResponse() { Status = StatusResponse.STATUS.FOUND, MessageType = MESSAGE_TYPE.RESULT, Message = val.ToString() });
            }
            else
            {
                return Ok(new StatusResponse() { Status = StatusResponse.STATUS.BAD_REQUEST, MessageType = MESSAGE_TYPE.ERROR, Message = "Divide by zero" });
            }
        }
    }
}
