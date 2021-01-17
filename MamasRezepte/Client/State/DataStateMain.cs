using MamasRezepte.Shared.Helper;
using MamasRezepte.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public IEnumerable<Ingredient> FIngredients { get; set; }
        public IEnumerable<Product> FProducts { get; set; }

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

            var hStopwatch = new Stopwatch();
            hStopwatch.Start();

            FFeed = await hHttp.GetFromJsonAsync<List<Recipe>>(Path.Combine(_Nav.BaseUri, "api/recipes"));

            hStopwatch.Stop();
            Console.WriteLine("Fetching feed took " + hStopwatch.ElapsedMilliseconds + "ms");
            hStopwatch.Reset();
            hStopwatch.Start();

            // Filter
            if (FFilter.IsEmpty())
            {
                FFeed = FFeed.OrderByDescending(_ => FeedCalculator.CalculateScore(_.Clicks.ToList())).ToList();
                
            } else
            {
                FFeed = FFeed.Where(_ => 
                    (FFilter.HasSearch() ? _.Name.Contains(FFilter.FSearch, StringComparison.OrdinalIgnoreCase) : true)
                    && (FFilter.FCategories.Any() ? FFilter.FCategories.Any(_0 => _0.Id == _.CategoryId) : true)
                    && (FFilter.FDurationCategories.Any() ? FFilter.FDurationCategories.Any(_0 => _0.Id == _.DurationCategoryId) : true)
                    && (FFilter.FTags.Any() ? FFilter.FTags.Any(_0 => FRecipeToTagRelations.Where(_1 => _1.RecipeId == _.Id).Any(_1 => _1.TagId == _0.Id)) : true)
                );
            }

            hStopwatch.Stop();
            Console.WriteLine("Ordering feed took " + hStopwatch.ElapsedMilliseconds + "ms");

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

        public async Task LoadIngredients(NavigationManager _Nav)
        {
            var hHttp = new HttpClient();

            FIngredients = await hHttp.GetFromJsonAsync<IEnumerable<Ingredient>>(Path.Combine(_Nav.BaseUri, "api/ingredients"));

            NotifyStateChanged();

        }

        public async Task LoadProducts(NavigationManager _Nav)
        {
            var hHttp = new HttpClient();

            FProducts = await hHttp.GetFromJsonAsync<IEnumerable<Product>>(Path.Combine(_Nav.BaseUri, "api/products"));

            NotifyStateChanged();

        }


        public void NotifyStateChanged() => OnChange?.Invoke();

    }
}
