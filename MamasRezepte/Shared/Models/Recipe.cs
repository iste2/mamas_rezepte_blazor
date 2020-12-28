using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MamasRezepte.Shared.Models
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Instruction { get; set; }
        public IEnumerable<RecipeImage> Images { get; set; }
        public string Subtitle { get; set; }
        public long DurationCategoryId { get; set; }
        public DurationCategory DurationCategory { get; set; }
        public int NumberOfPersons { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<RecipeToTagRelation> Tags { get; set; }
        public DateTime PublishDate { get; set; }
        public IEnumerable<Click> Clicks { get; set; }

    }
}
