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

        public Task<List<MealModel>> GetFavoriteMeals()
        {
            string sql = "select * from dbo.Meals where Favorite = 1;";

            return _db.LoadData<MealModel, dynamic>(sql, new { });
        }

        public Task UpdateFavoriteMeal(MealModel meal)
        {
            string sql = @"MERGE INTO dbo.Meals USING (VALUES (@MealId, @Favorite)) AS source (MealId, Favorite)
                         ON dbo.Meals.MealId = source.MealId 
                         WHEN MATCHED THEN UPDATE SET Favorite = source.Favorite
                         WHEN NOT MATCHED THEN INSERT (MealId, Favorite) VALUES (source.MealId, source.Favorite);";

            return _db.SaveData(sql, meal);
        }
    }
}
