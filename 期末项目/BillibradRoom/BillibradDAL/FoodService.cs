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
        public List<Foods> GetFoods()
        {
            string sql = "select * from Foods";
            return GetFoodsListBySql(sql, null);
        }
        //通过查询生成食品集合
        private List<Foods> GetFoodsListBySql(string sql, SqlParameter[] parameters)
        {
            List<Foods> foodList = new List<Foods>();
            using(SqlDataReader reader = SqlHelper.GetDataReader(sql, parameters))
            {
                while (reader.Read())
                {
                    Foods foods = new Foods();
                    foods.FoodName = Convert.ToString(reader["FoodName"]);
                    foods.FoodPrice = Convert.ToDecimal(reader["FoodPrice"]);
                    foods.FoodNum = Convert.ToInt32(reader["FoodNum"]);
                    foodList.Add(foods);
                }
                return foodList;
            }
        }
    }
}
