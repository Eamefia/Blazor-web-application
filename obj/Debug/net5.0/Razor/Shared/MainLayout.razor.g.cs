#pragma checksum "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274f8f69bdd73ebc4f96ed5339504891695f5442"
// <auto-generated/>
#pragma warning disable 1591
namespace Scycare.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Scycare.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Scycare.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\_Imports.razor"
using Scycare.Web.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-cvvd4a7xko");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-cvvd4a7xko");
            __builder.AddMarkupContent(6, @"<header class=""header mx-0"" b-cvvd4a7xko><div class=""header__left"" b-cvvd4a7xko><div class=""logo"" b-cvvd4a7xko><img src=""Logo.png"" alt=""Scynett"" b-cvvd4a7xko></div></div>
               <div class=""header__right"" b-cvvd4a7xko><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-bell"" viewBox=""0 0 16 16"" b-cvvd4a7xko><path d=""M8 16a2 2 0 0 0 2-2H6a2 2 0 0 0 2 2zM8 1.918l-.797.161A4.002 4.002 0 0 0 4 6c0 .628-.134 2.197-.459 3.742-.16.767-.376 1.566-.663 2.258h10.244c-.287-.692-.502-1.49-.663-2.258C12.134 8.197 12 6.628 12 6a4.002 4.002 0 0 0-3.203-3.92L8 1.917zM14.22 12c.223.447.481.801.78 1H1c.299-.199.557-.553.78-1C2.68 10.2 3 6.88 3 6c0-2.42 1.72-4.44 4.005-4.901a1 1 0 1 1 1.99 0A5.002 5.002 0 0 1 13 6c0 .88.32 4.2 1.22 6z"" b-cvvd4a7xko></path></svg>
                 <div class=""header__right__ui"" b-cvvd4a7xko><p b-cvvd4a7xko>ME</p></div>
                 <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-chevron-down"" viewBox=""0 0 16 16"" b-cvvd4a7xko><path fill-rule=""evenodd"" d=""M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z"" b-cvvd4a7xko></path></svg></div></header>
        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "main__items");
            __builder.AddAttribute(9, "b-cvvd4a7xko");
            __builder.OpenComponent<Scycare.Web.Shared.Sidebar>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n              ");
#nullable restore
#line 26 "C:\Users\hello\Desktop\Projects\ScycareProject\Scycare.Web\Shared\MainLayout.razor"
__builder.AddContent(12, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenComponent<Scycare.Web.Shared.Footer>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
