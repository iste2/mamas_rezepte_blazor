#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2beef080cb8ca52fd59b546194110d4b306ad11"
// <auto-generated/>
#pragma warning disable 1591
namespace MamasRezepte.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"padding-top: 32px; \"></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""row d-flex justify-content-center"" style=""margin-bottom:48px;"">
    <div class=""col-12 col-sm-4"">
        <div class=""d-flex justify-content-center"">
            <img src=""/Assets/logo.png"" alt style=""height:150px;"">
        </div>
    </div>
    <div class=""col-12 col-sm-8"">
        <h1 style=""margin-bottom:12px; font-weight:bold;"">Mamas Rezepte</h1>
        <p style=""color:gray; font-weight:bold;""> Hier sind all die leckeren Rezepte von Mama gesammelt. Suche nach bestimmten Rezepten oder durchstöbere den Feed. Guten Appetit! :)</p>
    </div>
</div>

");
            __builder.AddMarkupContent(2, @"<div style=""margin-bottom: 64px;"">
    <div class=""p-2 rounded rounded-pill shadow mb-4"">
        <div class=""input-group"">
            <input type=""search"" placeholder=""Wonach suchst du?"" aria-describedby=""button-addon1"" class=""form-control border-0"">
            <div class=""input-group-append"">
                <button id=""button-addon1"" type=""submit"" class=""btn btn-link"" style=""color:orange;""><i class=""fa fa-search""></i></button>
                <button id=""button-addon2"" rimary"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseExample"" aria-expanded=""true"" aria-controls=""collapseExample"" class=""btn btn-link"" style=""color:orange;""><i class=""fa fa-filter""></i></button>
            </div>
        </div>
    </div>
</div>

");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "collapse");
            __builder.AddAttribute(5, "style", "margin-bottom:32px;margin-top:-32px;");
            __builder.AddAttribute(6, "id", "collapseExample");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card card-body");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<p>Kategorien</p>\r\n");
#nullable restore
#line 42 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
             foreach (var hElement in Categories)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "badge rounded-pill bg-secondary");
            __builder.AddContent(17, 
#nullable restore
#line 44 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                              hElement

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 45 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "            ");
            __builder.AddMarkupContent(20, "<p>Tags</p>\r\n");
#nullable restore
#line 47 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
             foreach (var hElement in Tags)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "badge rounded-pill bg-secondary");
            __builder.AddContent(24, 
#nullable restore
#line 49 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                              hElement

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 50 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n\r\n");
            __builder.OpenComponent<MamasRezepte.Client.Shared.Masonry>(30);
            __builder.AddAttribute(31, "FElements", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 58 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                    Elements

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
       

    private List<string> Elements = new List<string> {
        "Soße", "Hamburger", "Spinat", "Gulasch", "Fritten", "Fischstäbchen", "Frikadellen", "Kartoffelsuppe", "Entenbrust", "Blutwurst",
        "Kartoffelsalat", "Erbsensalat", "Fondue", "Lachs", "Nudeln",
        "Soße", "Hamburger", "Spinat", "Gulasch", "Fritten", "Fischstäbchen", "Frikadellen", "Kartoffelsuppe", "Entenbrust", "Blutwurst",
        "Kartoffelsalat", "Erbsensalat", "Fondue", "Lachs", "Nudeln",
    };

    private List<string> Categories = new List<string> {
        "Hauptspeise", "Vorspeise", "Nachspeise", "Kuchen und Gebäck", "Salate", "Beilagen"
    };

    private List<string> Tags = new List<string> {
        "Alltag", "Festtag", "Weihnachten", "einfach", "schwierig"
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
