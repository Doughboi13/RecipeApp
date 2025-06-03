using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string Name { get; set; } = "";
        public string DefaultUnit { get; set; } = "";

        public string? Substitutions { get; set; }
    }
}
