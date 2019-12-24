using BillibradModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDAL
{
    public class FoodService
    {
        //获取所有商品信息
        public static List<Foods> GetFoods()
        {
            DataSet ds = new DataSet();
            string sql = "select * from Foods";
            List<Foods> foodsList = new List<Foods>();
            using (SqlConnection conn = new SqlConnection(SqlHelper.ConnString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Foods foods = new Foods();
                        foods.FoodName = Convert.ToString(dataReader["FoodName"]);
                        foods.FoodNum = Convert.ToInt32(dataReader["FoodNum"]);
                        foods.FoodPrice = Convert.ToDouble(dataReader["FoodPrice"]);
                        foodsList.Add(foods);
                    }
                    dataReader.Close();
                    return foodsList;
                }catch(SqlException ex)
                {
                    throw ex;
                }catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
