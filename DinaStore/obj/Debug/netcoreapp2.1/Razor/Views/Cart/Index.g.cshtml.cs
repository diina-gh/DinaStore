#pragma checksum "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d20070663a759a994b8120613c8037e80b5e8fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d20070663a759a994b8120613c8037e80b5e8fe", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc2f1ab062a66992fd957d540dc80154f2084f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
  
    Layout = "~/Views/Store/_Layout.cshtml";

#line default
#line hidden
            BeginContext(66, 385, true);
            WriteLiteral(@"
<h2 class=""m-3"">Your Cart</h2>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col font-weight-bold"">Quantity</div>
        <div class=""col font-weight-bold"">Product</div>
        <div class=""col font-weight-bold text-right"">Price</div>
        <div class=""col font-weight-bold text-right"">Subtotal</div>
        <div class=""col""></div>
    </div>
");
            EndContext();
#line 16 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
     if (Model.Selections.Count() == 0)
    {

#line default
#line hidden
            BeginContext(499, 86, true);
            WriteLiteral("        <div class=\"row mt-2\"><div class=\"col-12\"><h4>Cart is Empty</h4></div></div>\r\n");
            EndContext();
#line 19 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 22 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
         foreach (OrderLine line in Model.Selections)
        {

#line default
#line hidden
            BeginContext(675, 69, true);
            WriteLiteral("            <div class=\"row mt-1\">\r\n                <div class=\"col\">");
            EndContext();
            BeginContext(745, 13, false);
#line 25 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
                            Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(758, 41, true);
            WriteLiteral("</div>\r\n                <div class=\"col\">");
            EndContext();
            BeginContext(800, 17, false);
#line 26 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
                            Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(817, 75, true);
            WriteLiteral("</div>\r\n                <div class=\"col text-right\">\r\n                    $");
            EndContext();
            BeginContext(893, 39, false);
#line 28 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
                Write(line.Product.RetailPrice.ToString("f2"));

#line default
#line hidden
            EndContext();
            BeginContext(932, 93, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col text-right\">\r\n                    $");
            EndContext();
            BeginContext(1027, 82, false);
#line 31 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
                 Write((line.Product.RetailPrice
                        * line.Quantity).ToString("f2"));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 81, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1191, 327, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5053e38b4b94436da773474917f37de6", async() => {
                BeginContext(1225, 64, true);
                WriteLiteral("\r\n                        <button type=\"submit\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                value=\"", 1289, "\"", 1345, 1);
#line 37 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1330, line.ProductId, 1330, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1346, 165, true);
                WriteLiteral("\r\n                                class=\"btn btn-sm btn-outline-danger\">\r\n                            Remove\r\n                        </button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1518, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 44 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#line 44 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(1582, 229, true);
            WriteLiteral("    <div class=\"row mt-2\">\r\n        <div class=\"col\"></div>\r\n        <div class=\"col\"></div>\r\n        <div class=\"col text-right font-weight-bold\">Total:</div>\r\n        <div class=\"col text-right font-weight-bold\">\r\n            $");
            EndContext();
            BeginContext(1813, 93, false);
#line 51 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
         Write(Model.Selections.Sum(l => l.Product.RetailPrice
                * l.Quantity).ToString("f2"));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 102, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col\"></div>\r\n    </div>\r\n</div>\r\n<div class=\"text-center m-2\">\r\n");
            EndContext();
#line 58 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
     if (ViewBag.returnUrl != null)
    {

#line default
#line hidden
            BeginContext(2053, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2063, "\"", 2088, 1);
#line 60 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2070, ViewBag.returnUrl, 2070, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2089, 80, true);
            WriteLiteral(" class=\"btn btn-outline-primary\">\r\n            Continue Shopping\r\n        </a>\r\n");
            EndContext();
#line 63 "C:\Users\HP\Source\Repos\SportsStore02\SportsStore02\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2176, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2180, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27838ba5660a44ffa384c1f1c412e289", async() => {
                BeginContext(2232, 27, true);
                WriteLiteral("\r\n        Place Order\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(2263, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
