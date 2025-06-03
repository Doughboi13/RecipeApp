using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class RecipeIngredient

    {
        public int RecipeIngredientID { get; set; }
        public int RecipeID { get; set; }
        public int IngredientID { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; } = "";
        public string? Notes { get; set; }
    }
}
