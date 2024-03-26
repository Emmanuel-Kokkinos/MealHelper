using MealHelperData.Models;

namespace MealHelperData
{
    public interface IIngredientData
    {
        Task AddShoppingIngredients(IngredientModel ingredients);
        Task DeleteShoppingIngredients(IngredientModel ingredients);
        Task<List<IngredientModel>> GetShoppingIngredients();
    }
}