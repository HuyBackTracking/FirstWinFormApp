using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAcess
{
    public class MemberDAO : IComparable<MemberObject>
    {
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject{MemberID = 1, MemberName = "Huy", Email = "huy@fpt.edu.vn", PassWord = "123456",
            City = "Quy Nhon", Country = "Viet Nam"},
            new MemberObject{MemberID = 2, MemberName = "An", Email = "an@fpt.edu.vn", PassWord = "123456",
            City = "Quy Nhon", Country = "Viet Nam"},
            new MemberObject{MemberID = 3, MemberName = "Phat", Email = "phat@fpt.edu.vn", PassWord = "123456",
            City = "Quy Nhon", Country = "Viet Nam"},
            new MemberObject{MemberID = 4, MemberName = "Thao", Email = "thao@fpt.edu.vn", PassWord = "123456",
            City = "Quy Nhon", Country = "Viet Nam"},
            new MemberObject{MemberID = 5, MemberName = "Ngan", Email = "ngan@fpt.edu.vn", PassWord = "123456",
            City = "Quy Nhon", Country = "Viet Nam"}
        };

        private static MemberDAO? instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get { 
                lock(instanceLock) {
                    if(instance == null){
                       instance = new MemberDAO();
                    } 
                return instance;
                }
            }
        }

        //get memberList
        public List<MemberObject> GetMemberList => MemberList;
        //get member by ID
        public MemberObject GetMemberByID(int MemberID) { 
              MemberObject? member = MemberList.SingleOrDefault(pro => pro.MemberID == MemberID);
            return member;
        }
        //get member by Email
        public MemberObject GetMemberByEmail(string MemberEmail)
        {
            MemberObject? member = MemberList.SingleOrDefault(pro => pro.Email == MemberEmail);
            return member;
        }
        //Add new Member
        public void AddNewMember(MemberObject member)
        {
            if(GetMemberByID(member.MemberID) == null || GetMemberByEmail(member.Email) == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exist");
            }
        }
        //update Member
        public void UpdateMember(MemberObject member)
        {
            if (GetMemberByID(member.MemberID) == null || GetMemberByEmail(member.Email) == null)
            {
                throw new Exception("Member does not exist");
            }
            else
            {
                var item = MemberList.IndexOf(GetMemberByID(member.MemberID));
                MemberList[item] = member;
            }
        }
        //remove a member
        public void RemoveAMember(int IDmember)
        {
            MemberObject member = GetMemberByID(IDmember);
            if(GetMemberByID(member.MemberID) == null || GetMemberByEmail(member.Email) == null)
            {
                throw new Exception("Member does not exist");
            }
            else
            {
                MemberList.Remove(GetMemberByID(member.MemberID));
            }
        }
        //Sort
        public void SortByID()
        {
            MemberList.Sort(CompareToID);
        }
        public void SortByName()
        {
            MemberList.Sort(CompareToName);
        }

        public int CompareToID(MemberObject? x, MemberObject? y)
        {
            return x.MemberID.CompareTo(y.MemberID);
        }
        public int CompareToName(MemberObject? x, MemberObject? y)
        {
            return x.MemberName.CompareTo(y.MemberName);
        }

        public int CompareTo(MemberObject? other)
        {
            throw new NotImplementedException();
        }
    }
}
