#pragma checksum "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343c537b7f20684f5454f3d00ff25a16d59edbb5"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, currentCount);
            builder.CloseElement();
            builder.AddContent(4, "\n                                                                      \n\n\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(IncrementCount));
            builder.AddContent(8, "Click me");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 11 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\Counter.cshtml"
            
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
