using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealHelperData.Models
{
    public class MealModel
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public bool InShoppingList { get; set; }
        public bool Favorite { get; set; }
    }
}
