#pragma checksum "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb13ecdab24bf3ea8479b8c2d07c9e70a17817e"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Condicionais.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using Blazor_Condicionais.Client;

#line default
#line hidden
#line 7 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using Blazor_Condicionais.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\_Imports.razor"
using Blazor_Condicionais.Shared.Entidades;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#line 5 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 7 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_Condicionais\Blazor_Condicionais\Client\Pages\Counter.razor"
       
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
