#pragma checksum "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11a4cccd47437c9651658d49a505e4651447caa3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11a4cccd47437c9651658d49a505e4651447caa3", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5804bfd79ea64a411840254b1f94ac032f6c105", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image desc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
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
            WriteLiteral("                            <figure class=\"entry-media\">\r\n                                <a href=\"single.html\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11a4cccd47437c9651658d49a505e4651447caa35972", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1224, "~/images/blogs/", 1224, 15, true);
#nullable restore
#line 28 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1239, item.Image, 1239, 11, false);

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
            WriteLiteral("</p>\r\n                                    <a href=\"single.html\" class=\"read-more\">Continue Reading</a>\r\n                                </div><!-- End .entry-content -->\r\n                            </div><!-- End .entry-body -->\r\n");
#nullable restore
#line 55 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </article><!-- End .entry -->
                    <nav aria-label=""Page navigation"">
                        <ul class=""pagination"">
                            <li class=""page-item disabled"">
                                <a class=""page-link page-link-prev"" href=""#"" aria-label=""Previous"" tabindex=""-1"" aria-disabled=""true"">
                                    <span aria-hidden=""true""><i class=""icon-long-arrow-left""></i></span>Prev
                                </a>
                            </li>
                            <li class=""page-item active"" aria-current=""page""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item"">
                                <a class=""page-link page-link-next"" href=""#"" aria-label=""Next"">
                                    Next <span aria-hidden=""true""><i class=""icon-long-arrow-right""></i></span>
                ");
            WriteLiteral(@"                </a>
                            </li>
                        </ul>
                    </nav>
                </div><!-- End .col-lg-9 -->

                <aside class=""col-lg-3"">
                    <div class=""sidebar"">
                        <div class=""widget widget-search"">
                            <h3 class=""widget-title"">Search</h3><!-- End .widget-title -->

                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11a4cccd47437c9651658d49a505e4651447caa311704", async() => {
                WriteLiteral(@"
                                <label for=""ws"" class=""sr-only"">Search in blog</label>
                                <input type=""search"" class=""form-control"" name=""ws"" id=""ws"" placeholder=""Search in blog"" required>
                                <button type=""submit"" class=""btn""><i class=""icon-search""></i><span class=""sr-only"">Search</span></button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div><!-- End .widget -->\r\n\r\n                        <div class=\"widget widget-cats\">\r\n                            <h3 class=\"widget-title\">Categories</h3><!-- End .widget-title -->\r\n");
#nullable restore
#line 89 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                             foreach (var item in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ul>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4974, "\"", 5005, 2);
            WriteAttributeValue("", 4981, "/category/index/", 4981, 16, true);
#nullable restore
#line 92 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4997, item.Id, 4997, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 92 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                                                                      Write(item.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n                                </ul>\r\n");
#nullable restore
#line 94 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div><!-- End .widget -->

                        <div class=""widget"">
                            <h3 class=""widget-title"">Popular Posts</h3><!-- End .widget-title -->

                            <ul class=""posts-list"">
");
#nullable restore
#line 102 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                 foreach (var item in Model.Blogs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <figure>\r\n                                            <a href=\"#\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11a4cccd47437c9651658d49a505e4651447caa316019", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5698, "~/images/blogs/", 5698, 15, true);
#nullable restore
#line 107 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 5713, item.Image, 5713, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </a>\r\n                                        </figure>\r\n\r\n                                        <div>\r\n                                            <span>");
#nullable restore
#line 112 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                             Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <h4><a href=\"#\">");
#nullable restore
#line 113 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 116 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul><!-- End .posts-list -->
                        </div><!-- End .widget -->
                        <div class=""widget"">
                            <h3 class=""widget-title"">Browse Tags</h3><!-- End .widget-title -->

                            <div class=""tagcloud"">
");
#nullable restore
#line 124 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                 foreach (var item in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a >");
#nullable restore
#line 126 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 127 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Blog\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div><!-- End .tagcloud -->
                        </div><!-- End .widget -->

                        <div class=""widget widget-text"">
                            <h3 class=""widget-title"">About Blog</h3><!-- End .widget-title -->

                            <div class=""widget-text-content"">
                                <p>Vestibulum volutpat, lacus a ultrices sagittis, mi neque euismod dui, pulvinar nunc sapien ornare nisl.</p>
                            </div><!-- End .widget-text-content -->
                        </div><!-- End .widget -->
                    </div><!-- End .sidebar -->
                </aside><!-- End .col-lg-3 -->
            </div><!-- End .row -->
        </div><!-- End .container -->
    </div><!-- End .page-content -->
</main><!-- End .main -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVm> Html { get; private set; }
    }
}
#pragma warning restore 1591