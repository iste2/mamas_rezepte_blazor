#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01240396c55d699ec2883d7b2cdae492f0f4aaa2"
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
#line 2 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
using Const;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
using MamasRezepte.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
using MamasRezepte.Client.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
using MamasRezepte.Client.Helper;

#line default
#line hidden
#nullable disable
    public partial class Masonry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Shared\Masonry.razor"
       

    [Parameter]
    public IEnumerable<Recipe> FElements { get; set; }

    //[Parameter]
    //public IEnumerable<RecipeImage> FImages { get; set; }

    [Parameter]
    public int FNumCols { get; set; }

    public int FScreenWidth { get; set; } = 0;

    protected override async Task OnInitializedAsync()
    {
        var hDimension = await BrowserService.GetDimensions();
        FScreenWidth = hDimension.Width;
        
    }

    public int ColumnCount()
    {
        if(FScreenWidth <= 540)
        {
            return 1;
        } else if(FScreenWidth <= 720)
        {
            return 2;
        } else
        {
            return 3;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BrowserService BrowserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStateMain State { get; set; }
    }
}
#pragma warning restore 1591
