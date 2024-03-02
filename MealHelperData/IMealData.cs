using MealHelperData.Models;

namespace MealHelperData
{
    public interface IMealData
    {
        Task<List<MealModel>> GetMeals();
        Task InsertMeal(MealModel meal);
    }
}