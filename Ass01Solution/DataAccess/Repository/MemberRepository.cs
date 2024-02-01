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
        public void AddNewMember(MemberObject NewMember) => MemberDAO.Instance.AddNewMember(NewMember);


        public void DeleteMember(int MemberID) => MemberDAO.Instance.DeleteMemberById(MemberID);

        public List<MemberObject> FilterListByCity(string country, string city)
            => MemberDAO.Instance.ListFilterByCity(country, city);
        

        public List<MemberObject> FilterListByCountry(string country)
            => MemberDAO.Instance.ListFilterByCountry(country);


        public List<MemberObject> GetAllMembers() => MemberDAO.Instance.GetMemberList;

        public List<string> GetCity(string country) => MemberDAO.Instance.GetCity(country);
        

        public List<string> GetDistinctCountriesOfMembers() => MemberDAO.Instance.GetDistinctCountriesOfMembers();

        public MemberObject GetMemberByEmailAndPassword(string email, string pass)
            => MemberDAO.Instance.GetMemberByEmailAndPassword(email, pass);
        

        public MemberObject GetMemberByID(int MemberId) => MemberDAO.Instance.GetMemberById(MemberId);

        public List<MemberObject> SearchMembersByName(string name) => MemberDAO.Instance.SearchMemberByName(name);
        

        public List<MemberObject> SortMemberListDescendingName()
        => MemberDAO.Instance.SortMemberListDescendingByName();

        public void UpdateMember(MemberObject UpdateMember)
        => MemberDAO.Instance.UpdateMemberInfo(UpdateMember);
    }
}
