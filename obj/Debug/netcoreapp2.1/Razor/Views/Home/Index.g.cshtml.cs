#pragma checksum "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e00d02d151ae63a85fcf650c3453a8a44b28315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\_ViewImports.cshtml"
using Komis.Core.Models;

#line default
#line hidden
#line 3 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\_ViewImports.cshtml"
using Komis.Core.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e00d02d151ae63a85fcf650c3453a8a44b28315", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3238407f003510a52dd55a14ac883d5d3a50288b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 7, true);
            WriteLiteral("\r\n<h2> ");
            EndContext();
            BeginContext(30, 11, false);
#line 3 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(41, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
 foreach (var car in Model.CarList)
{

#line default
#line hidden
            BeginContext(90, 95, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 185, "\"", 208, 1);
#line 9 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
WriteAttributeValue("", 191, car.ThumbnailURL, 191, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(209, 84, true);
            WriteLiteral(" alt=\"\">\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(294, 23, false);
#line 11 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                                  Write(car.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(317, 48, true);
            WriteLiteral("</h3>\r\n                <h3>\r\n                   ");
            EndContext();
            BeginContext(365, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6b82c9923d4498da00ba8fc8d6a5ba3", async() => {
                BeginContext(435, 9, false);
#line 13 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                                                                                   Write(car.Brand);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                                                                   WriteLiteral(car.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(448, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(452, 9, false);
#line 13 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                                                                                                    Write(car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(461, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(465, 20, false);
#line 13 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                                                                                                                 Write(car.YearOfProduction);

#line default
#line hidden
            EndContext();
            BeginContext(485, 78, true);
            WriteLiteral("\r\n                </h3>\r\n                <h4>\r\n                    Przebieg : ");
            EndContext();
            BeginContext(564, 10, false);
#line 16 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                          Write(car.Milage);

#line default
#line hidden
            EndContext();
            BeginContext(574, 79, true);
            WriteLiteral("\r\n                </h4>\r\n                <h4>\r\n                    Pojemność : ");
            EndContext();
            BeginContext(654, 12, false);
#line 19 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                           Write(car.Capacity);

#line default
#line hidden
            EndContext();
            BeginContext(666, 73, true);
            WriteLiteral("\r\n                </h4>\r\n                <h4>\r\n                    Moc : ");
            EndContext();
            BeginContext(740, 9, false);
#line 22 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                     Write(car.Power);

#line default
#line hidden
            EndContext();
            BeginContext(749, 44, true);
            WriteLiteral("\r\n                </h4>\r\n                <p>");
            EndContext();
            BeginContext(794, 15, false);
#line 24 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
              Write(car.Description);

#line default
#line hidden
            EndContext();
            BeginContext(809, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 28 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
