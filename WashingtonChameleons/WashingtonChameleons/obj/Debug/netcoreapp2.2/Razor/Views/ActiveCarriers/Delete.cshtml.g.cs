#pragma checksum "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157518a9da3a1af75b338e8292a0e6c8e65385f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActiveCarriers_Delete), @"mvc.1.0.view", @"/Views/ActiveCarriers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ActiveCarriers/Delete.cshtml", typeof(AspNetCore.Views_ActiveCarriers_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157518a9da3a1af75b338e8292a0e6c8e65385f5", @"/Views/ActiveCarriers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21448ec97ced842455ecba56ea55ebf972259fc0", @"/Views/_ViewImports.cshtml")]
    public class Views_ActiveCarriers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WashingtonChameleons.Models.ActiveCarriers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(95, 184, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ActiveCarriers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(280, 45, false);
#line 15 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(325, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(389, 41, false);
#line 18 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(430, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(493, 43, false);
#line 21 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(536, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(600, 39, false);
#line 24 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(639, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(702, 52, false);
#line 27 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CarrierOperation));

#line default
#line hidden
            EndContext();
            BeginContext(754, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(818, 48, false);
#line 30 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CarrierOperation));

#line default
#line hidden
            EndContext();
            BeginContext(866, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(929, 42, false);
#line 33 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hmflag));

#line default
#line hidden
            EndContext();
            BeginContext(971, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1035, 38, false);
#line 36 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hmflag));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1136, 42, false);
#line 39 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pcflag));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1242, 38, false);
#line 42 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pcflag));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1343, 45, false);
#line 45 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phystreet));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1452, 41, false);
#line 48 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phystreet));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1556, 43, false);
#line 51 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phycity));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1663, 39, false);
#line 54 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phycity));

#line default
#line hidden
            EndContext();
            BeginContext(1702, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1765, 44, false);
#line 57 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phystate));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1873, 40, false);
#line 60 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phystate));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1976, 42, false);
#line 63 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phyzip));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2082, 38, false);
#line 66 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phyzip));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2183, 46, false);
#line 69 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phycountry));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2293, 42, false);
#line 72 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phycountry));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2398, 49, false);
#line 75 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MailingStreet));

#line default
#line hidden
            EndContext();
            BeginContext(2447, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2511, 45, false);
#line 78 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MailingStreet));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2619, 47, false);
#line 81 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MailingCity));

#line default
#line hidden
            EndContext();
            BeginContext(2666, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2730, 43, false);
#line 84 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MailingCity));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2836, 49, false);
#line 87 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MainlingState));

#line default
#line hidden
            EndContext();
            BeginContext(2885, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2949, 45, false);
#line 90 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MainlingState));

#line default
#line hidden
            EndContext();
            BeginContext(2994, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3057, 46, false);
#line 93 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MailingZip));

#line default
#line hidden
            EndContext();
            BeginContext(3103, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3167, 42, false);
#line 96 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MailingZip));

#line default
#line hidden
            EndContext();
            BeginContext(3209, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3272, 50, false);
#line 99 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MailingCountry));

#line default
#line hidden
            EndContext();
            BeginContext(3322, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3386, 46, false);
#line 102 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MailingCountry));

#line default
#line hidden
            EndContext();
            BeginContext(3432, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3495, 45, false);
#line 105 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(3540, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3604, 41, false);
#line 108 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(3645, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3708, 39, false);
#line 111 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(3747, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3811, 35, false);
#line 114 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fax));

#line default
#line hidden
            EndContext();
            BeginContext(3846, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3909, 48, false);
#line 117 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3957, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4021, 44, false);
#line 120 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(4065, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4128, 46, false);
#line 123 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mcs150date));

#line default
#line hidden
            EndContext();
            BeginContext(4174, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4238, 42, false);
#line 126 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mcs150date));

#line default
#line hidden
            EndContext();
            BeginContext(4280, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4343, 49, false);
#line 129 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mcs150mileage));

#line default
#line hidden
            EndContext();
            BeginContext(4392, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4456, 45, false);
#line 132 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mcs150mileage));

#line default
#line hidden
            EndContext();
            BeginContext(4501, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4564, 53, false);
#line 135 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mcs150mileageYear));

#line default
#line hidden
            EndContext();
            BeginContext(4617, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4681, 49, false);
#line 138 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mcs150mileageYear));

#line default
#line hidden
            EndContext();
            BeginContext(4730, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4793, 43, false);
#line 141 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AddDate));

#line default
#line hidden
            EndContext();
            BeginContext(4836, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4900, 39, false);
#line 144 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AddDate));

#line default
#line hidden
            EndContext();
            BeginContext(4939, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5002, 44, false);
#line 147 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Oicstate));

#line default
#line hidden
            EndContext();
            BeginContext(5046, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5110, 40, false);
#line 150 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Oicstate));

#line default
#line hidden
            EndContext();
            BeginContext(5150, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5213, 48, false);
#line 153 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NbrpowerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(5261, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5325, 44, false);
#line 156 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NbrpowerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(5369, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5432, 47, false);
#line 159 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DriverTotal));

#line default
#line hidden
            EndContext();
            BeginContext(5479, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5543, 43, false);
#line 162 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DriverTotal));

#line default
#line hidden
            EndContext();
            BeginContext(5586, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5649, 42, false);
#line 165 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(5691, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5755, 38, false);
#line 168 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(5793, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5856, 44, false);
#line 171 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(5900, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5964, 40, false);
#line 174 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(6004, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(6067, 45, false);
#line 177 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(6112, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6176, 41, false);
#line 180 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(6217, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(6255, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157518a9da3a1af75b338e8292a0e6c8e65385f531002", async() => {
                BeginContext(6281, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6291, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "157518a9da3a1af75b338e8292a0e6c8e65385f531395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 185 "E:\Enterprise Applications\Washington\WashingtonChameleons\WashingtonChameleons\Views\ActiveCarriers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DotNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6334, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(6417, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157518a9da3a1af75b338e8292a0e6c8e65385f533344", async() => {
                    BeginContext(6439, 12, true);
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
                BeginContext(6455, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6468, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WashingtonChameleons.Models.ActiveCarriers> Html { get; private set; }
    }
}
#pragma warning restore 1591
