using BillibradModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDAL
{
    public class MemberService
    {
        //获取所有会员信息
        public List<Member> GetMember()
        {
            string sql = "select * from Member";
            return GetMemberListBySql(sql, null);
        }
        public Member GetMemberByMemberID(int memberID)
        {
            string sql = "select * from Member where MemberID=@MemberID";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@MemberID",memberID)
            };
            return GetMemberBySql(sql, param); ;
        }
        public int Add(Member member)
        {
            string sql = "insert into Member(MemberName,MemberPhone) values (@MemberName,@MemberPhone)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberName",member.MemberName),
                new SqlParameter("@MemberPhone",member.MemberPhone)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        public int Update(Member member)
        {
            string sql = "update Member  set MemberName=@MemberName,MemberPhone=@MemberPhone where MemberID=@MemberID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberID",member.MemberID),
                new SqlParameter("@MemberPhone",member.MemberPhone),
                new SqlParameter("@MemberName",member.MemberName)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        public int Delete(int memberID)
        {
            string sql = "delete from Member where MemberID=" + memberID;
            return SqlHelper.ExecuteNonQuery(sql, null);
        }
        private Member GetMemberBySql(string sql, SqlParameter[] parameters)
        {
            using (SqlDataReader reader = SqlHelper.GetDataReader(sql, parameters))
            {
                Member member = null;
                if (reader.Read())
                {
                    member = new Member();
                    member.MemberID = Convert.ToInt32(reader["MemberID"]);
                    member.MemberName = Convert.ToString(reader["MemberName"]);
                    member.MemberPhone = Convert.ToString(reader["MemberPhone"]);

                }
                return member;
            }
        }
        private List<Member> GetMemberListBySql(string sql, SqlParameter[] parameters)
        {
            List<Member> memberList = new List<Member>();
            using (SqlDataReader reader = SqlHelper.GetDataReader(sql, parameters))
            {
                while (reader.Read())
                {
                    Member member= new Member();
                    member.MemberID = Convert.ToInt32(reader["MemberID"]);
                    member.MemberName = Convert.ToString(reader["MemberName"]);
                    member.MemberPhone = Convert.ToString(reader["MemberPhone"]);
                    memberList.Add(member);
                }
                return memberList;
            }
        }
        //会员名称模糊查找
        public List<Member> GetMemberListByMemberName(string memberName)
        {
            string sql = "select * from Member where MemberName like @MemberName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberName","%"+memberName+"%")
            };
            return GetMemberListBySql(sql, parameters);
        }
    }

}
