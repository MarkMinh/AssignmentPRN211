using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberDAO memberDAO = MemberDAO.Instance;
        public void DeleteMember(int MemberId) => memberDAO.Remove(MemberId);


        public MemberObject GetMemberByEmailAndPassword(string Email, string Password)
            => memberDAO.GetMemberByEmailAndPassword(Email, Password);


        public MemberObject GetMemberByID(int MemberId) => memberDAO.GetMemberByID(MemberId);


        public IEnumerable<MemberObject> GetMembers() => memberDAO.GetMemberList();


        public void InsertMember(MemberObject Member) => memberDAO.insertMember(Member);


        public void UpdateMember(MemberObject Member) => memberDAO.Update(Member);

    }
}
