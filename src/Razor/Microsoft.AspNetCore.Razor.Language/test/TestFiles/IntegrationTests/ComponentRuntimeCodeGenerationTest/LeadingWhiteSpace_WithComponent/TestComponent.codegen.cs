// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Test.SomeOtherComponent>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(2, "h1");
                __builder2.AddContent(3, "Child content at ");
                __builder2.AddContent(4, 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                          DateTime.Now

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "p");
                __builder2.AddContent(7, "Very ");
                __builder2.AddContent(8, 
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
              "good"

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.AddMarkupContent(10, "<h1>Hello</h1>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
