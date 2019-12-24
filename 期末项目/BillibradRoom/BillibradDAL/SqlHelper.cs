using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDAL
{
    public class SqlHelper
    {
        public static string ConnString = "server=.;database=BilliardRoom;uid=sa;pwd=123";

        //增删改操作,并返回影响的行数
        public static int ExecuteNonQuery(string sql, SqlParameter[] param)
        {
            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                if (param != null)  //如果有参数传入
                {
                    command.Parameters.AddRange(param);
                }
                return command.ExecuteNonQuery();
            }
        }
        //查询操作
        public static SqlDataReader GetDataReader(string sql, SqlParameter[] param)
        {
            SqlConnection connection = new SqlConnection(ConnString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            if (param != null)
            {
                command.Parameters.AddRange(param);
            }
            return command.ExecuteReader();
        }
    }
}
