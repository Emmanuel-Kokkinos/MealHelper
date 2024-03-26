using MealHelperData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealHelperData
{
    public class IngredientData : IIngredientData
    {
        private readonly ISqlDataAccess _db;

        public IngredientData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<List<IngredientModel>> GetShoppingIngredients()
        {
            string sql = "SELECT * FROM dbo.Ingredients;";

            return _db.LoadIngredients<IngredientModel, dynamic>(sql, new { });
        }

        public Task AddShoppingIngredients(IngredientModel ingredients)
        {
            string sql = @"INSERT INTO dbo.Ingredients (MealId, IngredientName, IngredientAmount)
                           VALUES (@MealId, @IngredientName, @IngredientAmount);";

            return _db.SaveIngredients(sql, ingredients);
        }

        public Task DeleteShoppingIngredients(IngredientModel ingredients)
        {
            string sql = @"DELETE FROM dbo.Ingredients
                           WHERE MealId = @MealId
                           AND IngredientName = @IngredientName;";

            return _db.SaveIngredients(sql, ingredients);
        }
    }
}
