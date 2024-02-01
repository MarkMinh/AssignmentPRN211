using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        List<MemberObject> GetAllMembers();

        void AddNewMember(MemberObject NewMember);

        void UpdateMember(MemberObject UpdateMember);

        void DeleteMember(int MemberId);

        
        MemberObject GetMemberByEmailAndPassword(string email, string pass);
        MemberObject GetMemberByID(int MemberId);  

        List<MemberObject> FilterListByCity(string country, string city);
        List<MemberObject> FilterListByCountry(string country);

        List<MemberObject> SortMemberListDescendingName();

        List<MemberObject> SearchMembersByName(string name);

        List<string> GetDistinctCountriesOfMembers();

        List<string> GetCity(string country);
    }
}
