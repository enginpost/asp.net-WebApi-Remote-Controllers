using System;
using API.DAL.Entities;

namespace API.DAL
{
    static class MemberDAL
    {
        static public MemberEntity Member( string MemberID)
        {
            //Simulating Data Access that populates an Entity
            MemberEntity thisMember = new MemberEntity();
            thisMember.FirstName = "Steve";
            thisMember.LastName = "McDonald";
            thisMember.MemberId = MemberID;
            thisMember.Birthdate = new DateTime(1973, 9, 28);

            return thisMember;
        }

    }
}
