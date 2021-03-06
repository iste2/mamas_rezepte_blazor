#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2c629359a152417306b8ab882809715c9e7e671"
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
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
using MamasRezepte.Client.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
using MamasRezepte.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rezept/{FId:long}")]
    public partial class RecipeDetail : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 15 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
 if (State.FRecipe != null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "carouselExampleControls");
            __builder.AddAttribute(3, "class", "carousel slide");
            __builder.AddAttribute(4, "data-bs-ride", "carousel");
            __builder.AddAttribute(5, "style", "margin-left:-12px;margin-right:-12px;");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "carousel-inner");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 20 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
             foreach (var hImageData in State.FRecipe.Images)
            {
                var hActive = State.FRecipe.Images.FirstOrDefault() == hImageData;


#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "carousel-item" + " " + (
#nullable restore
#line 24 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                            hActive ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 25 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                $"data:image/jpeg;base64,{ hImageData.ImageData }"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "card-img-top");
            __builder.AddAttribute(17, "alt", true);
            __builder.AddAttribute(18, "style", "max-height:" + (
#nullable restore
#line 25 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                                                                                                     FSliderHeight

#line default
#line hidden
#nullable disable
            ) + "px;" + "  object-fit:cover;");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 27 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, @"<a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-bs-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </a>
        ");
            __builder.AddMarkupContent(24, @"<a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </a>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.AddContent(26, "    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "style", "margin-bottom: 12px; margin-top:12px;");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "badge rounded-pill bg-secondary");
            __builder.AddContent(32, 
#nullable restore
#line 41 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                       State.FRecipe.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "badge rounded-pill bg-secondary");
            __builder.AddContent(36, 
#nullable restore
#line 42 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                       State.FRecipe.DurationCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 43 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
         foreach (var hTag in State.FRecipe.Tags)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "badge rounded-pill bg-secondary");
            __builder.AddContent(41, 
#nullable restore
#line 45 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                           hTag.Tag.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 46 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.AddContent(45, "    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "style", "margin-bottom: 6px;margin-top:12px;");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "h1");
            __builder.AddAttribute(50, "style", "font-weight:bold;");
            __builder.AddContent(51, 
#nullable restore
#line 51 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                       State.FRecipe.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.AddContent(54, "    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "margin-bottom: 12px;");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "span");
            __builder.AddAttribute(59, "class", true);
            __builder.AddAttribute(60, "style", "color:gray; font-size:12px;");
            __builder.AddContent(61, 
#nullable restore
#line 56 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                             State.FRecipe.Clicks.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " Aufrufe  -  ");
            __builder.AddContent(63, 
#nullable restore
#line 56 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                                                                         State.FRecipe.PublishDate.Date.ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.AddContent(66, "    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "style", "margin-bottom: 16px;");
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "style", "color:gray;");
            __builder.AddContent(72, 
#nullable restore
#line 60 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                    State.FRecipe.Subtitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.AddContent(75, "    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "row justify-content-center");
            __builder.AddAttribute(78, "style", "margin-bottom: 16px;");
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.AddMarkupContent(80, "<a class=\"col text-center\" style=\"color:gray\"><i class=\"fa fa-thumbs-up fs-3\"></i></a>\r\n        ");
            __builder.AddMarkupContent(81, "<a class=\"col text-center\" style=\"color:gray\"><i class=\"fa fa-share fs-3\"></i></a>\r\n        ");
            __builder.AddMarkupContent(82, "<a class=\"col text-center\" style=\"color:gray\"><i class=\"fa fa-download fs-3\"></i></a>\r\n        ");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                       () => EditRecipe()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "class", "col text-center");
            __builder.AddAttribute(86, "style", "color:gray");
            __builder.AddMarkupContent(87, "<i class=\"fa fa-edit fs-3\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
            __builder.AddContent(90, "    ");
            __builder.AddMarkupContent(91, "<div style=\"border-top: 1px solid grey; margin-left:-12px; margin-right:-12px; margin-bottom:16px;\">\r\n    </div>\r\n");
            __builder.AddContent(92, "    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row");
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.OpenElement(96, "h3");
            __builder.AddMarkupContent(97, "Zutaten für ");
            __builder.OpenElement(98, "a");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                       () => EditNumPersons(-1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "style", "color:orange; margin:4px;");
            __builder.AddMarkupContent(101, "<i class=\"fa fa-minus\"></i>");
            __builder.CloseElement();
            __builder.AddContent(102, " ");
            __builder.AddContent(103, 
#nullable restore
#line 76 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                                                                                                     FNumPersons

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(104, " ");
            __builder.OpenElement(105, "a");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                                                                                                                                                () => EditNumPersons(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "style", "color:orange; margin:4px;");
            __builder.AddMarkupContent(108, "<i class=\"fa fa-plus\"></i>");
            __builder.CloseElement();
            __builder.AddContent(109, " Personen");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "row justify-content-center");
            __builder.AddAttribute(114, "style", "margin-bottom:32px;");
            __builder.AddMarkupContent(115, "\r\n        ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "col");
            __builder.AddMarkupContent(118, "\r\n            ");
            __builder.OpenElement(119, "ul");
            __builder.AddAttribute(120, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 81 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                 foreach (var hIngredient in State.FRecipe.Ingredients)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "                    ");
            __builder.OpenElement(123, "li");
            __builder.AddAttribute(124, "class", "list-group-item row");
            __builder.AddMarkupContent(125, "\r\n                        <div class=\"col-2\"></div>\r\n                        ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col");
            __builder.AddMarkupContent(128, "\r\n                            <input class=\"form-check-input me-1\" type=\"checkbox\" value aria-label>\r\n                            ");
            __builder.OpenElement(129, "a");
            __builder.AddContent(130, 
#nullable restore
#line 87 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                                 $"{ hIngredient.Amount * FNumPersons / State.FRecipe.NumberOfPersons  } { hIngredient.Unit } { hIngredient.Product.Name }"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n");
#nullable restore
#line 90 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(134, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n");
            __builder.AddContent(138, "    ");
            __builder.AddMarkupContent(139, "<div style=\"border-top: 1px solid grey; margin-left:-12px; margin-right:-12px; margin-bottom:16px;\">\r\n    </div>\r\n");
            __builder.AddContent(140, "    ");
            __builder.AddMarkupContent(141, "<h3>Zubereitung</h3>\r\n");
#nullable restore
#line 100 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
     foreach(var hParagraph in State.FRecipe.Instruction.Split("\n"))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "        ");
            __builder.OpenElement(143, "p");
            __builder.AddAttribute(144, "class", "text-break");
            __builder.AddContent(145, 
#nullable restore
#line 102 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
                               hParagraph

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 103 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\RecipeDetail.razor"
       

    [Parameter]
    public long FId { get; set; }

    public int FNumPersons { get; set; }
    public int FSliderHeight { get; set; } = 250;

    protected override void OnInitialized()
    {
        State.OnChange += StateHasChanged;
    }

    protected override async Task OnInitializedAsync()
    {
        // get recipe
        var hRecipe = await Http.GetFromJsonAsync<Recipe>(Path.Combine(Nav.BaseUri, "api/recipes", FId + ""));
        /*
        foreach(var hBase64 in hRecipe.Images)
        {
            byte[] hImageBytes = Convert.FromBase64String(hBase64.ImageData);
            using (var hMs = new MemoryStream(hImageBytes))
            {
                var hImage = Image.FromStream(hMs);
                FSliderHeight = Math.Min(FSliderHeight, hImage.Height);
            }
        }*/

        // add click
        await Http.PostAsJsonAsync<Click>(Path.Combine(Nav.BaseUri, "api/clicks"), new Click { RecipeId = hRecipe.Id, Time = DateTime.Now });

        State.SetRecipe(hRecipe);
        FNumPersons = hRecipe.NumberOfPersons;

        this.StateHasChanged();
    }


    public void EditNumPersons(int _Add)
    {
        FNumPersons += _Add;
        this.StateHasChanged();
    }

    public void EditRecipe()
    {
        EditorState.SetRecipe(State.FRecipe);
        Nav.NavigateTo(Path.Combine(Nav.BaseUri, "/editor"));
    }

    public void Dispose()
    {
        State.OnChange -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStateEditor EditorState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStateDetail State { get; set; }
    }
}
#pragma warning restore 1591
