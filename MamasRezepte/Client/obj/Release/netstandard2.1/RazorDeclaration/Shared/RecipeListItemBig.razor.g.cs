#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f6bf898e2a4561061a8a64bcf517356a9dc37a"
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
#line 2 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
using MamasRezepte.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class RecipeListItemBig : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
       

    [Parameter]
    public Recipe Recipe { get; set; }

    private string FLinkToRecipe { get; set; }

    private bool FLoading = true;
    private RenderFragment FImage { get; set; }
    RenderFragment<(string icon, string text)> IconText = context =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "Template");
            __builder2.AddMarkupContent(1, "\r\n        ");
            __builder2.OpenElement(2, "Space");
            __builder2.OpenElement(3, "SpaceItem");
            __builder2.OpenElement(4, "Icon");
            __builder2.AddAttribute(5, "Type", 
#nullable restore
#line 40 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
                                       context.icon

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.CloseElement();
            __builder2.OpenElement(6, "SpaceItem");
            __builder2.AddContent(7, 
#nullable restore
#line 40 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
                                                                               context.text

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.CloseElement();
            __builder2.AddMarkupContent(8, "\r\n    ");
            __builder2.CloseElement();
        }
#nullable restore
#line 41 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
               ;

protected override async Task OnInitializedAsync()
{
Recipe.Images = (await HttpClient.GetFromJsonAsync<IEnumerable<RecipeImage>>("/api/RecipeImages")).Where(_ => _.RecipeId == Recipe.Id);
Recipe.DurationCategory = (await HttpClient.GetFromJsonAsync<IEnumerable<DurationCategory>>($"/api/DurationCategories")).FirstOrDefault(_ => _.Id == Recipe.DurationCategoryId);

//var hBase64 = Convert.ToBase64String(Recipe.Images.First().ImageData);

//Console.WriteLine(Recipe.Images.First().ImageData);

var hImageSource = String.Format("data:image/jpeg;base64,{0}", Recipe.Images.First().ImageData);
FImage = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(9, "img");
            __builder2.AddAttribute(10, "width", "272");
            __builder2.AddAttribute(11, "alt", "image");
            __builder2.AddAttribute(12, "src", 
#nullable restore
#line 53 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
                                             hImageSource

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(13, "style", "border-radius: 2%");
            __builder2.CloseElement();
        }
#nullable restore
#line 53 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeListItemBig.razor"
                                                                                       ;
FLinkToRecipe = $"{ NavigationManager.BaseUri }/recipes/{ Recipe.Id }";

FLoading = false;
}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591