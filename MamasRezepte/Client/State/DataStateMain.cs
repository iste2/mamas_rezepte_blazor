using MamasRezepte.Shared.Helper;
using MamasRezepte.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MamasRezepte.Client.State
{
    public class DataStateMain
    {

        public event Action OnChange;

        public Filter FFilter { get; set; } = new Filter();

        public IEnumerable<Recipe> FFeed { get; set; }
        public IEnumerable<Category> FCategories { get; set; }
        public IEnumerable<Tag> FTags { get; set; }
        public IEnumerable<DurationCategory> FDurationCategories { get; set; }
        public IEnumerable<Click> FClicks { get; set; }
        public IEnumerable<RecipeImage> FImages { get; set; }
        public IEnumerable<RecipeToTagRelation> FRecipeToTagRelations { get; set; }

        public async Task InitializeIndex(NavigationManager _Nav, bool _IncludeClicks = true, bool _IncludeImages = false)
        {
            await LoadCategories(_Nav);
            await LoadTags(_Nav);
            await LoadDurationCategories(_Nav);

            await LoadFeed(_Nav, _IncludeClicks: _IncludeClicks, _IncludeImages: _IncludeImages);
        }

        public void UpdateFilter(Filter _Filter)
        {
            FFilter = _Filter;

            NotifyStateChanged();
        }

        public async Task LoadFeed(NavigationManager _Nav, bool _IncludeClicks = true, bool _IncludeImages = false)
        {
            var hHttp = new HttpClient();

            FFeed = await hHttp.GetFromJsonAsync<IEnumerable<Recipe>>(Path.Combine(_Nav.BaseUri, "api/recipes"));

            // Filter
            if(FFilter.IsEmpty())
            {
                if (FClicks == null) await LoadClicks(_Nav);
                FFeed = FFeed.OrderByDescending(_ => FeedCalculator.CalculateScore(FClicks.Where(_0 => _.Id == _0.RecipeId).ToList()));
            } else
            {
                if (FCategories == null) await LoadCategories(_Nav);
                if (FDurationCategories == null) await LoadDurationCategories(_Nav);
                if (FTags == null) await LoadTags(_Nav);
                if (FRecipeToTagRelations == null) await LoadRecipeToTagRealtions(_Nav);
                
                FFeed = FFeed.Where(_ => 
                    (FFilter.HasSearch() ? _.Name.Contains(FFilter.FSearch, StringComparison.OrdinalIgnoreCase) : true)
                    && (FFilter.FCategories.Any() ? FFilter.FCategories.Any(_0 => _0.Id == _.CategoryId) : true)
                    && (FFilter.FDurationCategories.Any() ? FFilter.FDurationCategories.Any(_0 => _0.Id == _.DurationCategoryId) : true)
                    && (FFilter.FTags.Any() ? FFilter.FTags.Any(_0 => FRecipeToTagRelations.Where(_1 => _1.RecipeId == _.Id).Any(_1 => _1.TagId == _0.Id)) : true)
                );

            }

            if(_IncludeImages)
            {
                await LoadImages(_Nav);
            }

            Console.WriteLine("Feed:");
            foreach (var hRecipe in FFeed)
            {
                Console.WriteLine(" - " + hRecipe.Name);
            }

            NotifyStateChanged();

        }

        public async Task LoadTags(NavigationManager _Nav, bool _OrderByFrequency = false)
        {
            var hHttp = new HttpClient();

            FTags = await hHttp.GetFromJsonAsync<IEnumerable<Tag>>(Path.Combine(_Nav.BaseUri, "api/tags"));

            if(_OrderByFrequency)
            {
                FTags = await hHttp.GetFromJsonAsync<IEnumerable<Tag>>(Path.Combine(_Nav.BaseUri, "api/tags/ByUsageFrequency"));
            }
            
            NotifyStateChanged();

        }

        public async Task LoadDurationCategories(NavigationManager _Nav)
        {
            var hHttp = new HttpClient();

            FDurationCategories = await hHttp.GetFromJsonAsync<IEnumerable<DurationCategory>>(Path.Combine(_Nav.BaseUri, "api/durationcategories"));

            NotifyStateChanged();

        }

        public async Task LoadCategories(NavigationManager _Nav)
        {
            var hHttp = new HttpClient();

            FCategories = await hHttp.GetFromJsonAsync<IEnumerable<Category>>(Path.Combine(_Nav.BaseUri, "api/categories"));

            NotifyStateChanged();

        }

        public async Task LoadClicks(NavigationManager _Nav)
        {
            var hHttp = new HttpClient();

            FClicks = await hHttp.GetFromJsonAsync<IEnumerable<Click>>(Path.Combine(_Nav.BaseUri, "api/clicks"));

            NotifyStateChanged();

        }

        public async Task LoadImages(NavigationManager _Nav)
        {
            var hHttp = new HttpClient();

            FImages = await hHttp.GetFromJsonAsync<IEnumerable<RecipeImage>>(Path.Combine(_Nav.BaseUri, "api/recipeimages"));

            NotifyStateChanged();

        }

        public async Task LoadRecipeToTagRealtions(NavigationManager _Nav)
        {
            var hHttp = new HttpClient();

            FRecipeToTagRelations = await hHttp.GetFromJsonAsync<IEnumerable<RecipeToTagRelation>>(Path.Combine(_Nav.BaseUri, "api/recipetotagrelations"));

            NotifyStateChanged();

        }


        public void NotifyStateChanged() => OnChange?.Invoke();

    }
}
