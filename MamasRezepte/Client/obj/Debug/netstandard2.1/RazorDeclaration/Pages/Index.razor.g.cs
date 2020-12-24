#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626c90f8a3770be371ac10f1b88989cf16e58df1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Index.razor"
       

    private IEnumerable<Recipe> FFeed { get; set; }
    private IEnumerable<Category> FCategories { get; set; }
    private IEnumerable<Tag> FTags { get; set; }
    private IEnumerable<DurationCategory> FDurationCategories { get; set; }

    private Filter FFilter { get; set; }
    private string FSearch { get; set; }

    private bool FFilterCollapsed { get; set; } = true;

    protected override void OnInitialized()
    {
        State.OnChange += StateHasChanged;
    }

    protected override async Task OnInitializedAsync()
    {
        await LoadFeed();

        FCategories = (await Http.GetFromJsonAsync<IEnumerable<Category>>(Path.Combine(Nav.BaseUri, "api/categories/")))
        .OrderBy(_ => _.Name);

        FTags = (await Http.GetFromJsonAsync<IEnumerable<Tag>>(Path.Combine(Nav.BaseUri, "api/Tags/ByUsageFrequency")))
            .OrderBy(_ => _.Name)
            .Take(15);

        FDurationCategories = await Http.GetFromJsonAsync<IEnumerable<DurationCategory>>(Path.Combine(Nav.BaseUri, "api/durationcategories/"));

        FFilter = new Filter();
    }

    private async Task LoadFeed()
    {
        if(State.FFilter.IsEmpty())
        {
            FFeed = (await Http.GetFromJsonAsync<IEnumerable<Recipe>>(Path.Combine(Nav.BaseUri, "api/recipes/feed")))
                .OrderByDescending(_ => FeedCalculator.CalculateScore(_.Clicks.ToList())).ToList();
        } else
        {
            FFeed = (await Http.GetFromJsonAsync<IEnumerable<Recipe>>(Path.Combine(Nav.BaseUri, "api/recipes")))
                .ToList()
                .Where(_ => _.Name.Contains(State.FFilter.FSearch)
                    || State.FFilter.FCategories.Any(_0 => _.Category.Name == _0.Name)
                    || State.FFilter.FDurationCategories.Any(_0 => _.DurationCategory.Name == _0.Name)
                    || State.FFilter.FTags.Select(_0 => _0.Name).Any(_0 => _.Tags.Select(_1 => _1.Tag.Name).Contains(_0)))
                //.Where(_ => _.Name.Contains(State.FFilter.FSearch))
                .ToList();
        }

        this.StateHasChanged();
    }

    private async Task EditFilter(object _Object)
    {
        if (!FFilter.Contains(_Object))
        {
            FFilter.AddToFilter(_Object);
        }
        else
        {
            FFilter.RemoveFromFilter(_Object);
        }

        State.UpdateFilter(FFilter);

        LoadFeed();

        State.OnChange += StateHasChanged;
        State.NotifyStateChanged();
        this.StateHasChanged();
    }

    private async Task ClearSearch()
    {
        FFilter.ClearFilter();
        FSearch = "";

        State.UpdateFilter(FFilter);

        LoadFeed();

        State.OnChange += StateHasChanged;
        State.NotifyStateChanged();
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
