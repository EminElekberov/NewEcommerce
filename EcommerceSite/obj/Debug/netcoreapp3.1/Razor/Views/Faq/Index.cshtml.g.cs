#pragma checksum "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "146cc50e1629ad49a7ea542853cee9e21319616b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faq_Index), @"mvc.1.0.view", @"/Views/Faq/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"146cc50e1629ad49a7ea542853cee9e21319616b", @"/Views/Faq/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5804bfd79ea64a411840254b1f94ac032f6c105", @"/Views/_ViewImports.cshtml")]
    public class Views_Faq_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">F.A.Q<span>Pages</span></h1>
        </div><!-- End .container -->
    </div><!-- End .page-header -->
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Pages</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">FAQ</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""container"">
");
#nullable restore
#line 20 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
             foreach (var item in Model.faqTitles)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2 class=\"title text-center mb-3\">");
#nullable restore
#line 23 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2><!-- End .title -->\r\n                <div class=\"accordion accordion-rounded\" id=\"accordion-1\">\r\n                    <div class=\"card card-box card-sm bg-light\">\r\n");
#nullable restore
#line 26 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
                         foreach (var components in item.faqComponents)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-header\" id=\"heading-1\">\r\n                                <h2 class=\"card-title\">\r\n                                    <a role=\"button\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 1445, "\"", 1475, 2);
            WriteAttributeValue("", 1452, "#", 1452, 1, true);
#nullable restore
#line 30 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
WriteAttributeValue("", 1453, components.ToggleHref, 1453, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"true\" >\r\n                                        ");
#nullable restore
#line 31 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
                                   Write(components.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </h2>\r\n                            </div><!-- End .card-header -->\r\n                            <div");
            BeginWriteAttribute("id", " id=\"", 1734, "\"", 1761, 1);
#nullable restore
#line 35 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
WriteAttributeValue("", 1739, components.ToggleHref, 1739, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse show\" aria-labelledby=\"heading-1\" data-parent=\"#accordion-1\">\r\n                                <div class=\"card-body\">\r\n                                    ");
#nullable restore
#line 37 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
                               Write(components.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div><!-- End .card-body -->\r\n                            </div><!-- End .collapse -->\r\n");
#nullable restore
#line 40 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div><!-- End .card -->\r\n                </div><!-- End .accordion -->\r\n");
#nullable restore
#line 43 "D:\pragmateck\EcommerceSite\EcommerceSite\Views\Faq\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div><!-- End .container -->
    </div><!-- End .page-content -->

    <div class=""cta cta-display bg-image pt-4 pb-4"" style=""background-image: url(assets/images/backgrounds/cta/bg-7.jpg);"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-10 col-lg-9 col-xl-7"">
                    <div class=""row no-gutters flex-column flex-sm-row align-items-sm-center"">
                        <div class=""col"">
                            <h3 class=""cta-title text-white"">If You Have More Questions</h3><!-- End .cta-title -->
                            <p class=""cta-desc text-white"">Quisque volutpat mattis eros</p><!-- End .cta-desc -->
                        </div><!-- End .col -->

                        <div class=""col-auto"">
                            <a href=""contact.html"" class=""btn btn-outline-white""><span>CONTACT US</span><i class=""icon-long-arrow-right""></i></a>
                        </div><!-- End .col-auto -->
   ");
            WriteLiteral("                 </div><!-- End .row no-gutters -->\r\n                </div><!-- End .col-md-10 col-lg-9 -->\r\n            </div><!-- End .row -->\r\n        </div><!-- End .container -->\r\n    </div><!-- End .cta -->\r\n</main><!-- End .main -->");
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
