using System;
using System.Collections.Generic;
using System.Text;

namespace MamasRezepte.Shared.Models
{
    public class Click
    {
        public long Id { get; set; }
        public long RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public DateTime Time { get; set; }

    }
}
