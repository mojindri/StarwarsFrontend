#pragma checksum "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de903827a794c9c0799bae9605b264e0bf00f4d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazerMovies.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using BlazerMovies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using BlazerMovies.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using BlazerMovies.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using BlazerMovies.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\_Imports.razor"
using BlazerMovies.helper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/characters")]
    public partial class Characters : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"
 if (people == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<p class=\"title\">Charaktere</p>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex justify-content-start flex-wrap p-2");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 17 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"
             foreach (Person item in people)
            {


#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "class", "card-img-top");
            __builder.AddAttribute(15, "src", "/img/Star_Wars.svg");
            __builder.AddAttribute(16, "alt", 
#nullable restore
#line 21 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"
                                                                             item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "h4");
            __builder.AddAttribute(22, "class", "card-title");
            __builder.AddContent(23, 
#nullable restore
#line 23 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"
                                                item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n                        ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"
                                       ()=>NavigateTo(item.Url)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "href", "#");
            __builder.AddAttribute(28, "class", "card-link");
            __builder.AddContent(29, "Mehr Informationen..");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 28 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 33 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor"
       
    private ICollection<Person> people;

    protected override async Task OnInitializedAsync()
    {

        people = await filmService.GetEntities();
        
        StateHasChanged();
    }
    public void NavigateTo(string url)
    {
        navigation.NavigateTo(url.Replace(@"http://swapi.dev/api/", ""));

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunner { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Repository<Person> filmService { get; set; }
    }
}
#pragma warning restore 1591