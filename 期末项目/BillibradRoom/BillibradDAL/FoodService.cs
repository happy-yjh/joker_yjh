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
        //根据商品名称获取商品
        public Foods GetFoodByFoodName(string foodName)
        {
            string sql = "select * from Foods where FoodName=@FoodName";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@FoodName",foodName)
            };
            return GetFoodsBySql(sql, param); ;
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
        //添加商品
        public int Add(Foods foods)
        {
            string sql = "insert into Foods(FoodName,FoodPrice,FoodNum) values (@FoodName,@FoodPrice,@FoodNum)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FoodName",foods.FoodName),
                new SqlParameter("@FoodPrice",foods.FoodPrice),
                new SqlParameter("@FoodNum",foods.FoodNum)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        //更改库存
        public int UpdateFood(Foods foods)
        {
            string sql = "update Food set FoodNum=@FoodNum where FoodName=@FoodName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FoodName",foods.FoodName),
                new SqlParameter("@FoodPrice",foods.FoodPrice),
                new SqlParameter("@FoodNum",foods.FoodNum)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        //查询并生成房间
        private Foods GetFoodsBySql(string sql, SqlParameter[] parameters)
        {
            using (SqlDataReader reader = SqlHelper.GetDataReader(sql, parameters))
            {
                Foods foods = null;
                if(reader.Read())
                {
                    foods = new Foods();
                    foods.FoodName = Convert.ToString(reader["FoodName"]);
                    foods.FoodPrice = Convert.ToDecimal(reader["FoodPrice"]);
                    foods.FoodNum = Convert.ToInt32(reader["FoodNum"]);

                }
                return foods;
            }
        }
    }
}
