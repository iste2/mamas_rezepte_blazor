#pragma checksum "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef60c2d952387d4e90526d4ab7b2b008821c297"
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
#line 3 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
using State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
using Const;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
using MamasRezepte.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editor")]
    public partial class Editor : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"padding-top: 32px; \"></div>\r\n\r\n");
#nullable restore
#line 18 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
 if (State.FEditorMode == EditorMode.Create)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h1 style=\"margin-bottom:12px; font-weight:bold;\">Neues Rezept</h1>\r\n");
#nullable restore
#line 21 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
}
else if (State.FEditorMode == EditorMode.Edit)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<h1 style=\"margin-bottom:12px; font-weight:bold;\">Rezept bearbeiten</h1>\r\n");
#nullable restore
#line 25 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
}


#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "class", "row g-3");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<label for=\"inputName\" class=\"form-label\">Name</label>\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "id", "inputName");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                       State.FRecipe.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => State.FRecipe.Name = __value, State.FRecipe.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-12");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, "<label for=\"inputSubtitle\" class=\"form-label\">Kurzbeschreibung</label>\r\n        ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "id", "inputSubtitle");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                       State.FRecipe.Subtitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => State.FRecipe.Subtitle = __value, State.FRecipe.Subtitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-12");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<label for=\"inputDuration\" class=\"form-label\">Zubereitungsdauer</label>\r\n        ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "id", "inputDuration");
            __builder.AddAttribute(38, "class", "form-select");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                        State.FRecipe.DurationCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => State.FRecipe.DurationCategoryId = __value, State.FRecipe.DurationCategoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "0");
            __builder.AddAttribute(44, "selected", true);
            __builder.AddContent(45, "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 46 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
             if (FDurationCategories != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                 foreach (var hDurationCategory in FDurationCategories)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                    ");
            __builder.OpenElement(48, "option");
            __builder.AddAttribute(49, "value", 
#nullable restore
#line 50 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                                    hDurationCategory.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(50, 
#nullable restore
#line 50 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                                                           hDurationCategory.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 51 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-12");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.AddMarkupContent(58, "<label for=\"inputTags\" class=\"form-label\">Tags: </label>\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "input-group");
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                              SubmitNewTag

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(65, "id", "button-addon1");
            __builder.AddContent(66, "Button");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "list", "datalistOptions");
            __builder.AddAttribute(71, "id", "inputTags");
            __builder.AddAttribute(72, "placeholder", "...");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                           FCurrentTag

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FCurrentTag = __value, FCurrentTag));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "datalist");
            __builder.AddAttribute(77, "id", "datalistOptions");
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 74 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                 if (FTags != null)
                {
                    var hTags = FCurrentTag != null && FCurrentTag != "" ? FTags.Where(_ => _.Name.Contains(FCurrentTag)).Take(5) : FTags.Take(5);
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                     foreach (var hTag in hTags)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                        ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", 
#nullable restore
#line 79 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                                        hTag.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
#nullable restore
#line 80 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                     

                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-12");
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 88 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
         foreach (var hTag in FSelectedTags)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "            ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "badge rounded-pill bg-secondary");
            __builder.AddContent(93, 
#nullable restore
#line 90 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                                                          hTag.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 91 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col-12");
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.AddMarkupContent(100, "<label for=\"inputPersons\" class=\"form-label\">Anzahl Personen</label>\r\n        ");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "type", "number");
            __builder.AddAttribute(103, "class", "form-control");
            __builder.AddAttribute(104, "id", "inputPersons");
            __builder.AddAttribute(105, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                       State.FRecipe.NumberOfPersons

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => State.FRecipe.NumberOfPersons = __value, State.FRecipe.NumberOfPersons, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n    ");
            __builder.AddMarkupContent(109, @"<div class=""col-12"">
        <div class=""row"">
            <label for=""inputAmount"" class=""form-label"">Zutaten: </label>
            <div class=""col-2"">
                <label for=""inputAmount"" class=""form-label"">Menge</label>
                <input type=""number"" class=""form-control"" id=""inputAmount"">
            </div>
            <div class=""col-2"">
                <label for=""inputUnit"" class=""form-label"">Einheit</label>
                <input type=""text"" class=""form-control"" id=""inputUnit"">
            </div>
            <div class=""col-8"">
                <label for=""inputProduct"" class=""form-label"">Zutat</label>
                <input class=""form-control"" list=""datalistOptions"" id=""inputProduct"" placeholder=""Type to search..."">
                <datalist id=""datalistOptions"">
                    <option value=""San Francisco""></option>
                    <option value=""New York""></option>
                    <option value=""Seattle""></option>
                    <option value=""Los Angeles""></option>
                    <option value=""Chicago""></option>
                </datalist>
            </div>
        </div>
    </div>
    ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col-12");
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.OpenElement(113, "ul");
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 127 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
             foreach (var hIngredient in State.FRecipe.Ingredients)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                ");
            __builder.OpenElement(116, "li");
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.AddContent(118, 
#nullable restore
#line 130 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                      hIngredient.Amount + " " + hIngredient.Unit + " " + hIngredient.Product.Name + " "

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.AddMarkupContent(120, "<a><i class=\"fa fa-plus-circle fs-3\"></i></a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
#nullable restore
#line 133 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(122, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n\r\n    ");
            __builder.AddMarkupContent(125, "<div class=\"col-12\">\r\n        <label for=\"inputInstruction\" class=\"form-label\">Zubereitung</label>\r\n        <textarea class=\"form-control\" id=\"inputInstruction\" rows=\"8\"></textarea>\r\n    </div>\r\n    ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-12");
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.AddMarkupContent(129, "<label for=\"inputImages\" class=\"form-label\">Bilder</label>\r\n        ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "dropzone");
            __builder.AddAttribute(132, "id", "inputImages");
            __builder.AddMarkupContent(133, "\r\n            ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(134);
            __builder.AddAttribute(135, "multiple", true);
            __builder.AddAttribute(136, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 145 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                                          DragDropOnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(137, "\r\n            Bilder hochladen\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.OpenElement(139, "ul");
            __builder.AddAttribute(140, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 149 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
             foreach (var hImage in State.FRecipe.Images)
            {
                var hImageSource = $"data:image/jpeg;base64,{ hImage.ImageData }";

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "                ");
            __builder.OpenElement(143, "li");
            __builder.AddAttribute(144, "class", "list-group-item");
            __builder.AddAttribute(145, "style", "margin-top:6px;");
            __builder.AddMarkupContent(146, "\r\n                    ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "row align-items-center");
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.OpenElement(150, "img");
            __builder.AddAttribute(151, "src", 
#nullable restore
#line 154 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                                   hImageSource

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(152, "class", "col-3");
            __builder.AddAttribute(153, "alt", "image");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n                        ");
            __builder.OpenElement(155, "button");
            __builder.AddAttribute(156, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 155 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
                                            () => DeleteImage(@hImage.ImageData)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(157, "type", "button");
            __builder.AddAttribute(158, "class", "btn btn-outline-danger col-3");
            __builder.AddMarkupContent(159, "<i class=\"fa fa-trash fs-3\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n");
#nullable restore
#line 158 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(163, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n            \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n\r\n<div class style=\"margin-bottom:32px;\"></div>\r\n\r\n");
            __builder.AddMarkupContent(167, @"<style>

    .dropzone {
        border: 3px dashed orangered;
        padding: 3rem;
        display: flex;
        align-items: center;
        justify-content: center;
        background-color: #eee;
        box-shadow: inset 0 0 8px rgba(0,0,0,0.2);
        color: #444;
        font-size: 1.5rem;
        cursor: pointer;
        position: relative;
    }

        .dropzone:hover {
            background-color: #f3f3f3;
            color: #333;
            border: 3px dashed orange;
        }

        .dropzone input[type=file] {
            position: absolute;
            width: 100%;
            height: 100%;
            opacity: 0;
            cursor: pointer;
        }

    .dropzone-drag {
        background-color: palegreen;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 202 "F:\Programmieren\dotnet\mamas_rezepte_blazor\MamasRezepte\Client\Pages\Editor.razor"
       

    private List<DurationCategory> FDurationCategories { get; set; }

    private string FCurrentTag { get; set; }
    private List<Tag> FTags { get; set; }
    private List<Tag> FSelectedTags => State.FRecipe.Tags.Select(_ => _.Tag).ToList();


    protected override void OnInitialized()
    {
        State.UpdateEditorMode();
        State.OnChange += StateHasChanged;
    }

    protected override async Task OnInitializedAsync()
    {
        FDurationCategories =
            await Http.GetFromJsonAsync<List<DurationCategory>>(Path.Combine(Nav.BaseUri, "api/DurationCategories"));

        FTags =
            await Http.GetFromJsonAsync<List<Tag>>(Path.Combine(Nav.BaseUri, "api/Tags/ByUsageFrequency"));
    }

    public void SubmitNewTag()
    {
        Console.WriteLine("Submitting new tag.");

        var hTag = FTags.FirstOrDefault(_ => _.Name == FCurrentTag);
        if(hTag == null)
        {
            hTag = new Tag { Name = FCurrentTag };
        }
        State.FRecipe.Tags.ToList().Append(new RecipeToTagRelation() { Tag = hTag });

        FCurrentTag = "";

        State.OnChange += StateHasChanged;
        State.NotifyStateChanged();
        this.StateHasChanged();
    }

    public async Task DragDropOnChange(IFileListEntry[] _Files)
    {
        foreach (var hFile in _Files)
        {
            var hMemStream = new System.IO.MemoryStream();
            await hFile.Data.CopyToAsync(hMemStream);
            var hImageBytes = hMemStream.ToArray();
            var hBase64String = Convert.ToBase64String(hImageBytes);
            State.FRecipe.Images = State.FRecipe.Images.ToList().Append(new RecipeImage { ImageData = hBase64String });
        }

        State.OnChange += StateHasChanged;
        State.NotifyStateChanged();
        this.StateHasChanged();

        Console.WriteLine("Images: " + State.FRecipe.Images.Count());
    }

    public void DeleteImage(string hImageData)
    {

        State.FRecipe.Images = State.FRecipe.Images.ToList().Where(_ => _.ImageData.Substring(0, 100).GetHashCode() != hImageData.Substring(0, 100).GetHashCode());

        State.OnChange += StateHasChanged;
        State.NotifyStateChanged();
        this.StateHasChanged();

        Console.WriteLine("Images: " + State.FRecipe.Images.Count());
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataStateEditor State { get; set; }
    }
}
#pragma warning restore 1591
