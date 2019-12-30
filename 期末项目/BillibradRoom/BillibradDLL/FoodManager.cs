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
        FoodService foodService = new FoodService();
        //获取全部商品
        public List<Foods> GetAllFoods()
        {
            return foodService.GetFoods();
        }
        //添加商品
        public int Add(Foods foods)
        {
            if (foodService.GetFoodByFoodName(foods.FoodName) != null)
            {
                return -1;
            }
            return foodService.Add(foods);
        }
        //更改库存
        public int UpdateFood(Foods foods)
        {
            return foodService.UpdateFood(foods);
        }
        //删除商品
        public int DeleteFood(string foodName)
        {
            return foodService.DeleteFoodByFoodName(foodName);
        }
    }
}
