using BillibradDAL;
using BillibradModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDLL
{
    public class FoodManager
    {
        public static List<Foods> GetFoods()
        {
            try
            {
                return FoodService.GetFoods();
            }catch(SqlException ex)
            {
                throw ex;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
