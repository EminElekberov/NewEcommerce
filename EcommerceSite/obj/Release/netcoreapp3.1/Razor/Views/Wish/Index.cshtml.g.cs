#pragma checksum "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5297b37bdaf1f2b62ac6e90f7f7b2ed669e3e6c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wish_Index), @"mvc.1.0.view", @"/Views/Wish/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5297b37bdaf1f2b62ac6e90f7f7b2ed669e3e6c6", @"/Views/Wish/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dff8adfe4bcb01c9d73a29eafdd4445e697e77b", @"/Views/_ViewImports.cshtml")]
    public class Views_Wish_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Add to cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">Wishlist<span>Shop</span></h1>
        </div><!-- End .container -->
    </div><!-- End .page-header -->
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Shop</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Wishlist</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""container"">
            <table class=""table table-wishlist table-mobile"">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Pr");
            WriteLiteral("ice</th>\r\n                        <th>Stock Status</th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n");
#nullable restore
#line 32 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
                     if (ViewBag.wish != null)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
                         foreach (var item in ViewBag.wish)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <td class=""product-col"">
                                    <div class=""product"">
                                        <figure class=""product-media"">
                                            <a>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5297b37bdaf1f2b62ac6e90f7f7b2ed669e3e6c67364", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1724, "~/images/categories/", 1724, 20, true);
#nullable restore
#line 43 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
AddHtmlAttributeValue("", 1744, item.Product.Image, 1744, 19, false);

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
            WriteLiteral("\r\n                                            </a>\r\n                                        </figure>\r\n\r\n                                        <h3 class=\"product-title\">\r\n                                            <a href=\"#\">");
#nullable restore
#line 48 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
                                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </h3><!-- End .product-title -->\r\n                                    </div><!-- End .product -->\r\n                                </td>\r\n                                <td class=\"price-col\">$");
#nullable restore
#line 52 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
                                                  Write(item.Product.PresentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"stock-col\"><span class=\"in-stock\">In stock</span></td>\r\n                                <td class=\"action-col\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5297b37bdaf1f2b62ac6e90f7f7b2ed669e3e6c610151", async() => {
                WriteLiteral("<span>add to cart</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
                                                                                WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"remove-col\"><button class=\"btn-remove\"><i class=\"icon-close\"></i></button></td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Wish\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table><!-- End .table table-wishlist -->
            <div class=""wishlist-share"">
                <div class=""social-icons social-icons-sm mb-2"">
                    <label class=""social-label"">Share on:</label>
                    <a href=""#"" class=""social-icon"" title=""Facebook"" target=""_blank""><i class=""icon-facebook-f""></i></a>
                    <a href=""#"" class=""social-icon"" title=""Twitter"" target=""_blank""><i class=""icon-twitter""></i></a>
                    <a href=""#"" class=""social-icon"" title=""Instagram"" target=""_blank""><i class=""icon-instagram""></i></a>
                    <a href=""#"" class=""social-icon"" title=""Youtube"" target=""_blank""><i class=""icon-youtube""></i></a>
                    <a href=""#"" class=""social-icon"" title=""Pinterest"" target=""_blank""><i class=""icon-pinterest""></i></a>
                </div><!-- End .soial-icons -->
            </div><!-- End .wishlist-share -->
        </div><!-- End .container -->
    </div><!-- End .page-conte");
            WriteLiteral("nt -->\r\n</main><!-- End .main -->");
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
