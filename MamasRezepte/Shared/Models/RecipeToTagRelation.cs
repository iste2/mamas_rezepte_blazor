using System;
using System.Collections.Generic;
using System.Text;

namespace MamasRezepte.Shared.Models
{
    public class RecipeToTagRelation
    {
        public long Id { get; set; }
        
        public long RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public long TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
