#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d11bf06c77bde13f9995f41069597657be3a8d1"
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
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\MainLayout.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenComponent<AntDesign.Layout>(3);
            __builder.AddAttribute(4, "Class", "layout");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<AntDesign.Header>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(9, "\r\n            <div class=\"logo\"></div>\r\n            ");
                    __builder3.OpenComponent<AntDesign.Menu>(10);
                    __builder3.AddAttribute(11, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuTheme>(
#nullable restore
#line 10 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\MainLayout.razor"
                         MenuTheme.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 10 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\MainLayout.razor"
                                               MenuMode.Horizontal

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "DefaultSelectedKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 10 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\MainLayout.razor"
                                                                                          new[]{"2"}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(16);
                        __builder4.AddAttribute(17, "Key", "1");
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(19, "nav 1");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(20, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(21);
                        __builder4.AddAttribute(22, "Key", "2");
                        __builder4.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(24, "nav 2");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(25, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(26);
                        __builder4.AddAttribute(27, "Key", "3");
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(29, "nav 3");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<AntDesign.Content>(33);
                __builder2.AddAttribute(34, "Style", "padding: 0 50px;");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "class", "row justify-content-center");
                    __builder3.AddMarkupContent(39, "\r\n                ");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "col-12");
                    __builder3.AddAttribute(42, "style", "max-width: 800px;");
                    __builder3.AddMarkupContent(43, "\r\n                    ");
                    __builder3.OpenComponent<AntDesign.Breadcrumb>(44);
                    __builder3.AddAttribute(45, "Style", "margin: 16px 0;");
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(47, "\r\n                        ");
                        __builder4.OpenComponent<AntDesign.BreadcrumbItem>(48);
                        __builder4.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(50, "Home");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n                        ");
                        __builder4.OpenComponent<AntDesign.BreadcrumbItem>(52);
                        __builder4.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(54, "List");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(55, "\r\n                        ");
                        __builder4.OpenComponent<AntDesign.BreadcrumbItem>(56);
                        __builder4.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(58, "App");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n            ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "row justify-content-center");
                    __builder3.AddMarkupContent(65, "\r\n                ");
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "site-layout-content col-12");
                    __builder3.AddMarkupContent(68, "\r\n                    ");
                    __builder3.AddContent(69, 
#nullable restore
#line 28 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\MainLayout.razor"
                     Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(70, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenComponent<AntDesign.Footer>(74);
                __builder2.AddAttribute(75, "Style", "text-align: center; ");
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(77, "Mamas Rezepte ©2020 Created by Lukas");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n\r\n    ");
            __builder.AddMarkupContent(80, @"<style>
        .site-layout-content {
            background: #fff;
            padding: 24px;
            max-width: 800px;
        }

        .logo {
            width: 120px;
            height: 31px;
            background: rgba(255, 255, 255, 0.2);
            margin: 16px 24px 16px 0;
            float: left;
        }
    </style>

");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
