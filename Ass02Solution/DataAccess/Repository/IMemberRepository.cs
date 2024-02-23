using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int MemberId);
        void InsertMember(MemberObject Member);
        void DeleteMember(int MemberId);
        void UpdateMember(MemberObject Member);

        MemberObject GetMemberByEmailAndPassword(string Email, string Password);
    }
}
