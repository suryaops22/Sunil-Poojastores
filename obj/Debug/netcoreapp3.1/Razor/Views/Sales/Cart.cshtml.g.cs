#pragma checksum "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "582c9f68d37033a594c976175960cdc3c99a7587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Cart), @"mvc.1.0.view", @"/Views/Sales/Cart.cshtml")]
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
#line 1 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"582c9f68d37033a594c976175960cdc3c99a7587", @"/Views/Sales/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PoojaStores.Models.Repositories.Entity.CartDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sales/CheckOut"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
  
    decimal totalPrice = 0;
    decimal tx =0;
    decimal totwithTax = 0;
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"main\">\n    <div class=\"container\">\n");
            WriteLiteral("    <br />\n    <br />\n");
#nullable restore
#line 23 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
         if (ViewBag.CartCount > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""cart-table-container"">
                    <table class=""table table-cart"">
                        <thead>
                            <tr>
                                <th class=""thumbnail-col""></th>
                                <th class=""product-col"">Product</th>
                                <th class=""price-col"">Price</th>
                                <th class=""qty-col"">Quantity</th>
                                <th class=""text-right"">Subtotal</th>
                                <th class=""text-right"">Add to wishList</th>
                                <th class=""text-right"">Remove</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 41 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                             foreach (var p in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"product-row\">\n                                <td>\n                                    <figure class=\"product-image-container\">\n\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "582c9f68d37033a594c976175960cdc3c99a75878877", async() => {
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "582c9f68d37033a594c976175960cdc3c99a75879172", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1991, "~/ProductImages/", 1991, 16, true);
#nullable restore
#line 48 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
AddHtmlAttributeValue("", 2007, p.Image1, 2007, 9, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1875, "~/Home/ProductDetails?id=", 1875, 25, true);
#nullable restore
#line 47 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
AddHtmlAttributeValue("", 1900, p.ProductId, 1900, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                    </figure>\n");
            WriteLiteral("                                </td>\n                                <td class=\"product-col\">\n                                    <h5 class=\"product-title\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "582c9f68d37033a594c976175960cdc3c99a758712630", async() => {
#nullable restore
#line 56 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                                                                   Write(p.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2468, "~/Home/ProductDetails?id=", 2468, 25, true);
#nullable restore
#line 56 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
AddHtmlAttributeValue("", 2493, p.ProductId, 2493, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </h5>\n                                </td>\n                                <td>");
#nullable restore
#line 59 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                Write(String.Format(Indian, "{0:N}", p.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>
                                    <div class=""product-single-qty"">
                                        <div class=""input-group"">
                                            <input type=""button"" value=""-"" class=""button-minus border rounded-circle  icon-shape icon-sm mx-1 "" data-field=""quantity""");
            BeginWriteAttribute("onclick", " onclick=\"", 3021, "\"", 3056, 3);
            WriteAttributeValue("", 3031, "minuCart(", 3031, 9, true);
#nullable restore
#line 63 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
WriteAttributeValue("", 3040, p.CartDetailId, 3040, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3055, ")", 3055, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                            <input step=\"1\" max=\"10\"");
            BeginWriteAttribute("id", " id=\"", 3127, "\"", 3152, 2);
            WriteAttributeValue("", 3132, "ccnt_", 3132, 5, true);
#nullable restore
#line 64 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
WriteAttributeValue("", 3137, p.CartDetailId, 3137, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3153, "\"", 3178, 1);
#nullable restore
#line 64 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
WriteAttributeValue("", 3161, p.NumberProducts, 3161, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"quantity\" class=\"quantity-field border-0 text-center w-25\" readonly>\n                                            <input type=\"button\" value=\"+\" class=\"button-plus border rounded-circle icon-shape icon-sm \" data-field=\"quantity\"");
            BeginWriteAttribute("onclick", "onclick=\"", 3413, "\"", 3447, 3);
            WriteAttributeValue("", 3422, "plusCart(", 3422, 9, true);
#nullable restore
#line 65 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
WriteAttributeValue("", 3431, p.CartDetailId, 3431, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3446, ")", 3446, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                        </div>\n                                    </div>\n");
            WriteLiteral("                                </td>\n");
#nullable restore
#line 71 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                  
                                    var price = p.Price * p.NumberProducts;
                                    totalPrice += (decimal)price;
                                    var singletax = p.GStPrice * p.NumberProducts;
                                    tx += (decimal)singletax;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"text-right\"><span class=\"subtotal-price\"");
            BeginWriteAttribute("id", " id=\"", 4169, "\"", 4195, 2);
            WriteAttributeValue("", 4174, "singleTotal_", 4174, 12, true);
#nullable restore
#line 77 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
WriteAttributeValue("", 4186, p.CartId, 4186, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                                                                                           Write(String.Format(Indian, "{0:N}", price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                <td class=\"text-right\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "582c9f68d37033a594c976175960cdc3c99a758718825", async() => {
                WriteLiteral("Move to Wishlist");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4315, "~/Sales/MoveToWishlist?id=", 4315, 26, true);
#nullable restore
#line 78 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
AddHtmlAttributeValue("", 4341, p.CartDetailId, 4341, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                                <td class=\"text-right\">\n                                    <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4535, "\"", 4572, 3);
            WriteAttributeValue("", 4545, "ShowDelete(", 4545, 11, true);
#nullable restore
#line 80 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
WriteAttributeValue("", 4556, p.CartDetailId, 4556, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4571, ")", 4571, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <button type=""button"" class=""btn btn-danger btn-sm"" data-toggle=""modal"">
                                            <i class=""fa fa-trash""></i>
                                        </button>
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 87 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                    }                           

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                        <!--<tfoot>
                            <tr>
                                <td colspan=""5"" class=""clearfix"">
                                    <div class=""float-left"">
                                        <div class=""cart-discount"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "582c9f68d37033a594c976175960cdc3c99a758722039", async() => {
                WriteLiteral(@"
                                                <div class=""input-group"">
                                                    <input type=""text"" class=""form-control form-control-sm""
                                                           placeholder=""Coupon Code"" required>
                                                    <div class=""input-group-append"">
                                                        <button class=""btn btn-sm"" type=""submit"">
                                                            Apply
                                                            Coupon
                                                        </button>
                                                    </div>
                                                </div>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                    </div>

                                    <div class=""float-right"">
                                        <button type=""submit"" class=""btn btn-shop btn-update-cart"">
                                            Update Cart
                                        </button>
                                    </div>
                                <!--</td>
                            </tr>
                        </tfoot>-->
                    </table>
                </div><!-- End .cart-table-container -->
            </div><!-- End .col-lg-8 -->

            <div class=""col-lg-4 "">
                <div class=""cart-summary"">
                    <h4>CART TOTAL</h4>

                    <table class=""table table-totals"">
                        <tbody>
                            <tr>
                                <td>Subtotal</td>
                                <td><h5>");
#nullable restore
#line 129 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                    Write(String.Format(Indian, "{0:N}", totalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\n                            </tr>\n                            <tr>\n                                <td>Tax Amount</td>\n                                <td><h5>");
#nullable restore
#line 133 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                    Write(String.Format(Indian, "{0:N}", tx));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\n                            </tr>                      \n                        </tbody>\n");
#nullable restore
#line 136 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                           totwithTax = totalPrice + tx;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tfoot>\n                            <tr>\n                                <td>Total With Taxes</td>\n                                <td><h5>");
#nullable restore
#line 140 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                                    Write(String.Format(Indian, "{0:N}", totwithTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\n                            </tr>\n                        </tfoot>\n                    </table>\n");
#nullable restore
#line 144 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"checkout-methods\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "582c9f68d37033a594c976175960cdc3c99a758727098", async() => {
                WriteLiteral("\n                            Proceed to Checkout\n                            <i class=\"fa fa-arrow-right\"></i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 152 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </div><!-- End .cart-summary -->\n            </div><!-- End .col-lg-4 -->\n        </div><!-- End .row -->\n");
#nullable restore
#line 158 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "582c9f68d37033a594c976175960cdc3c99a758728989", async() => {
                WriteLiteral("Go Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 162 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div><!-- End .container -->\n\n    <div class=\"mb-6\"></div><!-- margin -->\n</main>\n");
            WriteLiteral("<script>\n    //var oldtotal =");
#nullable restore
#line 201 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Sales/Cart.cshtml"
               Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    function ShowDelete(id) {
        swal(""Are you sure?"", {
            buttons: {
                yes: {
                    text: ""Yes"",
                    value: ""yes""
                },
                no: {
                    text: ""No"",
                    value: ""no""
                }
            }
        }).then((value) => {
            if (value === ""yes"") {
                $.ajax({
                    url: GlobalUrl + ""Sales/DeleteCart?id="" + id,
                    type: 'post',
                    data: '{}',
                    success: function (result) {
                        toastr[""success""](""Successuflly deleted!"");
                        window.location.href = window.location.href;
                    }
                });
            }
            else {
                toastr[""error""](""Delete cancelled!"");
            };
        });
    }
    function updCrt(id) {
        var newcnt = $(""#ccnt_"" + id).val();
        $.ajax({
            url: GlobalUrl + ""Sales/UpdateCart?cartId=");
            WriteLiteral(@""" + id + ""&newCnt="" + newcnt,
            type: 'post',
            date: '{}',
            success: function (res) {
                if (res.result.statusCode == 1) {
                    toastr[""success""](""Successuflly Updated"");
                    window.location.href = window.location.href;
                } else {
                    toastr[""error""](res.result.statusMessage);
                }
            }
        })
    }
    function minuCart(id) {
        var newcnt = $(""#ccnt_"" + id).val();        
        if (newcnt != '1') {
            var cnt = parseInt(newcnt) - 1;
            $.ajax({
                url: GlobalUrl + ""Sales/UpdateCart?cartId="" + id + ""&newCnt="" + cnt,
                type: 'post',
                date: '{}',
                success: function (res) {
                    if (res.result.statusCode == 1) {
                        //toastr[""success""](""Successuflly Updated"");
                        //var mul = cnt * price;
                        //var str = mul.toString();
       ");
            WriteLiteral(@"                 //$(""#singleTotal_"" + id).text(str + "".00"");
                        //var tot = oldtotal;
                        //var newtot = tot - price;
                        //var nt = newtot + "".00"";
                        //$(""#tot"").text(nt);
                        //oldtotal = newtot;
                        //$(""#ccnt_"" + id).val(cnt);
                        window.location.href=window.location.href;
                    } else {
                        toastr[""error""](res.result.statusMessage);
                    }
                }
            })
        } else {
            toastr[""error""](""Min Order Qty Should be 1"");
        }
    }
    function plusCart(id) {
        var newcnt = $(""#ccnt_"" + id).val();
        var cnt = parseInt(newcnt) + 1;
        $.ajax({
            url: GlobalUrl + ""Sales/UpdateCart?cartId="" + id + ""&newCnt="" + cnt,
            type: 'post',
            date: '{}',
            success: function (res) {
                if (res.result.statusCode == 1) {
           ");
            WriteLiteral(@"         //toastr[""success""](""Successuflly Updated"");
                    //var mul = cnt * price;
                    //var str = mul.toString();
                    //$(""#singleTotal_"" + id).text(str + "".00"");
                    //var tot = oldtotal;
                    //var newtot = tot + price;
                    //var nt = newtot + "".00"";
                    //$(""#tot"").text(nt);
                    //oldtotal = newtot;
                    //$(""#ccnt_"" + id).val(cnt);
                    window.location.href=window.location.href;
                } else {
                    toastr[""error""](res.result.statusMessage);
                }
            }
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PoojaStores.Models.Repositories.Entity.CartDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
