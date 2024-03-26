using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealHelperData.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public string IngredientName { get; set; }
        public string? IngredientAmount { get; set; }
    }
}
