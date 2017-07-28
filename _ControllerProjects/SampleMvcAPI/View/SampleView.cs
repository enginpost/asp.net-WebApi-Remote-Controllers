//Add any references to sibling projects that you have to directly instantiate
using API.Utilities;
//Add local project references
using API.DAL.Entities;

namespace API.Views
{
    class SampleView
    {
        public StatusResponse Member( MemberEntity data )
        {
            return new StatusResponse()
            {
                Status = StatusResponse.STATUS.FOUND,
                MessageType = MESSAGE_TYPE.RESULT,
                Message = data
            };
        }
    }
}
