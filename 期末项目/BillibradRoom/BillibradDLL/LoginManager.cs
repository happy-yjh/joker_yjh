using BillibradDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDLL
{
    public class LoginManager
    {
        private LoginService loginService = new LoginService();//实例化数据访问对象
        public static bool CheckLogin(string loginId,string loginPwd)
        {
            try
            {
                return LoginService.Login(loginId, loginPwd);
            }catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
