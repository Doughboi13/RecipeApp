using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Name { get; set; } = "";
        public string Instructions { get; set; } = "";
        public int Servings { get; set; } = 4;
        public int PrepTimeMinutes { get; set; }
        public string Tags { get; set; } = "";
        public string? PhotoPath { get; set; }
        public string? SourceUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation property for ingredients
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
}