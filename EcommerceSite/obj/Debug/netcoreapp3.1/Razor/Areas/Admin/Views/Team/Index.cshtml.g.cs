#pragma checksum "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8c68a6eda3c1da787987f58ad102468a9886b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Team_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Team/Index.cshtml")]
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
#line 1 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\_ViewImports.cshtml"
using EcommerceSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\_ViewImports.cshtml"
using EcommerceSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8c68a6eda3c1da787987f58ad102468a9886b4", @"/Areas/Admin/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a8c3e0e676e7642488c97c653608f4de37da7b2", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<MyTeam>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""margin-bottom:50px"">
    <a href=""/Admin/Team/Create"" class=""btn btn-outline-success"" style=""width:100%"">Add new slider</a>
</div>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Image</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Job</th>
            <th scope=""col"">Description</th>
            <th>CRUD</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 28 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 31 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f8c68a6eda3c1da787987f58ad102468a9886b45995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 838, "~/images/team/", 838, 14, true);
#nullable restore
#line 33 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
AddHtmlAttributeValue("", 852, item.Image, 852, 11, false);

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
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 35 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
               Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1076, "\"", 1108, 2);
            WriteAttributeValue("", 1083, "/Admin/Team/Edit/", 1083, 17, true);
#nullable restore
#line 40 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
WriteAttributeValue("", 1100, item.Id, 1100, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1183, "\"", 1217, 2);
            WriteAttributeValue("", 1190, "/Admin/Team/Delete/", 1190, 19, true);
#nullable restore
#line 41 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
WriteAttributeValue("", 1209, item.Id, 1209, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you sure\')\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                    <br />\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1348, "\"", 1383, 2);
            WriteAttributeValue("", 1355, "/Admin/Team/Details/", 1355, 20, true);
#nullable restore
#line 43 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"
WriteAttributeValue("", 1375, item.Id, 1375, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "D:\pragmateck\EcommerceSite\EcommerceSite\Areas\Admin\Views\Team\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<MyTeam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
