#pragma checksum "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\AlacakGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2410aa8d320f95d4969161fbdd8e7f65648bf1d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AlacakGetir), @"mvc.1.0.view", @"/Views/Home/AlacakGetir.cshtml")]
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
#line 2 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\_ViewImports.cshtml"
using AlacakVerecekTakip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2410aa8d320f95d4969161fbdd8e7f65648bf1d6", @"/Views/Home/AlacakGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18c424fa27a8681bffc3a675a91185975d5540d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AlacakGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlacakVerecekTakip.Models.CariHesaplarTablosu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\AlacakGetir.cshtml"
  
    ViewData["Title"] = "AlacakGetir";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\AlacakGetir.cshtml"
 using (Html.BeginForm("AlacakEkle", "Home", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"display:none\">       \r\n        ");
#nullable restore
#line 12 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\AlacakGetir.cshtml"
   Write(Html.TextBoxFor(x => x.ID, new { @required = "required", @class = "form-control", @placeholder = "0.00 TL" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group mb-3\">\r\n        <b>Alacak Ekle</b>\r\n        ");
#nullable restore
#line 16 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\AlacakGetir.cshtml"
   Write(Html.TextBoxFor(x => x.AlacakMiktar, new { @required = "required", @class = "form-control", @placeholder = "0.00 TL" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <button class=\"form-control btn btn-primary submit px-3\">Alacak Ekle</button>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\AlacakGetir.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlacakVerecekTakip.Models.CariHesaplarTablosu> Html { get; private set; }
    }
}
#pragma warning restore 1591
