#pragma checksum "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e5827610397b34f949e8770ee6084efbab8d12"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazerMovies.Shared
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
    public partial class TopBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navspacing border-bottom");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "nav justify-content-left");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<li class=\"nav-item\">\r\n            <img src=\"img/Star_Wars.svg\" width=\"83px;\" height=\"37px\">\r\n        </li>\r\n        ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "nav-item");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "id", "films");
            __builder.AddAttribute(12, "class", "nav-link" + " " + (
#nullable restore
#line 12 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor"
                                           underlineFilms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor"
                                                                     NavigationToFilm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Filme");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "id", "characters");
            __builder.AddAttribute(22, "class", "nav-link" + " " + (
#nullable restore
#line 15 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor"
                                                underlineCharacter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor"
                                                                              NavigationToCharacters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Charaktere");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "id", "planets");
            __builder.AddAttribute(32, "class", "nav-link" + " " + (
#nullable restore
#line 18 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor"
                                             underlinePlants

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor"
                                                                        NavigationToPlants

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Planeten");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\TopBar.razor"
       
    private string underlinePlants;
    private string underlineCharacter;
    private string underlineFilms;

    protected override void OnInitialized()
    {

       
        
    }
 
    public void Dispose()
    {    
    }

    private void DeactiveAll()
    {
        underlinePlants = underlineCharacter = underlineFilms = "";


    }
    public void NavigationToFilm()
    {
        DeactiveAll();

        underlineFilms = "underline";
        navigation.NavigateTo("/films");
    }
    public void NavigationToCharacters()
    {
        DeactiveAll();
        underlineCharacter = "underline";
        navigation.NavigateTo("/people");
    }
    public void NavigationToPlants()
    {
        DeactiveAll();
        underlinePlants = "underline";
        navigation.NavigateTo("/planets");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
#pragma warning restore 1591
