#pragma checksum "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a16c3c5851213d780d41e976b90ed0393ea013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carriers_Details), @"mvc.1.0.view", @"/Views/Carriers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carriers/Details.cshtml", typeof(AspNetCore.Views_Carriers_Details))]
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
#line 1 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\_ViewImports.cshtml"
using ChameleonGUI;

#line default
#line hidden
#line 2 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\_ViewImports.cshtml"
using ChameleonGUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a16c3c5851213d780d41e976b90ed0393ea013", @"/Views/Carriers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3b7aed84e27477d46b9066b6b0c225924a8d1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Carriers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChameleonGUI.Models.Carriers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(82, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Carriers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(214, 45, false);
#line 14 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DotNumber));

#line default
#line hidden
            EndContext();
            BeginContext(259, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(323, 41, false);
#line 17 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.DotNumber));

#line default
#line hidden
            EndContext();
            BeginContext(364, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(427, 47, false);
#line 20 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CarrierName));

#line default
#line hidden
            EndContext();
            BeginContext(474, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(538, 43, false);
#line 23 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.CarrierName));

#line default
#line hidden
            EndContext();
            BeginContext(581, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(644, 43, false);
#line 26 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(687, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(751, 39, false);
#line 29 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(790, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(853, 45, false);
#line 32 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OosReason));

#line default
#line hidden
            EndContext();
            BeginContext(898, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(962, 41, false);
#line 35 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.OosReason));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1066, 43, false);
#line 38 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OosDate));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1173, 39, false);
#line 41 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.OosDate));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1275, 42, false);
#line 44 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1381, 38, false);
#line 47 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1482, 44, false);
#line 50 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1590, 40, false);
#line 53 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1693, 45, false);
#line 56 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1802, 41, false);
#line 59 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1890, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a16c3c5851213d780d41e976b90ed0393ea01311283", async() => {
                BeginContext(1940, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "E:\Enterprise Applications\Washington\ChameleonGUI\ChameleonGUI\Views\Carriers\Details.cshtml"
                           WriteLiteral(Model.Number);

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
            BeginContext(1948, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1956, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a16c3c5851213d780d41e976b90ed0393ea01313623", async() => {
                BeginContext(1978, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1994, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChameleonGUI.Models.Carriers> Html { get; private set; }
    }
}
#pragma warning restore 1591