#pragma checksum "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cadd12f08a042f617613170a032e58b8e10b33d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\_ViewImports.cshtml"
using HundurWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\_ViewImports.cshtml"
using HundurWEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cadd12f08a042f617613170a032e58b8e10b33d7", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"023bc0ac507040e7d7450e49e031c1b7bea492b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact_form wrap-form clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""ttm-page-title-row"">
    <div class=""ttm-page-title-row-inner ttm-bgcolor-darkgrey"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-12"">
                    <div class=""page-title-heading"">
                        <h2 class=""title"">İLETİŞİM</h2>
                    </div>
                    <div class=""breadcrumb-wrapper"">
                        <span>
                            <i class=""ti ti-home margin_right1""></i>
                            <a title=""Homepage""");
            BeginWriteAttribute("href", " href=\"", 610, "\"", 644, 1);
#nullable restore
#line 17 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\Contact\Index.cshtml"
WriteAttributeValue("", 617, Url.Action("Index","Home"), 617, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">ANA SAYFA</a>
                        </span>
                        <span>İLETİŞİM</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-main"">


    <section class=""ttm-row conatact-section clearfix"">
        <div class=""container"">
            <!-- row -->
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- section title -->
                    <div class=""section-title without-seperator title-style-center_text"">
                        <div class=""title-header"">

                            <h2 class=""title""></h2>
                        </div>
                        <div class=""title-desc"">

                        </div>
                    </div><!-- section title end -->
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""padding_right30 res-991-padding_right0 res");
            WriteLiteral("-991-margin_bottom30\">\r\n                        <div class=\"ttm_single_image-wrapper margin_bottom40\">\r\n                            <img class=\"img-fluid w-100\"");
            BeginWriteAttribute("src", " src=\"", 1829, "\"", 1872, 1);
#nullable restore
#line 51 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1835, Url.Content("~/images/svg/ofis.jpg"), 1835, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""single-12"" height=""100%"" width=""100%"">
                        </div>
                        <!--featured-icon-box-->
                        <div class=""featured-icon-box icon-align-before-content style11"">
                            <div class=""featured-icon"">
                                <div class=""ttm-icon ttm-icon_element-fill ttm-icon_element-color-skincolor ttm-icon_element-size-md ttm-icon_element-style-round"">
                                    <i class=""fa fa-phone""></i>
                                </div>
                            </div>
                            <div class=""featured-content"">
                                <div class=""featured-title"">
                                    <h3>Telefon</h3>
                                </div>
                                <div class=""featured-desc"">0 532 598 94 42</div>
                            </div>
                        </div><!-- featured-icon-box end-->
                        <div class=""ttm-horizon");
            WriteLiteral(@"tal_sep width-100 margin_top20 margin_bottom20""></div>
                        <!--featured-icon-box-->
                        <div class=""featured-icon-box icon-align-before-content style11"">
                            <div class=""featured-icon"">
                                <div class=""ttm-icon ttm-icon_element-fill ttm-icon_element-color-skincolor ttm-icon_element-size-md ttm-icon_element-style-round"">
                                    <i class=""fa fa-globe""></i>
                                </div>
                            </div>
                            <div class=""featured-content"">
                                <div class=""featured-title"">
                                    <h3>Email</h3>
                                </div>
                                <div class=""featured-desc"">info@asal.com.tr</div>
                            </div>
                        </div><!-- featured-icon-box end-->
                        <div class=""ttm-horizontal_sep width-100 margi");
            WriteLiteral(@"n_top20 margin_bottom20""></div>
                        <!--featured-icon-box-->
                        <div class=""featured-icon-box icon-align-before-content style11 margin_bottom0"">
                            <div class=""featured-icon"">
                                <div class=""ttm-icon ttm-icon_element-fill ttm-icon_element-color-skincolor ttm-icon_element-size-md ttm-icon_element-style-round"">
                                    <i class=""ti ti-home""></i>
                                </div>
                            </div>
                            <div class=""featured-content"">
                                <div class=""featured-title"">
                                    <h3>Adres</h3>
                                </div>
                                <div class=""featured-desc"">Merkez Mah. Şamlı Sokak Ergül Çakıcı İş Merkezi No: 27 /42 Avcılar / İstanbul</div>
                            </div>
                        </div><!-- featured-icon-box end-->
                  ");
            WriteLiteral(@"  </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""ttm-col-bgcolor-yes ttm-bg ttm-bgcolor-grey z-index-2 p-50 res-991-margin_top30 res-991-p-15"">
                        <div class=""ttm-col-wrapper-bg-layer ttm-bg-layer""></div>
                        <div class=""layer-content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cadd12f08a042f617613170a032e58b8e10b33d711293", async() => {
                WriteLiteral(@"
                                <div class=""row ttm-boxes-spacing-15px"">
                                    <div class=""col-md-12 ttm-box-col-wrapper"">
                                        <label>
                                            <span class=""text-input margin_bottom0""><input name=""name"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 5744, "\"", 5752, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Adiniz"" required=""required""></span>
                                        </label>
                                    </div>
                                    <div class=""col-md-6 ttm-box-col-wrapper"">
                                        <label>
                                            <span class=""text-input margin_bottom0""><input name=""address"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 6144, "\"", 6152, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Email"" required=""required""></span>
                                        </label>
                                    </div>
                                    <div class=""col-md-6 ttm-box-col-wrapper"">
                                        <label>
                                            <span class=""text-input margin_bottom0""><input name=""phone"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 6541, "\"", 6549, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Konu"" required=""required""></span>
                                        </label>
                                    </div>
                                    <div class=""col-md-12 ttm-box-col-wrapper"">
                                        <label>
                                            <span class=""text-input margin_bottom0""><input name=""phone"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 6938, "\"", 6946, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Telefon"" required=""required""></span>
                                        </label>
                                    </div>
                                    <div class=""col-md-12 ttm-box-col-wrapper"">
                                        <label>
                                            <span class=""text-input margin_bottom0""><textarea name=""message"" rows=""3"" placeholder=""Nesajınız"" required=""required""></textarea></span>
                                        </label>
                                    </div>
                                </div>
                                <button class=""submit ttm-btn ttm-btn-size-lg ttm-btn-shape-square ttm-btn-style-fill ttm-btn-color-skincolor w-100"" type=""submit"">Enail Gönder</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div><!-- row end -->\r\n        </div>\r\n    </section>\r\n\r\n</div>\r\n\r\n");
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