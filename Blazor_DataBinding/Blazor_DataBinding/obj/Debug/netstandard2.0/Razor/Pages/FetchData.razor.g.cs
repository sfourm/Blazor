#pragma checksum "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e59bd5ba20ffd8048bbae27dff9d51338cc8bfd8"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_DataBinding.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\_Imports.razor"
using Blazor_DataBinding;

#line default
#line hidden
#line 7 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\_Imports.razor"
using Blazor_DataBinding.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#line 8 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#line 11 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#line 24 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#line 27 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#line 28 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#line 29 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#line 30 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#line 32 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
            }

#line default
#line hidden
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#line 35 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 37 "C:\Users\samue\Documents\GitHub\Blazor\Blazor_DataBinding\Blazor_DataBinding\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
