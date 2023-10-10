using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberID)
        {
            MemberDAO.Instance.RemoveAMember(memberID);
        }

        public MemberObject GetMemberbyID(int memberID)
        {
            return MemberDAO.Instance.GetMemberByID(memberID);
        }

        public MemberObject GetMemberByEmail(string memberName)
        {
            return MemberDAO.Instance.GetMemberByEmail(memberName);
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            return MemberDAO.Instance.GetMemberList;
        }

        public void InsertMember(MemberObject member)
        {
            MemberDAO.Instance.AddNewMember(member);
        }

        public void SearchById(string id)
        {
            throw new NotImplementedException();
        }

        public void sortMemberByID()
        {
            MemberDAO.Instance.SortByID();
        }

        public void sortMemberByName()
        {
            MemberDAO.Instance.SortByName();
        }

        public void UpdateMember(MemberObject member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}

