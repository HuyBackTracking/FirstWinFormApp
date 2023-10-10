using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public interface IMemberRepository
    {
        public void DeleteMember(int memberID);

        public MemberObject GetMemberbyID(int memberID);

        public MemberObject GetMemberByEmail(string memberName);

        public IEnumerable<MemberObject> GetMemberList();

        public void InsertMember(MemberObject member);

        public void SearchById(string id);

        public void sortMemberByID();

        public void sortMemberByName();

        public void UpdateMember(MemberObject member);
    }
}
