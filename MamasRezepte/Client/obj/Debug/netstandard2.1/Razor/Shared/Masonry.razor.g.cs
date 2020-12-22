#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f980fcb0be0bebab02f35c8421fc38631145260"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
using Const;

#line default
#line hidden
#nullable disable
    public partial class Masonry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddAttribute(2, "data-masonry", "{\"percentPosition\": true }");
            __builder.AddMarkupContent(3, "\r\n    \r\n");
#nullable restore
#line 6 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
     foreach(var hElement in FElements)
    {
        var hRandom = new Random();
        var hNumber = hRandom.NextDouble();

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col col-12 col-sm-6 col-lg-4 mb-4");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 11 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
             if(hNumber > 0.5){

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenComponent<MamasRezepte.Client.Shared.RecipeCardImage>(9);
            __builder.AddAttribute(10, "FTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
                                          hElement

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 13 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenComponent<MamasRezepte.Client.Shared.RecipeCardNoImage>(13);
            __builder.AddAttribute(14, "FTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
                                            hElement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "FColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
                                                               ColorConsts.RandomColor()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 17 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 20 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
       

    [Parameter]
    public IEnumerable<string> FElements { get; set; }

    [Parameter]
    public int FNumCols { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591