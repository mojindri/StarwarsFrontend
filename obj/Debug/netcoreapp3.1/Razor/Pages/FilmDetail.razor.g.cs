#pragma checksum "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51641fc1c4252f7cef56fe74ecdb63f1c801bb9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/films/{filmid:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmdetail/{filmid:int}")]
    public partial class FilmDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h6 class=\"titledetail text-center\">Filmdetails</h6>\r\n<hr style=\"width: 30px; text-align: center\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "flex-fill text-center");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "h1");
            __builder.OpenElement(5, "strong");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                  film!=null? film.Title:"" 

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "details mt-5 d-flex flex-wrap flex-");
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
     if (@film == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 19 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
    }
    else
    {



#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, "<h3><strong>Details:</strong></h3>\r\n                ");
            __builder.AddMarkupContent(22, "<strong>Title: </strong> ");
            __builder.AddContent(23, 
#nullable restore
#line 27 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                          film.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, " <br>\r\n                ");
            __builder.AddMarkupContent(25, "<strong>Produtzenten: </strong> ");
            __builder.AddContent(26, 
#nullable restore
#line 28 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                                 film.Producer

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "<br>\r\n                ");
            __builder.AddMarkupContent(28, "<strong>Erscheinungsdatum: </strong> ");
            __builder.AddContent(29, 
#nullable restore
#line 29 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                                      film.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "<br><br>\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "width:100%;text-align:justify;");
            __builder.AddContent(33, 
#nullable restore
#line 30 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                                             film.OpeningCrawl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "<br>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<div class=\"col\">\r\n                <img src=\"img/Star_Wars.svg\" class=\"ml-auto  \" style=\" height: auto;width: 100%; \">\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 37 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
             if (people != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.AddMarkupContent(41, "<h3><strong>Characters: </strong></h3>\r\n");
#nullable restore
#line 40 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                foreach (var item in people)
                {


#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "infobox btn-outline-light btn");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                                                           ()=> NavigateTo(item.Url)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "strong");
            __builder.AddAttribute(48, "class", "infoxboxtext");
            __builder.AddContent(49, 
#nullable restore
#line 44 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 46 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                ");
            __builder.AddMarkupContent(53, "<div class=\"infobox btn-outline-light btn\">\r\n                    <strong class=\"infoxboxtext\">...</strong>\r\n                </div>\r\n");
#nullable restore
#line 50 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "            <br>\r\n            <br>\r\n");
#nullable restore
#line 53 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
             if (planets != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                ");
            __builder.AddMarkupContent(56, "<h3> <strong>Planets: </strong></h3>\r\n");
#nullable restore
#line 56 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                foreach (var item in planets)
                {


#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "infobox btn-outline-light btn");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                                                           ()=> NavigateTo(item.Url)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "strong");
            __builder.AddAttribute(63, "class", "infoxboxtext");
            __builder.AddContent(64, 
#nullable restore
#line 60 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 62 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                ");
            __builder.AddMarkupContent(68, "<div class=\"infobox btn-outline-light btn\">\r\n                    <strong class=\"infoxboxtext\">...</strong>\r\n                </div>\r\n");
#nullable restore
#line 66 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 68 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\FilmDetail.razor"
      


    [Parameter]
    public int FilmId { get; set; }
    public Film film;
    public ICollection<Person> people;
    public ICollection<Planet> planets;

    protected override async void OnInitialized()
    {


        film = await filmService.GetById(FilmId);
        people = new List<Person>();
        planets = new List<Planet>();
        //NOT OPTIMAL, DUE TO IILOGICAL SERVER API STRUCTURE
        foreach (var person in film.Characters.Take(5).ToArray())
        {
            people.Add(await characterService.GetByUrl(person));
        }
        foreach (var item in film.Planets.Take(5).ToArray())
        {
            planets.Add(await planetService.GetByUrl(item));
        }
      
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Repository<Planet> planetService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Repository<Person> characterService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Repository<Film> filmService { get; set; }
    }
}
#pragma warning restore 1591
