using System;
using System.Collections.Generic;
using System.Text;

namespace MamasRezepte.Shared.Models
{
    public class RecipeImage
    {
        // http://www.binaryintellect.net/articles/2f55345c-1fcb-4262-89f4-c4319f95c5bd.aspx

        public long Id { get; set; }
        public long RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public byte[] ImageData { get; set; }
    }
}
