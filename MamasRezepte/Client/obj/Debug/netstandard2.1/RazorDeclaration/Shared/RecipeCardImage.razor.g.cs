#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cabc67c4a5638634485492aea9b687c0fdf8899"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MamasRezepte.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using MamasRezepte.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using MamasRezepte.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor"
using MamasRezepte.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor"
using MamasRezepte.Client.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class RecipeCardImage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor"
       

    [Parameter]
    public Recipe FRecipe { get; set; }

    [Parameter]
    public string FImageData { get; set; }

    //private string FImageData => State.FImages.FirstOrDefault(_ => _.RecipeId == FRecipe.Id).ImageData;

    private string FImageSrc => $"data:image/jpeg;base64,{ FImageData }";

    public async Task OpenRecipe()
    {
        /*
        await State.LoadMissingData(Nav);
        
        // assemble recipe
        FRecipe.Images = State.FImages.Where(_ => _.RecipeId == FRecipe.Id).ToList();
        FRecipe.Category = State.FCategories.FirstOrDefault(_ => _.Id == FRecipe.CategoryId);
        FRecipe.DurationCategory = State.FDurationCategories.FirstOrDefault(_ => _.Id == FRecipe.DurationCategoryId);
        FRecipe.Tags = State.FRecipeToTagRelations.Where(_ => _.RecipeId == FRecipe.Id).ToList();
        foreach (var hRecipeToTagRelation in FRecipe.Tags)
        {
            hRecipeToTagRelation.Tag = State.FTags.FirstOrDefault(_ => _.Id == hRecipeToTagRelation.TagId);
        }
        FRecipe.Clicks = State.FClicks.Where(_ => _.RecipeId == FRecipe.Id);
        FRecipe.Ingredients = State.FIngredients.Where(_ => _.RecipeId == FRecipe.Id).ToList();
        foreach (var hIngredient in FRecipe.Ingredients)
        {
            hIngredient.Product = State.FProducts.FirstOrDefault(_ => _.Id == hIngredient.ProductId);
        }

        // set detail state
        DetailState.SetRecipe(FRecipe);
        */

        Nav.NavigateTo(Path.Combine(Nav.BaseUri, "rezept/", FRecipe.Id+""));
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStateDetail DetailState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStateMain State { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
