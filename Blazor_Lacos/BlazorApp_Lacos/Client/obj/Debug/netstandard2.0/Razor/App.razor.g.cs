#pragma checksum "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5760763b9b9a4230bcc57d90540e9f5b9fa81a79"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Lacos.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using BlazorApp_Lacos.Client;

#line default
#line hidden
#line 7 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using BlazorApp_Lacos.Client.Shared;

#line default
#line hidden
#line 8 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using BlazorApp_Lacos.Client.Classes;

#line default
#line hidden
#line 9 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\_Imports.razor"
using BlazorApp_Lacos.Shared.Entidades;

#line default
#line hidden
    public class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 1 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#line 3 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\App.razor"
                               routeData

#line default
#line hidden
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 3 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                __builder2.AddAttribute(11, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 6 "C:\_blazor\BlazorApp_Lacos\BlazorApp_Lacos\Client\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.AddMarkupContent(14, "<p>Sorry, there\'s nothing at this address.</p>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
