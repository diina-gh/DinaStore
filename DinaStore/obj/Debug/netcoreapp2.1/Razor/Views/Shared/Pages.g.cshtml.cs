#pragma checksum "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0dd14987f887d9497383ffd25fc648e9e9312ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Pages), @"mvc.1.0.view", @"/Views/Shared/Pages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Pages.cshtml", typeof(AspNetCore.Views_Shared_Pages))]
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
#line 1 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\_ViewImports.cshtml"
using SportsStore02;

#line default
#line hidden
#line 2 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\_ViewImports.cshtml"
using SportsStore02.Models;

#line default
#line hidden
#line 3 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\_ViewImports.cshtml"
using SportsStore02.Models.Pages;

#line default
#line hidden
#line 4 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\_ViewImports.cshtml"
using SportsStore02.Infrastructure;

#line default
#line hidden
#line 5 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0dd14987f887d9497383ffd25fc648e9e9312ac", @"/Views/Shared/Pages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc2f1ab062a66992fd957d540dc80154f2084f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Pages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pageform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2, 1944, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fae3dbbf14c4c74aebf48676b63354a", async() => {
                BeginContext(70, 46, true);
                WriteLiteral("\r\n\r\n        <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 116, "\"", 147, 1);
#line 4 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 124, Model.CurrentPage -1, 124, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", "\r\n                class=\"", 148, "\"", 244, 4);
                WriteAttributeValue("", 173, "btn", 173, 3, true);
                WriteAttributeValue(" ", 176, "btn-outline-dark", 177, 17, true);
                WriteAttributeValue(" ", 193, "btn-sm", 194, 7, true);
#line 5 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 200, !Model.HasPreviousPage ? "disabled" : "", 201, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(245, 77, true);
                WriteLiteral("\r\n                type=\"submit\">\r\n            Previous\r\n        </button>\r\n\r\n");
                EndContext();
#line 10 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
         for (int i = 1; i <= 3 && i <= Model.TotalPages; i++)
        {

#line default
#line hidden
                BeginContext(397, 46, true);
                WriteLiteral("            <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 443, "\"", 453, 1);
#line 12 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 451, i, 451, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 14, true);
                WriteLiteral(" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("class", "\r\n                    class=\"", 468, "\"", 566, 4);
                WriteAttributeValue("", 497, "btn", 497, 3, true);
                WriteAttributeValue(" ", 500, "btn-outline-dark", 501, 17, true);
                WriteAttributeValue(" ", 517, "btn-sm", 518, 7, true);
#line 13 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 524, Model.CurrentPage == i ? "active" : "", 525, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(567, 19, true);
                WriteLiteral(">\r\n                ");
                EndContext();
                BeginContext(587, 1, false);
#line 14 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(588, 25, true);
                WriteLiteral("\r\n            </button>\r\n");
                EndContext();
#line 16 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
        }

#line default
#line hidden
                BeginContext(624, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 17 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
         if (Model.CurrentPage > 3 && Model.TotalPages - Model.CurrentPage >= 3)
        {

#line default
#line hidden
                BeginContext(717, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(731, 68, true);
                WriteLiteral("...\r\n            <button class=\"btn btn-outline-dark btn-sm active\">");
                EndContext();
                BeginContext(800, 17, false);
#line 20 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
                                                          Write(Model.CurrentPage);

#line default
#line hidden
                EndContext();
                BeginContext(817, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 21 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
        }

#line default
#line hidden
                BeginContext(839, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 22 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
         if (Model.TotalPages > 3)
        {

#line default
#line hidden
                BeginContext(886, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(900, 5, true);
                WriteLiteral("...\r\n");
                EndContext();
#line 25 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
             for (int i = Math.Max(4, Model.TotalPages - 2);
          i <= Model.TotalPages; i++)
            {

#line default
#line hidden
                BeginContext(1021, 50, true);
                WriteLiteral("                <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1071, "\"", 1081, 1);
#line 28 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 1079, i, 1079, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1082, 14, true);
                WriteLiteral(" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("class", "\r\n                        class=\"", 1096, "\"", 1199, 4);
                WriteAttributeValue("", 1129, "btn", 1129, 3, true);
                WriteAttributeValue(" ", 1132, "btn-outline-dark", 1133, 17, true);
                WriteAttributeValue(" ", 1149, "btn-sm", 1150, 7, true);
#line 29 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue("\r\n", 1156, Model.CurrentPage == i ? "active" : "", 1158, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1200, 23, true);
                WriteLiteral(">\r\n                    ");
                EndContext();
                BeginContext(1224, 1, false);
#line 31 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
               Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(1225, 29, true);
                WriteLiteral("\r\n                </button>\r\n");
                EndContext();
#line 33 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
            }

#line default
#line hidden
#line 33 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1280, 42, true);
                WriteLiteral("        <button name=\"options.currentPage\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1322, "\"", 1353, 1);
#line 35 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue("", 1330, Model.CurrentPage +1, 1330, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1354, 14, true);
                WriteLiteral(" type=\"submit\"");
                EndContext();
                BeginWriteAttribute("class", "\r\n                class=\"", 1368, "\"", 1459, 4);
                WriteAttributeValue("", 1393, "btn", 1393, 3, true);
                WriteAttributeValue(" ", 1396, "btn-outline-dark", 1397, 17, true);
                WriteAttributeValue(" ", 1413, "btn-sm", 1414, 7, true);
#line 36 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
WriteAttributeValue(" ", 1420, !Model.HasNextPage? "disabled" : "", 1421, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1460, 115, true);
                WriteLiteral(">\r\n            Next\r\n        </button>\r\n\r\n        <select name=\"options.pageSize\" class=\"form-control ml-1 mr-1\">\r\n");
                EndContext();
#line 41 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
             foreach (int val in new int[] { 10, 25, 50, 100 })
            {

#line default
#line hidden
                BeginContext(1655, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1671, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade80eb5b96145899895cd29299909de", async() => {
                    BeginContext(1729, 3, false);
#line 43 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
                                                                    Write(val);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 43 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
                   WriteLiteral(val);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 43 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
AddHtmlAttributeValue("", 1702, Model.PageSize == val, 1702, 24, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1741, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Shared\Pages.cshtml"
            }

#line default
#line hidden
                BeginContext(1758, 181, true);
                WriteLiteral("        </select>\r\n        <input type=\"hidden\" name=\"options.currentPage\" value=\"1\" />\r\n        <button type=\"submit\" class=\"btn btn-secondary btn-sm\">Change Page Size</button>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591