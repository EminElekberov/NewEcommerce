#pragma checksum "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e8ba6e17849e02c32b3b4f5ba0f6e81e34be78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\_ViewImports.cshtml"
using EcommerceSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\_ViewImports.cshtml"
using EcommerceSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\_ViewImports.cshtml"
using EcommerceSite.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\_ViewImports.cshtml"
using EcommerceSite.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e8ba6e17849e02c32b3b4f5ba0f6e81e34be78f", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dff8adfe4bcb01c9d73a29eafdd4445e697e77b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image desc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PaginationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">Blog Classic<span>Blog</span></h1>
        </div><!-- End .container -->
    </div><!-- End .page-header -->
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav mb-3"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Blog</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Classic</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9"">
                    <article class=""entry"">
");
#nullable restore
#line 23 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                         foreach (var item in Model.Blogs)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <figure class=\"entry-media\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1156, "\"", 1185, 2);
            WriteAttributeValue("", 1163, "/blog/details/", 1163, 14, true);
#nullable restore
#line 27 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1177, item.Id, 1177, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4e8ba6e17849e02c32b3b4f5ba0f6e81e34be78f6025", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1235, "~/images/blogs/", 1235, 15, true);
#nullable restore
#line 28 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1250, item.Image, 1250, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </a>\r\n                            </figure><!-- End .entry-media -->\r\n");
            WriteLiteral(@"                            <div class=""entry-body"">
                                <div class=""entry-meta"">
                                    <span class=""entry-author"">
                                    </span>
                                    <span class=""meta-separator"">|</span>
                                    <a href=""#"">");
#nullable restore
#line 37 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    <span class=""meta-separator"">|</span>
                                    <a href=""#"">2 Comments</a>
                                </div><!-- End .entry-meta -->

                                <h2 class=""entry-title"">
                                    <a href=""single.html"">");
#nullable restore
#line 43 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h2><!-- End .entry-title -->\r\n\r\n                                <div class=\"entry-cats\">\r\n                                    in <a href=\"#\">");
#nullable restore
#line 47 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                              Write(item.category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>,\r\n                                </div><!-- End .entry-cats -->\r\n\r\n                                <div class=\"entry-content\">\r\n                                    <p>");
#nullable restore
#line 51 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2513, "\"", 2542, 2);
            WriteAttributeValue("", 2520, "/blog/details/", 2520, 14, true);
#nullable restore
#line 52 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2534, item.Id, 2534, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"read-more\">Continue Reading</a>\r\n                                </div><!-- End .entry-content -->\r\n                            </div><!-- End .entry-body -->\r\n");
#nullable restore
#line 55 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </article><!-- End .entry -->\r\n                    <nav aria-label=\"Page navigation\">\r\n                        <div id=\"pagination\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e8ba6e17849e02c32b3b4f5ba0f6e81e34be78f10808", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 59 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Pagination;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </nav>\r\n                </div><!-- End .col-lg-9 -->\r\n                ");
#nullable restore
#line 63 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
           Write(await Component.InvokeAsync("VcBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div><!-- End .row -->\r\n        </div><!-- End .container -->\r\n    </div><!-- End .page-content -->\r\n</main><!-- End .main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVm> Html { get; private set; }
    }
}
#pragma warning restore 1591