#pragma checksum "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\ELedger\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6000a25ab1c93ffc1a8fe6a4129ef13895c41d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ELedger_Index), @"mvc.1.0.view", @"/Views/ELedger/Index.cshtml")]
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
#line 1 "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\_ViewImports.cshtml"
using HundurWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\_ViewImports.cshtml"
using HundurWEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6000a25ab1c93ffc1a8fe6a4129ef13895c41d2", @"/Views/ELedger/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"023bc0ac507040e7d7450e49e031c1b7bea492b1", @"/Views/_ViewImports.cshtml")]
    public class Views_ELedger_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\ELedger\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""ttm-page-title-row"">
    <div class=""ttm-page-title-row-inner ttm-bgcolor-darkgrey"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-12"">
                    <div class=""page-title-heading"">
                        <h2 class=""title"">E-DEFTER</h2>
                    </div>
                    <div class=""breadcrumb-wrapper"">
                        <span>
                            <i class=""ti ti-home margin_right1""></i>
                            <a title=""Homepage""");
            BeginWriteAttribute("href", " href=\"", 608, "\"", 642, 1);
#nullable restore
#line 16 "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\ELedger\Index.cshtml"
WriteAttributeValue("", 615, Url.Action("Index","Home"), 615, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">ANA SAYFA</a>
                        </span>
                        <span>E-DEFTER</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""site-main"">


    <div class=""ttm-row sidebar ttm-sidebar-left ttm-bgcolor-white overflow-hidden clearfix"">
        <div class=""container"">
            <!-- row -->
            <div class=""row"">
                <div class=""col-lg-4 widget-area sidebar-left ttm-col-bgcolor-yes ttm-bg ttm-left-span ttm-bgcolor-grey mt_80 padding_top80 mb_80 padding_bottom80 res-991-margin_top0 res-991-padding_top0"">
                    <div class=""ttm-col-wrapper-bg-layer ttm-bg-layer""></div>
                    <aside class=""widget widget-nav-menu with-title"">
                        <h3 class=""widget-title"">E-????z??mler</h3>
                        <ul>
                            

                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1580, "\"", 1621, 1);
#nullable restore
#line 39 "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\ELedger\Index.cshtml"
WriteAttributeValue("", 1587, Url.Action("E??rsaliye","ELedger"), 1587, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">E-??rsaliye</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1678, "\"", 1718, 1);
#nullable restore
#line 40 "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\ELedger\Index.cshtml"
WriteAttributeValue("", 1685, Url.Action("Einvoice","ELedger"), 1685, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">E-Fatura</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1773, "\"", 1810, 1);
#nullable restore
#line 41 "C:\Users\saran\Source\Repos\HundurWeb-1.1.0\HundurWEB\Views\ELedger\Index.cshtml"
WriteAttributeValue("", 1780, Url.Action("Index","ELedger"), 1780, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">E-Defter</a></li>
                        </ul>
                    </aside>
                    <aside class=""widget contact-widget with-title"">
                        <h3 class=""widget-title""></h3>
                        <ul class=""contact-widget-wrapper"">
                            <li><i class=""ttm-textcolor-skincolor ti ti-email""></i><a href=""mailto:info@asal.com.tr"" target=""_blank"">info@asal.com.tr</a></li>
                            <li><i class=""ttm-textcolor-skincolor ti ti-mobile""></i>0 532 598 94 42</li>
                            <li><i class=""ttm-textcolor-skincolor ti ti-location-pink""></i>Merkez Mah. ??aml?? Sokak Erg??l ??ak??c?? ???? Merkezi No: 27 /42 Avc??lar / ??stanbul</li>
                        </ul>
                    </aside>
                </div>
                <div class=""col-lg-8 content-area"">
                    <div class=""ttm-service-single-content-area"">
                        <div class=""ttm-featured-wrapper margin_bottom40"">
                            <img c");
            WriteLiteral("lass=\"img-fluid\" src=\"images/services/edeftr.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2884, "\"", 2890, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""100%"" width=""100%"">
                        </div>
                        <div class=""ttm-service-description"">
                            <h3>About Signage Services</h3>
                            <p>
                                E-Defterle birlikte i?? ak??????m??zda baz?? de??i??iklikler  oldu bunlardan birincisi Belge Detay?? yani d??zenlenmi?? olan her muhasebe fi??ine ait belgenin ayr??ca detaylar??n??n yaz??ld?????? bir ortam diyebiliriz.
                                Belge Detay??nda ise istenenler  a??a????da ki gibidir.<br />
                                Belge Tarihi,<br />
                                Belge No,<br />
                                Belge T??r??,<br />
                                ??deme ??ekli<br />
                            </p>
                            <div class=""ttm-horizontal_sep width-100 margin_top35 margin_bottom25""></div>
                            <div class=""row"">
                                <div class=""col-md-8"">
                                 ");
            WriteLiteral(@"                                      <p>
                                        ??kinci bir de??i??iklik ise E-defterlerin d??zenlenme zaman??n oldu. ??nceden genellikle Mali d??nem bittikten sonra takip eden 6. Ay??n son g??n??ne kadar yaz??lmas?? gerekirdi ka????t Defterlerin. ??imdi ise bu ayl??k duruma d??n????m???? durumdad??r. Her ay??n E-Defteri  Hem Yevmiye hem Kebir olarak takip eden 3. Ay??n son g??n?? Beratlar??n??n GIB??? e y??klenmesi gerekmektedir.
                                        ??rne??in 2016 Ocak Ay??na Ait Defter 2016 Nisan Ay??nda Tamamlan??p Beratlar??n??n Y??klenmesi Gerekmektedir.
                                    </p>
                                </div>
                                <div class=""col-md-4"">
                                 <div class=""ttm-featured-wrapper margin_bottom40"">
                            <img class=""img-fluid"" src=""images/services/edeftr.png""");
            BeginWriteAttribute("alt", " alt=\"", 4805, "\"", 4811, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""100%"" width=""100%"">
                        </div>
                                </div>
                            </div>
                            <div class=""ttm-horizontal_sep width-100 margin_top35 margin_bottom35""></div>
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <img class=""img-fluid"" src=""images/eee.png"" alt=""image"" height=""100%"" width=""100%"">
                                </div>
                                <div class=""col-md-8"">
                                    <div class=""res-767-margin_top30"">
                                        <p>
                                            ??rne??in 2016 Ocak Ay??na Ait Defter 2016 Nisan Ay??nda Tamamlan??p Beratlar??n??n Y??klenmesi Gerekmektedir.
                                            2016 ??ubat ise 2016 May??s Ay??nda Tamamlan??p Beratlar??n??n Y??klenmesi Gerekmektedir.
                                            Burada genelde olu??an ");
            WriteLiteral(@"bir yanl???? alg??y?? d??zeltmeye ??al??y??m. Asl??nda GIB bizim d??zenlemi?? oldu??umuz E-Defteri talep etmiyor. Sadece E-Defterlere ait olu??turulan Berat (Yani Etiket Bilgisi) Dosyalar??n?? y??klememizi istiyor. Dolay??s??yla GIB sisteminde Yevmiye ve Kebirler bulunmuyor. Maliye???den yada Vergi dairesinden  Talep edildi??i takdir de Daha ??nce GIB??? e y??klenmi?? oldu??umuz beratlarla beraber Yevmiye ve Kebir Defterlerini isteyen kurumlara ula??t??r??yoruz.
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div><!-- row end -->
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
