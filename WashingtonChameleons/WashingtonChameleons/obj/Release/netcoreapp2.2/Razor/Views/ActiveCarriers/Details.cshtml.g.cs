#pragma checksum "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66f925a659e04fa96888e7a5285096f17057bd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActiveCarriers_Details), @"mvc.1.0.view", @"/Views/ActiveCarriers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ActiveCarriers/Details.cshtml", typeof(AspNetCore.Views_ActiveCarriers_Details))]
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
#line 1 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\_ViewImports.cshtml"
using WashingtonChameleons;

#line default
#line hidden
#line 2 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\_ViewImports.cshtml"
using WashingtonChameleons.Models;

#line default
#line hidden
#line 1 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66f925a659e04fa96888e7a5285096f17057bd9", @"/Views/ActiveCarriers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21448ec97ced842455ecba56ea55ebf972259fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_ActiveCarriers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WashingtonChameleons.Models.ActiveCarriers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(179, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Mapquest", async() => {
                BeginContext(200, 204, true);
                WriteLiteral("\r\n\r\n    <script src=\"https://api.mqcdn.com/sdk/mapquest-js/v1.3.2/mapquest.js\"></script>\r\n    <link type=\"text/css\" rel=\"stylesheet\" href=\"https://api.mqcdn.com/sdk/mapquest-js/v1.3.2/mapquest.css\" />\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(407, 72, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>Details - <span class=\"text-primary\">");
            EndContext();
            BeginContext(480, 41, false);
#line 18 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(521, 798, true);
            WriteLiteral(@"</span></h1>
    <h4>Active Carriers</h4>
    <hr />
        <table class=""table table-striped"">
            <thead class=""thead-dark"">
                <tr>
                    <th colspan=""6"" class=""text-center"" style=""width: 24rem"">Active Carrier</th>

                </tr>
                <tr>
                    <th style=""width: 5rem"">Dot Number</th>
                    <th style=""width: 10rem"">Current Name</th>
                    <th style=""width: 15rem"">Address</th>
                    <th style=""width: 10rem"">Date Registered</th>
                    <th style=""width: 10rem"">Contact Info</th>
                    <th style=""width: 5rem"">Driver Total</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
            EndContext();
            BeginContext(1320, 41, false);
#line 38 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.DotNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1393, 41, false);
#line 39 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1466, 41, false);
#line 40 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Phystreet));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1510, 39, false);
#line 40 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                                                               Write(Html.DisplayFor(model => model.Phycity));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1552, 40, false);
#line 40 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                                                                                                         Write(Html.DisplayFor(model => model.Phystate));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1594, 38, false);
#line 40 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                                                                                                                                                   Write(Html.DisplayFor(model => model.Phyzip));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1664, 39, false);
#line 41 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.AddDate));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1761, 41, false);
#line 43 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 58, true);
            WriteLiteral("\r\n                        <br />\r\n                        ");
            EndContext();
            BeginContext(1861, 44, false);
#line 45 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1959, 43, false);
#line 47 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                   Write(Html.DisplayFor(model => model.DriverTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 230, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <div id=\"map\" style=\"height: 25rem\">\r\n\r\n                    </div>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(2232, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f66f925a659e04fa96888e7a5285096f17057bd910931", async() => {
                BeginContext(2254, 45, true);
                WriteLiteral("<button class=\"btn btn-primary\">Back</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2303, 30, true);
            WriteLiteral("\r\n        </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2351, 116, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n\r\n        $(document).ready(function () {\r\n\r\n            L.mapquest.key = \'");
                EndContext();
                BeginContext(2468, 43, false);
#line 68 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                         Write(Configuration.GetSection("API")["Mapquest"]);

#line default
#line hidden
                EndContext();
                BeginContext(2511, 142, true);
                WriteLiteral("\';\r\n\r\n            // \'map\' refers to a <div> element with the ID map\r\n            var map = L.mapquest.map(\'map\', {\r\n                center: [");
                EndContext();
                BeginContext(2654, 40, false);
#line 72 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
                EndContext();
                BeginContext(2694, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(2697, 41, false);
#line 72 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                                                               Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
                EndContext();
                BeginContext(2738, 147, true);
                WriteLiteral("],\r\n                layers: L.mapquest.tileLayer(\'hybrid\'),\r\n                zoom: 12\r\n            });\r\n\r\n\r\n                L.mapquest.textMarker([");
                EndContext();
                BeginContext(2886, 40, false);
#line 78 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
                EndContext();
                BeginContext(2926, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(2929, 41, false);
#line 78 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                                                                             Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
                EndContext();
                BeginContext(2970, 29, true);
                WriteLiteral("], {\r\n                text: `");
                EndContext();
                BeginContext(3000, 41, false);
#line 79 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Details.cshtml"
                  Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
                EndContext();
                BeginContext(3041, 341, true);
                WriteLiteral(@"`,
                subtext: '',
                position: 'right',
                type: 'marker',
                    icon: {
                    primaryColor: '#333333',
                    secondaryColor: '#333333',
                    size: 'sm'
                }
            }).addTo(map);


        });

    </script>

");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WashingtonChameleons.Models.ActiveCarriers> Html { get; private set; }
    }
}
#pragma warning restore 1591
