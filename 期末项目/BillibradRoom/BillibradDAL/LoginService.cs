using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDAL
{
    public class LoginService
    {
        public static bool Login(String loginId, String loginPwd)
        {
            //创建Sql语句
            String sql = String.Format("select * from [User] where LoginId='{0}'  AND LoginPwd='{1}'", loginId, loginPwd);
            //创建Connection对象
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = "server=.;database=BilliardRoom;uid=sa;pwd=123"
            };
            try
            {
                // 创建Command命令
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                // 执行查询语句
                SqlDataReader reader = cmd.ExecuteReader();
                //如果检索到则返回true，否则返回false
                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //关闭数据库连接
                conn.Close();
            }

        }
    }
}
