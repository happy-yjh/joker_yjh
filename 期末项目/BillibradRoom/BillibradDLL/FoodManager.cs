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
      public List<Foods> GetAllFoods()
        {
            return foodService.GetFoods();
        }
    }
}
