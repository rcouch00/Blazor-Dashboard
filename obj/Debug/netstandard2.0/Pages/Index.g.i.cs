#pragma checksum "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40035e641935970bc0f1825ba079d842599b3578"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    using ChartMan;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/dashboard1")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 207 "C:\Users\ryan.couch\Google Drive\Code\Project420\Blazor-Dashboard\Pages\Index.cshtml"
            


        //[CascadingParameter (Name = "UserPermissions")] protected ThemeInfo ThemeInfo { get; set; }
        //[CascadingParameter (Name = "TitleValue")] protected string Title { get; set; }
        //[CascadingParameter (Name = "RectangleValue")] protected Rectangle rectParam { get; set; }

        private int Counter = 1;

        void ChildFiredEvent(int counter)
        {
            Counter = counter;
            StateHasChanged();
        }
    

#line default
#line hidden
    }
}
#pragma warning restore 1591
