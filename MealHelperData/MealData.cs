using MealHelperData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealHelperData
{
    public class MealData : IMealData
    {
        private readonly ISqlDataAccess _db;

        public MealData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<List<MealModel>> GetMeals()
        {
            string sql = "select * from dbo.Meals";

            return _db.LoadData<MealModel, dynamic>(sql, new { });
        }

        public Task InsertMeal(MealModel meal)
        {
            /*string sql = @"insert into dbo.Meals (Id, MealId, InShoppingList, Favorite)
                           values (@Id, @MealId, @InShoppingList, @Favorite)";*/
            string sql = @"insert into dbo.Meals (Id, MealId, InShoppingList, Favorite)
                           values (1, 52772, false, true)";

            return _db.SaveData(sql, meal);
        }
    }
}
