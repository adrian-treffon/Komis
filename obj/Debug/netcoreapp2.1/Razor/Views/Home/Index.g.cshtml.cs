#pragma checksum "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355f486d090603b3fdd509e6c9d83339c48c7963"
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
#line 3 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\_ViewImports.cshtml"
using Komis.Core.Models;

#line default
#line hidden
#line 4 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\_ViewImports.cshtml"
using Komis.Core.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\_ViewImports.cshtml"
using Komis.Infrastructure.Commands.User;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355f486d090603b3fdd509e6c9d83339c48c7963", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a37154dd8d78dc055515e6d767960e5998e98bf", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(22, 32, true);
            WriteLiteral("\r\n<h2 style=\"margin-left:20px\"> ");
            EndContext();
            BeginContext(55, 11, false);
#line 3 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(66, 11, true);
            WriteLiteral("  </h2>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
 foreach (var car in Model.CarList)
{

#line default
#line hidden
            BeginContext(117, 106, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail img-responsive\">\r\n            ");
            EndContext();
            BeginContext(223, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dc5bda96b5240dfacdbc6a08449ea77", async() => {
                BeginContext(292, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 296, "\"", 319, 1);
#line 9 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
WriteAttributeValue("", 302, car.ThumbnailURL, 302, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(320, 34, true);
                WriteLiteral(" style=\"width:350px;height:250px\">");
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
#line 9 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
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
            BeginContext(358, 112, true);
            WriteLiteral("\r\n            <div class=\"caption center-block\">\r\n\r\n                <h3 class=\"text-center\">\r\n                  ");
            EndContext();
            BeginContext(471, 9, false);
#line 13 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
             Write(car.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(480, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(484, 9, false);
#line 13 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                          Write(car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(493, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(497, 20, false);
#line 13 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                                       Write(car.YearOfProduction);

#line default
#line hidden
            EndContext();
            BeginContext(517, 71, true);
            WriteLiteral("\r\n                </h3>\r\n\r\n                <h3 class=\"pull-right\"> <b> ");
            EndContext();
            BeginContext(589, 23, false);
#line 16 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                                       Write(car.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(612, 69, true);
            WriteLiteral(" </b> </h3>\r\n\r\n                <h4 >\r\n                    Przebieg : ");
            EndContext();
            BeginContext(682, 10, false);
#line 19 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                          Write(car.Milage);

#line default
#line hidden
            EndContext();
            BeginContext(692, 82, true);
            WriteLiteral("\r\n                </h4>\r\n\r\n                <h4 >\r\n                    Pojemność : ");
            EndContext();
            BeginContext(775, 12, false);
#line 23 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                           Write(car.Capacity);

#line default
#line hidden
            EndContext();
            BeginContext(787, 76, true);
            WriteLiteral("\r\n                </h4>\r\n\r\n                <h4 >\r\n                    Moc : ");
            EndContext();
            BeginContext(864, 9, false);
#line 27 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
                     Write(car.Power);

#line default
#line hidden
            EndContext();
            BeginContext(873, 46, true);
            WriteLiteral("\r\n                </h4>\r\n\r\n                <p>");
            EndContext();
            BeginContext(920, 15, false);
#line 30 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
              Write(car.Description);

#line default
#line hidden
            EndContext();
            BeginContext(935, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 34 "C:\Users\adria\Desktop\Kursy\.NET Core 2.1\Komis\Views\Home\Index.cshtml"
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
