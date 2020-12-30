using BlazorInputFile;
using MamasRezepte.Client.Const;
using MamasRezepte.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamasRezepte.Client.State
{
    public class DataStateEditor
    {

        public event Action OnChange;

        public EditorMode FEditorMode { get; set; }
        public Recipe FRecipe { get; set; } = new Recipe
        {
            Tags = new List<RecipeToTagRelation>(),
            Images = new List<RecipeImage>(),
            Ingredients = new List<Ingredient>(),
        };

        public void ResetRecipe()
        {
            FRecipe = new Recipe
            {
                Tags = new List<RecipeToTagRelation>(),
                Images = new List<RecipeImage>(),
                Ingredients = new List<Ingredient>(),
            };

            NotifyStateChanged();
        }

        public void SetRecipe(Recipe _Recipe)
        {
            FRecipe = _Recipe;
            NotifyStateChanged();
        }

        public void UpdateEditorMode()
        {
            FEditorMode = FRecipe?.Id == 0 ? EditorMode.Create : EditorMode.Edit;
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
