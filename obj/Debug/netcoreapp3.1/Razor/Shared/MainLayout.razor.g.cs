#pragma checksum "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e41e2c4d4fd857cd1484911da8d64df89745602"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenComponent<BlazerMovies.Shared.TopBar>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "C:\Users\mo ji\source\repos\BlazerMovies\BlazerMovies\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
