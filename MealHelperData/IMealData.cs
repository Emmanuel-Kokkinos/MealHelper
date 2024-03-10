using MealHelperData.Models;

namespace MealHelperData
{
    public interface IMealData
    {
        Task<List<MealModel>> GetFavoriteMeals();
        Task UpdateFavoriteMeal(MealModel meal);
    }
}