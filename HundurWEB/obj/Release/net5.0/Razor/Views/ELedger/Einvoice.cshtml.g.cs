#pragma checksum "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\ELedger\Einvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "660fd64a54a5a3ba2c8e2d0cfcc557124432c27e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ELedger_Einvoice), @"mvc.1.0.view", @"/Views/ELedger/Einvoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660fd64a54a5a3ba2c8e2d0cfcc557124432c27e", @"/Views/ELedger/Einvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"023bc0ac507040e7d7450e49e031c1b7bea492b1", @"/Views/_ViewImports.cshtml")]
    public class Views_ELedger_Einvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\ELedger\Einvoice.cshtml"
  
    ViewData["Title"] = "Einvoice";

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
                        <h2 class=""title"">E-FATURA</h2>
                    </div>
                    <div class=""breadcrumb-wrapper"">
                        <span>
                            <i class=""ti ti-home margin_right1""></i>
                            <a title=""Homepage""");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 647, 1);
#nullable restore
#line 17 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\ELedger\Einvoice.cshtml"
WriteAttributeValue("", 620, Url.Action("Index","Home"), 620, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">ANA SAYFA</a>
                        </span>
                        <span>E-FATURA</span>
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
                        <h3 class=""widget-title"">E-Çözümler</h3>
                        <ul>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1549, "\"", 1590, 1);
#nullable restore
#line 36 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\ELedger\Einvoice.cshtml"
WriteAttributeValue("", 1556, Url.Action("Eİrsaliye","ELedger"), 1556, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">E-İrsaliye</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1647, "\"", 1687, 1);
#nullable restore
#line 37 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\ELedger\Einvoice.cshtml"
WriteAttributeValue("", 1654, Url.Action("Einvoice","ELedger"), 1654, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">E-Fatura</a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1742, "\"", 1779, 1);
#nullable restore
#line 38 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\ELedger\Einvoice.cshtml"
WriteAttributeValue("", 1749, Url.Action("Index","ELedger"), 1749, 30, false);

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
                            <li><i class=""ttm-textcolor-skincolor ti ti-location-pink""></i>Merkez Mah. Şamlı Sokak Ergül Çakıcı İş Merkezi No: 27 /42 Avcılar / İstanbul</li>
                        </ul>
                    </aside>
                </div>
                <div class=""col-lg-8 content-area"">
                    <div class=""ttm-service-single-content-area"">
                        <div class=""ttm-featured-wrapper margin_bottom40"">
                            <img c");
            WriteLiteral("lass=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 2820, "\"", 2871, 1);
#nullable restore
#line 53 "C:\Users\saran\Desktop\HundurWEB\HundurWEB\Views\ELedger\Einvoice.cshtml"
WriteAttributeValue("", 2826, Url.Content("~/images/services/efatura.png"), 2826, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2872, "\"", 2878, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""100%"" width=""100%"">
                        </div>
                        <div class=""ttm-service-description"">
                            <h3>E-Fatura</h3>
                            <p>
                                Gelirler İdaresi Başkanlığının 2013 Yılında devreye soktuğu günden güne kapsamı genişleyerek devam eden ve sonun da bütün mükellefleri kapsayan Kağıt faturaları dijital ortama taşıyan sistemdir.Sistemin Yapısı GIB aracılığı ile işlemektedir.<br /><br />
                                E-Fatura Sistemini Kullanmanın 3 şekli vardır. Bu sistemi tercih etmek tamamen bağımsız ve Mükellefin tercihine bağlıdır.<br /><br />
                                Sistem  GIB Portal Yönetimi : Kullanıcılar düzenlemiş oldukları E-Faturaları Direk GIB’ in vermiş olduğu portal üzerinde de düzenleyip gönderimini sağlayabilirler<br /><br />  
                                Sitem Özel Entegratör : Özel Entegratör ise Mükelleflerin Kendi Ticari programlarında düzenlemiş oldukları faturaların Özel");
            WriteLiteral(@" entegratör üzerinde GIB’e ulaştırdıkları bir sistemdir. Burada 1.Sisteme göre  avantajı özel  Entegratör firmalarının aynı zaman E-Faturaları Saklama zorunluğunu da Mükellefin üzerinden almasıdır<br /><br />
                                Sistem  E-Fatura Sunucu : Bu Sistem Daha yüksek sayıda E-Fatura düzenleyen Mükelleflerin tercih edebilecekleri bir sistemdir. Sunucu Sisteminde Düzenlenen E-Faturalar GIB’ in şartnamelerine uygun bir şekilde hazırlanmış, Türkiye sınırları içerisinde olan Mükellefe ait bir özel Sunucu üzerinden yapılmasıdır. Düzenlenen E-Faturalar Mükellefin Sunucusu üzerinden GIB’ e ulaştırılmaktadır. <br /><br />

                                Burada aklımıza şu soru gelebilir. Bizim Hangisini Kullanmamız gerekiyor.<br /><br />

                                1.Sistem Küçük Çaplı Aylık E-Fatura sayısı (Gönderilen ve Alınan ) toplam 50’yi geçmiyor ise bu yöntem tercih edilebilir.<br /><br />
                                2.Sistem ise Orta ölçekli firmalar için daha uygundur. Ayl");
            WriteLiteral(@"ık E-fatura sayısı 50 ila 10.000 arasında olanlar için tavsiye edilebilir.<br /><br />
                                Son sistem de ise çok sayıda E-Fatura Kesen firmalar için daha uygundur.  Örn: Kargo Firmaları E-Ticaret Firmaları gb.<br /><br />
                                Yukarıdaki resimde E-Fatura işleyişinin bir özetini görüntülemeye çalıştık.<br /><br />
                                Birde değinmek istediğimiz bir konu daha var buda kesilen E-Faturanın ya da alınan E-Faturanın bir onay aşması olup olmadığıdır. Eğer ki kestiğiniz E-Faturaların karşı tarafın onayının alınmasını istiyorsanız. Bu durumda Ticari Fatura düzenlemelisiniz. Karşı tarafın onayına bırakılmaksızın E-fatura göndermek istiyorsanız Temel Fatura düzenlemelisiniz. Bu işlemler için tarafların birbirleri ile önceden uzlaşmaları sağlıklı olucaktır.<br /><br />

                            </p>
                        </div>
                    </div>
                </div>
            </div><!-- row end -->
        </div");
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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