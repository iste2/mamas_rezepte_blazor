#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8166d0c685ac9bcff4c40ccef32c694cf612fa44"
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
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
using State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
using Const;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
using MamasRezepte.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
using MamasRezepte.Shared.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"padding-top: 32px; \"></div>\r\n\r\n");
#nullable restore
#line 19 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
 if (State.FFilter.IsEmpty())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, @"<div class=""row d-flex justify-content-center"" style=""margin-bottom:48px;"">
        <div class=""col-12 col-sm-4"">
            <div class=""d-flex justify-content-center"">
                <img src=""/Assets/logo.png"" alt style=""height:150px;"">
            </div>
        </div>
        <div class=""col-12 col-sm-8"">
            <h1 class=""text-center text-sm-start"" style=""margin-bottom:12px; font-weight:bold;width:100%;"">Mamas Rezepte</h1>
        </div>
    </div>
");
#nullable restore
#line 32 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
}



#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "margin-bottom: 64px;");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "p-2 rounded rounded-pill shadow mb-4");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "input-group");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "search");
            __builder.AddAttribute(14, "placeholder", "Wonach suchst du?");
            __builder.AddAttribute(15, "aria-describedby", "button-addon1");
            __builder.AddAttribute(16, "class", "form-control border-0");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                           FSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FSearch = __value, FSearch));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "input-group-append");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                    () => EditFilter(FSearch)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "id", "button-addon1");
            __builder.AddAttribute(26, "type", "submit");
            __builder.AddAttribute(27, "class", "btn btn-link");
            __builder.AddAttribute(28, "style", "color:orange;");
            __builder.AddMarkupContent(29, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                  CollapseFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "id", "button-addon2");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-link");
            __builder.AddAttribute(36, "style", "color:orange;");
            __builder.AddMarkupContent(37, "<i class=\"fa fa-filter\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
#nullable restore
#line 50 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
 if (State.FCategories != null && State.FDurationCategories != null && State.FTags != null && State.FFilter != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "collapse" + " " + (
#nullable restore
#line 52 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                           !FFilterCollapsed ? "show" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "style", "margin-bottom:32px;margin-top:-32px;");
            __builder.AddAttribute(47, "id", "collapseExample");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card card-body");
            __builder.AddMarkupContent(51, "\r\n\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.AddMarkupContent(54, "<a>Kategorien</a>\r\n");
#nullable restore
#line 57 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                 foreach (var hElement in State.FCategories)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                     () => EditFilter(hElement)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "class", "badge" + " rounded-pill" + " " + (
#nullable restore
#line 59 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                              !State.FFilter.Contains(hElement) ? "bg-secondary" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "style", 
#nullable restore
#line 59 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                                                                 State.FFilter.Contains(hElement) ? "background:orange;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, 
#nullable restore
#line 59 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                                                                                                                                 hElement.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 60 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "                <div class=\"dropdown-divider\" style=\"margin-top:12px;\"></div>\r\n                ");
            __builder.AddMarkupContent(63, "<a>Dauer</a>\r\n");
#nullable restore
#line 63 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                 foreach (var hElement in State.FDurationCategories)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                     () => EditFilter(hElement)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "class", "badge" + " rounded-pill" + " " + (
#nullable restore
#line 65 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                              !State.FFilter.Contains(hElement) ? "bg-secondary" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "style", 
#nullable restore
#line 65 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                                                                 State.FFilter.Contains(hElement) ? "background:orange;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, 
#nullable restore
#line 65 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                                                                                                                                 hElement.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 66 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "                <div class=\"dropdown-divider\" style=\"margin-top:12px;\"></div>\r\n                ");
            __builder.AddMarkupContent(72, "<a>Beliebte Tags</a>\r\n");
#nullable restore
#line 69 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                 foreach (var hElement in State.FTags)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                     () => EditFilter(hElement)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "class", "badge" + " rounded-pill" + " " + (
#nullable restore
#line 71 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                              !State.FFilter.Contains(hElement) ? "bg-secondary" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "style", 
#nullable restore
#line 71 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                                                                 State.FFilter.Contains(hElement) ? "background:orange;" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, 
#nullable restore
#line 71 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                                                                                                                                 hElement.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 72 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 77 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
}



#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
 if (!State.FFilter.IsEmpty())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", true);
            __builder.AddAttribute(87, "style", "margin-bottom:32px; margin-top:-16px; padding-left:12px; padding-right:12px;");
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "row text-end");
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "a");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                         ClearSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "class", "pull-right clickable");
            __builder.AddAttribute(95, "style", "color:dimgrey;");
            __builder.AddMarkupContent(96, "<i class=\"fa fa-times\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "row");
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-12");
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.OpenElement(105, "h2");
            __builder.AddContent(106, "Suche nach \"");
            __builder.AddContent(107, 
#nullable restore
#line 90 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                  State.FFilter.FSearch

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(108, "\"");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-12");
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 93 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                 foreach (var hCategory in State.FFilter.FCategories)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                    ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                     () => EditFilter(hCategory)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "class", "badge rounded-pill");
            __builder.AddAttribute(118, "style", "background:orange;");
            __builder.AddContent(119, 
#nullable restore
#line 95 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                          hCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 96 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                 foreach (var hDurationCategory in State.FFilter.FDurationCategories)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "                    ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                     () => EditFilter(hDurationCategory)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "class", "badge rounded-pill");
            __builder.AddAttribute(125, "style", "background:orange;");
            __builder.AddContent(126, 
#nullable restore
#line 99 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                                  hDurationCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 100 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                 foreach (var hTag in State.FFilter.FTags)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, "                    ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                     () => EditFilter(hTag)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "class", "badge rounded-pill");
            __builder.AddAttribute(132, "style", "background:orange;");
            __builder.AddContent(133, 
#nullable restore
#line 103 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                                                                                                                     hTag.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
#nullable restore
#line 104 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(135, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 108 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
}


#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
 if (State.FFeed != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "    ");
            __builder.OpenComponent<MamasRezepte.Client.Shared.Masonry>(140);
            __builder.AddAttribute(141, "FElements", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<MamasRezepte.Shared.Models.Recipe>>(
#nullable restore
#line 113 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
                        State.FFeed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(142, "\r\n");
#nullable restore
#line 114 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
       

    private string FSearch { get; set; }
    private bool FFilterCollapsed { get; set; } = true;

    protected override void OnInitialized()
    {
        State.OnChange += StateHasChanged;
    }

    protected override async Task OnInitializedAsync()
    {
        await State.InitializeIndex(Nav);

        this.StateHasChanged();
    }

    private async Task LoadFeed()
    {
        await State.LoadFeed(Nav);

        this.StateHasChanged();
    }

    private async Task EditFilter(object _Object)
    {
        if (!State.FFilter.Contains(_Object) && _Object != null)
        {
            State.FFilter.AddToFilter(_Object);
        }
        else
        {
            State.FFilter.RemoveFromFilter(_Object);
        }

        await State.LoadFeed(Nav);
        this.StateHasChanged();

    }

    private async Task ClearSearch()
    {
        State.FFilter.ClearFilter();
        FSearch = "";

        await State.LoadFeed(Nav);

        this.StateHasChanged();

    }

    private void CollapseFilter()
    {
        FFilterCollapsed = !FFilterCollapsed;
        this.StateHasChanged();
    }

    public void Dispose()
    {
        State.OnChange -= StateHasChanged;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStateMain State { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService Toast { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
