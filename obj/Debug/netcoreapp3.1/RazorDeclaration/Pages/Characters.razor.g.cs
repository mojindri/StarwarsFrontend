#pragma checksum "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Pages\Characters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de903827a794c9c0799bae9605b264e0bf00f4d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
