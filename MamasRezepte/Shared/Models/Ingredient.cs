using System;
using System.Collections.Generic;
using System.Text;

namespace MamasRezepte.Shared.Models
{
    public class Ingredient
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }
        public long RecipeId { get; set; }
        public Recipe Recipe { get; set; }

    }
}
