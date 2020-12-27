using MamasRezepte.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MamasRezepte.Client.State
{
    public class DataStateDetail
    {
        public event Action OnChange;

        public Recipe FRecipe { get; set; }

        public void SetRecipe(Recipe _Recipe)
        {
            FRecipe = _Recipe;
            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnChange?.Invoke();

    }
}
