#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c3d0fd4925a46d74b5c253feaf0ae344372725f"
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
    public partial class RecipeCardImage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card shadow-sm");
            __builder.AddAttribute(2, "style", "border:hidden;");
            __builder.AddMarkupContent(3, "\r\n    <img src=\"https://image.brigitte.de/10974614/t/80/v3/w1440/r1.5/-/nuggets.jpg\" class=\"card-img-top\" alt style=\"max-height:150px;  object-fit:cover;\">\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "h6");
            __builder.AddAttribute(8, "class", "card-title");
            __builder.AddContent(9, 
#nullable restore
#line 6 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor"
                                FTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\RecipeCardImage.razor"
       

    [Parameter]
    public string FTitle { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591