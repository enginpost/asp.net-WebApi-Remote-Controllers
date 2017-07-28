
// Add the following references
using System.Web.Http;
//Add any references to sibling projects that you have to directly instantiate (non in this example)
//Add local project references
using API.Views;
using API.Models;

namespace API.Controllers
{
    //Set the root route for this class
    [RoutePrefix("api/sample")]
    public class SampleController : ApiController
    {
        //Add HTTP Verb and custom route
        [HttpGet]
        [Route("members/{MemberID}")]
        public IHttpActionResult MemberDetails(string MemberID)
        {
            SampleModel MemberModel = new SampleModel();
            SampleView MemberView = new SampleView();

            return Ok( MemberView.Member(MemberModel.GetMember( MemberID ) ) );
        }
    }
}
