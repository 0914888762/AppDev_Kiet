#pragma checksum "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9069cbf2a3dcd9459e81244437d0c47574d15630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#nullable restore
#line 1 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\_ViewImports.cshtml"
using AppDev1670;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\_ViewImports.cshtml"
using AppDev1670.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9069cbf2a3dcd9459e81244437d0c47574d15630", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50b59efb2936d41327dd6e0fa77f1848fc0c6f76", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<style>
    .card {
        margin-bottom: 30px;
    }

    .card {
        position: relative;
        display: flex;
        flex-direction: column;
        min-width: 0;
        word-wrap: break-word;
        background-color: #fff;
        background-clip: border-box;
        border: 0 solid transparent;
        border-radius: 0;
    }

        .card .card-subtitle {
            font-weight: 300;
            margin-bottom: 10px;
            color: #8898aa;
        }

    .table-product.table-striped tbody tr:nth-of-type(odd) {
        background-color: #f3f8fa !important
    }

    .table-product td {
        border-top: 0px solid #dee2e6 !important;
        color: #728299 !important;
    }
    .img-responsive{
        width: 365px;
        height: 588px;
    }
</style>

<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"">

<div class=""container"">
    <div class=""card"">
        <div class=""card-body"">
       ");
            WriteLiteral("     <h3 class=\"card-title\">");
#nullable restore
#line 47 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml"
                              Write(Model.NameBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5 col-md-5 col-sm-6\">\r\n                    <div class=\"white-box text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 1239, "\"", 1259, 1);
#nullable restore
#line 50 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml"
WriteAttributeValue("", 1245, ViewBag.Image, 1245, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"></div>\r\n                </div>\r\n                <div class=\"col-lg-7 col-md-7 col-sm-6\">\r\n                    <h2 class=\"mt-5\">\r\n                        ");
#nullable restore
#line 54 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\r\n                    </h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9069cbf2a3dcd9459e81244437d0c47574d156306338", async() => {
                WriteLiteral("Back To Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral(@"
                </div>
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <h3 class=""box-title mt-5"">General Info</h3>
                    <div class=""table-responsive"">
                        <table class=""table table-striped table-product"">
                            <tbody>
                                <tr>
                                    <td width=""390"">Quantity</td>
                                    <td>");
#nullable restore
#line 65 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml"
                                   Write(Model.QuantityBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Created At</td>\r\n                                    <td>");
#nullable restore
#line 69 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml"
                                   Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <td>Information of Book</td>\r\n                                    <td>");
#nullable restore
#line 73 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml"
                                   Write(Model.InformationBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                                  <tr>\r\n                                    <td>Category</td>\r\n                                    <td>");
#nullable restore
#line 77 "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Books\Details.cshtml"
                                   Write(Model.Category.NameCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
