#pragma checksum "D:\pragmateck\EcommerceSite\EcommerceSite\Views\CheckOut\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015189a366d32d5ea1d03dfc96167e66a4f155eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CheckOut_Index), @"mvc.1.0.view", @"/Views/CheckOut/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015189a366d32d5ea1d03dfc96167e66a4f155eb", @"/Views/CheckOut/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dff8adfe4bcb01c9d73a29eafdd4445e697e77b", @"/Views/_ViewImports.cshtml")]
    public class Views_CheckOut_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">Checkout<span>Shop</span></h1>
        </div><!-- End .container -->
    </div><!-- End .page-header -->
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Shop</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Checkout</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""checkout"">
            <div class=""container"">
                <div class=""checkout-discount"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015189a366d32d5ea1d03dfc96167e66a4f155eb5532", async() => {
                WriteLiteral(@"
                        <input type=""text"" class=""form-control"" required id=""checkout-discount-input"">
                        <label for=""checkout-discount-input"" class=""text-truncate"">Have a coupon? <span>Click here to enter your code</span></label>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div><!-- End .checkout-discount -->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015189a366d32d5ea1d03dfc96167e66a4f155eb7202", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-lg-9"">
                            <h2 class=""checkout-title"">Billing Details</h2><!-- End .checkout-title -->
                            <div class=""row"">
                                <div class=""col-sm-6"">
                                    <label>First Name *</label>
                                    <input type=""text"" name=""name""  class=""form-control"" required>
                                </div><!-- End .col-sm-6 -->

                                <div class=""col-sm-6"">
                                    <label>Last Name *</label>
                                    <input type=""text"" class=""form-control"" required>
                                </div><!-- End .col-sm-6 -->
                            </div><!-- End .row -->

                            <label>Company Name (Optional)</label>
                            <input type=""text"" class=""form-control"">

                            <label");
                WriteLiteral(@">Country *</label>
                            <input type=""text"" class=""form-control"" required>

                            <label>Street address *</label>
                            <input type=""text"" class=""form-control"" placeholder=""House number and Street name"" required>
                            <input type=""text"" class=""form-control"" placeholder=""Appartments, suite, unit etc ..."" required>

                            <div class=""row"">
                                <div class=""col-sm-6"">
                                    <label>Town / City *</label>
                                    <input type=""text"" class=""form-control"" required>
                                </div><!-- End .col-sm-6 -->

                                <div class=""col-sm-6"">
                                    <label>State / County *</label>
                                    <input type=""text"" class=""form-control"" required>
                                </div><!-- End .col-sm-6 -->
                  ");
                WriteLiteral(@"          </div><!-- End .row -->

                            <div class=""row"">
                                <div class=""col-sm-6"">
                                    <label>Postcode / ZIP *</label>
                                    <input type=""text"" class=""form-control"" required>
                                </div><!-- End .col-sm-6 -->

                                <div class=""col-sm-6"">
                                    <label>Phone *</label>
                                    <input type=""tel"" class=""form-control"" required>
                                </div><!-- End .col-sm-6 -->
                            </div><!-- End .row -->

                            <label>Email address *</label>
                            <input type=""email"" class=""form-control"" required>

                            <div class=""custom-control custom-checkbox"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""checkout-create-acc"">
                  ");
                WriteLiteral(@"              <label class=""custom-control-label"" for=""checkout-create-acc"">Create an account?</label>
                            </div><!-- End .custom-checkbox -->

                            <div class=""custom-control custom-checkbox"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""checkout-diff-address"">
                                <label class=""custom-control-label"" for=""checkout-diff-address"">Ship to a different address?</label>
                            </div><!-- End .custom-checkbox -->

                            <label>Order notes (optional)</label>
                            <textarea class=""form-control"" cols=""30"" rows=""4"" placeholder=""Notes about your order, e.g. special notes for delivery""></textarea>
                        </div><!-- End .col-lg-9 -->
                        <aside class=""col-lg-3"">
                            <div class=""summary"">
                                <h3 class=""summary-title"">Your Order</h3><!-- End ");
                WriteLiteral(@".summary-title -->

                                <table class=""table table-summary"">
                                    <thead>
                                        <tr>
                                            <th>Product</th>
                                            <th>Total</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                        <tr>
                                            <td><a href=""#"">Beige knitted elastic runner shoes</a></td>
                                            <td>$84.00</td>
                                        </tr>

                                        <tr>
                                            <td><a href=""#"">Blue utility pinafore denimdress</a></td>
                                            <td>$76,00</td>
                                        </tr>
                                        <tr class=""summary-sub");
                WriteLiteral(@"total"">
                                            <td>Subtotal:</td>
                                            <td>$160.00</td>
                                        </tr><!-- End .summary-subtotal -->
                                        <tr>
                                            <td>Shipping:</td>
                                            <td>Free shipping</td>
                                        </tr>
                                        <tr class=""summary-total"">
                                            <td>Total:</td>
                                            <td>$160.00</td>
                                        </tr><!-- End .summary-total -->
                                    </tbody>
                                </table><!-- End .table table-summary -->

                                <div class=""accordion-summary"" id=""accordion-payment"">
                                    <div class=""card"">
                                        <div class=""car");
                WriteLiteral(@"d-header"" id=""heading-1"">
                                            <h2 class=""card-title"">
                                                <a role=""button"" data-toggle=""collapse"" href=""#collapse-1"" aria-expanded=""true"" aria-controls=""collapse-1"">
                                                    Direct bank transfer
                                                </a>
                                            </h2>
                                        </div><!-- End .card-header -->
                                        <div id=""collapse-1"" class=""collapse show"" aria-labelledby=""heading-1"" data-parent=""#accordion-payment"">
                                            <div class=""card-body"">
                                                Make your payment directly into our bank account. Please use your Order ID as the payment reference. Your order will not be shipped until the funds have cleared in our account.
                                            </div><!-- End .card-body -->
   ");
                WriteLiteral(@"                                     </div><!-- End .collapse -->
                                    </div><!-- End .card -->

                                    <div class=""card"">
                                        <div class=""card-header"" id=""heading-2"">
                                            <h2 class=""card-title"">
                                                <a class=""collapsed"" role=""button"" data-toggle=""collapse"" href=""#collapse-2"" aria-expanded=""false"" aria-controls=""collapse-2"">
                                                    Check payments
                                                </a>
                                            </h2>
                                        </div><!-- End .card-header -->
                                        <div id=""collapse-2"" class=""collapse"" aria-labelledby=""heading-2"" data-parent=""#accordion-payment"">
                                            <div class=""card-body"">
                                                Ipsum ");
                WriteLiteral(@"dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque volutpat mattis eros. Nullam malesuada erat ut turpis.
                                            </div><!-- End .card-body -->
                                        </div><!-- End .collapse -->
                                    </div><!-- End .card -->

                                    <div class=""card"">
                                        <div class=""card-header"" id=""heading-3"">
                                            <h2 class=""card-title"">
                                                <a class=""collapsed"" role=""button"" data-toggle=""collapse"" href=""#collapse-3"" aria-expanded=""false"" aria-controls=""collapse-3"">
                                                    Cash on delivery
                                                </a>
                                            </h2>
                                        </div><!-- End .card-header -->
                                        <div id=""collapse-3"" c");
                WriteLiteral(@"lass=""collapse"" aria-labelledby=""heading-3"" data-parent=""#accordion-payment"">
                                            <div class=""card-body"">
                                                Quisque volutpat mattis eros. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque volutpat mattis eros.
                                            </div><!-- End .card-body -->
                                        </div><!-- End .collapse -->
                                    </div><!-- End .card -->

                                    <div class=""card"">
                                        <div class=""card-header"" id=""heading-4"">
                                            <h2 class=""card-title"">
                                                <a class=""collapsed"" role=""button"" data-toggle=""collapse"" href=""#collapse-4"" aria-expanded=""false"" aria-controls=""collapse-4"">
                                                    PayPal <small class=""float-right paypal-link"">What is");
                WriteLiteral(@" PayPal?</small>
                                                </a>
                                            </h2>
                                        </div><!-- End .card-header -->
                                        <div id=""collapse-4"" class=""collapse"" aria-labelledby=""heading-4"" data-parent=""#accordion-payment"">
                                            <div class=""card-body"">
                                                Nullam malesuada erat ut turpis. Suspendisse urna nibh, viverra non, semper suscipit, posuere a, pede. Donec nec justo eget felis facilisis fermentum.
                                            </div><!-- End .card-body -->
                                        </div><!-- End .collapse -->
                                    </div><!-- End .card -->

                                    <div class=""card"">
                                        <div class=""card-header"" id=""heading-5"">
                                            <h2 class=""card-title"">
  ");
                WriteLiteral(@"                                              <a class=""collapsed"" role=""button"" data-toggle=""collapse"" href=""#collapse-5"" aria-expanded=""false"" aria-controls=""collapse-5"">
                                                    Credit Card (Stripe)
                                                    <img src=""assets/images/payments-summary.png"" alt=""payments cards"">
                                                </a>
                                            </h2>
                                        </div><!-- End .card-header -->
                                        <div id=""collapse-5"" class=""collapse"" aria-labelledby=""heading-5"" data-parent=""#accordion-payment"">
                                            <div class=""card-body"">
                                                Donec nec justo eget felis facilisis fermentum.Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque volutpat mattis eros. Lorem ipsum dolor sit ame.
                                            ");
                WriteLiteral(@"</div><!-- End .card-body -->
                                        </div><!-- End .collapse -->
                                    </div><!-- End .card -->
                                </div><!-- End .accordion -->

                                <button type=""submit"" class=""btn btn-outline-primary-2 btn-order btn-block"">
                                    <span class=""btn-text"">Place Order</span>
                                    <span class=""btn-hover-text"">Proceed to Checkout</span>
                                </button>
                            </div><!-- End .summary -->
                        </aside><!-- End .col-lg-3 -->
                    </div><!-- End .row -->
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral("\r\n            </div><!-- End .container -->\r\n        </div><!-- End .checkout -->\r\n    </div><!-- End .page-content -->\r\n</main><!-- End .main -->\r\n");
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
