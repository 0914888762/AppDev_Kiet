#pragma checksum "E:\1670\AppDev\AppDev 1670\AppDev1670\Views\Customer\Help.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0223a89660d40d84f3b7a816c95e09ad11a4c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Help), @"mvc.1.0.view", @"/Views/Customer/Help.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0223a89660d40d84f3b7a816c95e09ad11a4c3", @"/Views/Customer/Help.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50b59efb2936d41327dd6e0fa77f1848fc0c6f76", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Help : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">

        <div class=""col-md-10 col-sm-12 col-xs-12"">
            <main id=""main-doc"">
                <section class=""main-section"" id=""Introduction"">
                    <!--basic styling for the headings, better practice to do the same in a css file as the styling is same for all headers-->
                    <h3 style=""background: black; color: white"">Introduction</h3>
                    <article>
                        <p>Some content about the main topic, for example Java documentation introduction about the language
                    </article>
                </section>
                <section class=""main-section"" id=""What_you_should_already_know"">
                    <h3 style=""background: black; color: white"">What you should already know</h3>
                    <article>
                        <p>Background information before getting into the topic:</p>
                        <!--creating list using html-->
              ");
            WriteLiteral(@"          <li>Some list content</li>
                        <li>Prerequisites.</li>
                        <li>Workings and assumptions</li>
                        <p>Any other content to be covered before learning this topic</p>
                    </artice>
                </section>
                <section class=""main-section"" id=""About_Topic"">
                    <h3 style=""background: black; color: white"">About topic</h3>
                    <article>
                        <p>More lines about the topic. For example, how the basic functionality works, features etc...</p>
                        <p>
                            Technical documentation should be thorough and to the point
                        </p>
                        <p>
                            Write about features, comparisons with other languages etc
                        </p>
                    </article>
                </section>
                <section class=""main-section"" id=""Topic_1"">
          ");
            WriteLiteral(@"          <h3 style=""background: black; color: white"">Topic 1</h3>
                    <article>
                        Getting started with the actual documentation content
                        <code>
                            This would come in a different color and font indicating lines of code
                        </code>
                    </article>
                </section>
                <section class=""main-section"" id=""Topic_2"">
                    <h3 style=""background: black; color: white"">Topic 2</h3>
                    <p>
                        Another topic about the main topic, for example, if the topic is Java, this could be variables or data types in Java
                    </p>
                </section>
            </main>
        </div>
    </div>
</div>
");
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