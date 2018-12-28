#pragma checksum "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd590ee76ed13b8f898804b9ecfc6963a9df5e1b"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Dashboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using Blazor_Dashboard;
    using Blazor_Dashboard.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\n\n");
#line 8 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\FetchData.cshtml"
 if (forecasts == null)
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#line 11 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\FetchData.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(4, "    ");
            builder.OpenElement(5, "table");
            builder.AddAttribute(6, "class", "table");
            builder.AddContent(7, "\n        ");
            builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            builder.OpenElement(9, "tbody");
            builder.AddContent(10, "\n");
#line 24 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\FetchData.cshtml"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            builder.AddContent(11, "                ");
            builder.OpenElement(12, "tr");
            builder.AddContent(13, "\n                    ");
            builder.OpenElement(14, "td");
            builder.AddContent(15, forecast.Date.ToShortDateString());
            builder.CloseElement();
            builder.AddContent(16, "\n                    ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, forecast.TemperatureC);
            builder.CloseElement();
            builder.AddContent(19, "\n                    ");
            builder.OpenElement(20, "td");
            builder.AddContent(21, forecast.TemperatureF);
            builder.CloseElement();
            builder.AddContent(22, "\n                    ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, forecast.Summary);
            builder.CloseElement();
            builder.AddContent(25, "\n                ");
            builder.CloseElement();
            builder.AddContent(26, "\n");
#line 32 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\FetchData.cshtml"
            }

#line default
#line hidden
            builder.AddContent(27, "        ");
            builder.CloseElement();
            builder.AddContent(28, "\n    ");
            builder.CloseElement();
            builder.AddContent(29, "\n");
#line 35 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\FetchData.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 37 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\FetchData.cshtml"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
