#pragma checksum "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Authenticate/ForgetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f0b6011706556d54748e73fc5dfc97649179040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authenticate_ForgetPassword), @"mvc.1.0.view", @"/Views/Authenticate/ForgetPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0b6011706556d54748e73fc5dfc97649179040", @"/Views/Authenticate/ForgetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f9477a1b535c92b3f32da28b3e1ee3bcdb34e", @"/Views/_ViewImports.cshtml")]
    public class Views_Authenticate_ForgetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.LoginRequestForPWChange>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Authenticate/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Authenticate/ForgetPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<main class=""main"">
    <div class=""container login-container mt-4"">
        <div class=""row"">
            <div class=""col-lg-10 mx-auto"">
                <div class=""row"">
                    <div class=""col-md-3""></div>
                    <div class=""col-md-6"">
                        <div class=""heading mb-1"">
                            <h4 class=""title"">Reset Your Password</h4>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0b6011706556d54748e73fc5dfc976491790404942", async() => {
                WriteLiteral("\n");
                WriteLiteral(@"                            <label for=""login-email"">
                                Mobile Number or Email Address
                                <span class=""required"">*</span>
                            </label>
                            <input type=""text"" name=""emailid"" title=""Enter email / mobile number"" placeholder=""example@gmail.com""");
                BeginWriteAttribute("required", " required=\"", 1006, "\"", 1017, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1018, "\"", 1026, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-input form-wide\">\n                            ");
#nullable restore
#line 20 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Authenticate/ForgetPassword.cshtml"
                       Write(Html.ValidationMessageFor(a => a.emailId, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n\n");
                WriteLiteral("                            <div>\n                                <span class=\"text-danger\">\n                                    ");
#nullable restore
#line 32 "/home/surya/sunil/poojastores/ppojastores/trunk/PoojaStores/Views/Authenticate/ForgetPassword.cshtml"
                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </span>\n                            </div>\n                            <div class=\"form-footer\">\n");
                WriteLiteral("\n");
                WriteLiteral(@"                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <button type=""submit"" class=""btn btn-dark btn-md w-100"">
                                        Reset
                                    </button>
                                </div>
                                <div class=""col-md-6"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f0b6011706556d54748e73fc5dfc976491790407360", async() => {
                    WriteLiteral("\n                                        <button type=\"button\" class=\"btn btn-dark btn-md w-100\">\n                                            Login\n                                        </button>\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                                </div>\n                            </div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div class=\"col-md-3\"></div>\n");
            WriteLiteral("\n                </div>\n\n            </div>\n\n        </div>\n    </div>\n\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.LoginRequestForPWChange> Html { get; private set; }
    }
}
#pragma warning restore 1591
