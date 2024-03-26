
namespace MealHelperData
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadMeals<T, U>(string sql, U parameters);
        Task SaveMeals<T>(string sql, T parameters);
        Task<List<T>> LoadIngredients<T, U>(string sql, U parameters);
        Task SaveIngredients<T>(string sql, T parameters);
    }
}