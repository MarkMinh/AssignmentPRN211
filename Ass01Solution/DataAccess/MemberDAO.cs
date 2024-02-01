using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        public MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock) 
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }

                    return instance;
                }
            }
        }
        private static List<MemberObject> memberList = new List<MemberObject>()
        {
            new MemberObject{MemberID = 1, MemberName = "MinhTQ", Password = "123456", Email = "minhtq@gmail.com", City = "BAC NINH", Country = "VIET NAM"},
            new MemberObject{MemberID = 2, MemberName = "KhuongND", Password = "123@hihi", Email = "tolee@gmail.com", City = "HA NOI", Country = "VIET NAM"},
            new MemberObject{MemberID = 3, MemberName = "HieuLV", Password = "1234567", Email = "hieulv@gmail.com", City = "PUCHUA", Country = "CAMPUCHUA"},
            new MemberObject{MemberID = 4, MemberName = "HoangNH", Password = "1234567", Email = "hoangnh@gmail.com", City = "LAO", Country = "LAO"},
            new MemberObject{MemberID = 5, MemberName = "hehe", Password = "123456", Email = "hehe@gmail.com", City = "LAO", Country = "LAO"}
        };

        public List<MemberObject> GetMemberList => memberList;

        

        public MemberObject GetMemberById(int MemberId)
        {
            MemberObject member = GetMemberList.SingleOrDefault(member => member.MemberID == MemberId);
            return member;
        }

        

        public void AddNewMember(MemberObject NewMember)
        {
            MemberObject checkDuplicated = GetMemberById(NewMember.MemberID);
            if (checkDuplicated != null)
            {
                throw new Exception("Member is already existed");
            }
            else
            {
                GetMemberList.Add(NewMember);
            }
        }

        public List<MemberObject> ListFilterByCountry(string country)
        {
            List<MemberObject> filteredList =
                GetMemberList.FindAll(member => member.Country == country);
            return filteredList;
        }

        public List<MemberObject> ListFilterByCity(string country, string city)
        {
            List<MemberObject> filteredList =
                GetMemberList.FindAll(member => member.City == city && member.Country == country);
            return filteredList;
        }

        public List<MemberObject> SortMemberListDescendingByName()
        {
            var sortedList = from member in GetMemberList orderby member.MemberName select member;
            return sortedList.ToList();
        }

        public void DeleteMemberById(int MemberId)
        {
            var member = GetMemberById(MemberId);
            if (member == null)
            {
                throw new Exception("Member does not exist");
            }
            else
            {
                GetMemberList.Remove(member);
            }
        }

        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        {
            MemberObject member =
                GetMemberList.SingleOrDefault(member => member.Email == email && member.Password == password);
            return member;
        }



        public void UpdateMemberInfo(MemberObject UpdateMember)
        {
            var member = GetMemberById(UpdateMember.MemberID);
            if (member == null)
            {
                throw new Exception("Member does not exist!!");
            }

            
            member.MemberName = UpdateMember.MemberName ??= member.MemberName;
            member.Email = UpdateMember.Email ??= member.Email;
            member.Password = UpdateMember.Password ??= member.Password;
            member.City = UpdateMember.City ??= member.City;
            member.Country = UpdateMember.Country ??= member.Country;
        }

        public List<MemberObject> SearchMemberByName(string name)
        {
            var list = new List<MemberObject>();
            foreach (var member in GetMemberList)
            {
                if(member.MemberName.Contains(name))
                    list.Add(member);
            }
            return list;
        }

        public List<string> GetCity(string country)
        {
            
            var cities = memberList.Where(member => member.Country.Equals(country, StringComparison.OrdinalIgnoreCase))
                                   .Select(member => member.City)
                                   .Distinct()
                                   .ToList();

            return cities;
        }

        public List<string> GetDistinctCountriesOfMembers()
        {
         
            List<string> distinctCountries = GetMemberList.Select(member => member.Country).Distinct().ToList();
            
            return distinctCountries;
        }
    }
}


