using API.DAL;
using API.DAL.Entities;

namespace API.Models
{
    class SampleModel
    {
        public MemberEntity  GetMember(string MemberID)
        {
            return MemberDAL.Member(MemberID);
        }
    }
}
