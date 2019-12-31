using BillibradDAL;
using BillibradModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDLL
{
    public class MemberManager
    {
        MemberService memberService = new MemberService();
        public List<Member> GetAllMember()
        {
            return memberService.GetMember();
        }
        public int Add(Member member)
        {
            if (memberService.GetMemberByMemberID(member.MemberID) != null)
            {
                return -1;
            }
            return memberService.Add(member);
        }
        public int Update(Member member)
        {
            return memberService.Update(member);
        }
        public int Delete(int memberID)
        {
            return memberService.Delete(memberID);
        }
        public List<Member>GetMembersByMemberName(string memberName)
        {
            return memberService.GetMemberListByMemberName(memberName);
        }
    }
}
