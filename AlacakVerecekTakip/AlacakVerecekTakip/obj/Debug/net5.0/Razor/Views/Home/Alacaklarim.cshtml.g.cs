#pragma checksum "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d1b16c053804d04f3e8105ed3aa8ac71d73ac38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Alacaklarim), @"mvc.1.0.view", @"/Views/Home/Alacaklarim.cshtml")]
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
#line 1 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\_ViewImports.cshtml"
using AlacakVerecekTakip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
using AlacakVerecekTakip.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d1b16c053804d04f3e8105ed3aa8ac71d73ac38", @"/Views/Home/Alacaklarim.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18c424fa27a8681bffc3a675a91185975d5540d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Alacaklarim : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.PagedList<CariHesaplarTablosu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
  
    ViewData["Title"] = "Alacaklarim";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">

    <br />

    <table class=""table table-hover"">

        <tr>
            <th style=""text-align:center"">ID</th>
            <th style=""text-align:center"">Ad</th>
            <th style=""text-align:center"">Soyad</th>
            <th style=""text-align:center"">Telefon</th>
            <th style=""text-align:center"">Adres</th>
            <th style=""text-align:center"">Toplam Alacak Miktar</th>
        </tr>

");
#nullable restore
#line 26 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
               Write(x.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
               Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
               Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
               Write(x.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
               Write(x.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
               Write(x.AlacakMiktar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>\r\n");
#nullable restore
#line 43 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\Alacaklarim.cshtml"
Write(Html.PagedListPager((IPagedList)Model, s => Url.Action("Alacaklarim", new { s })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.PagedList<CariHesaplarTablosu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
