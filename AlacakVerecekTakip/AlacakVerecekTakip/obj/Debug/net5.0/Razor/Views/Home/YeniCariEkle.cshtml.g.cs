#pragma checksum "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed956fed951a95f6e9c8cdc59a7b87df6788da94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_YeniCariEkle), @"mvc.1.0.view", @"/Views/Home/YeniCariEkle.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed956fed951a95f6e9c8cdc59a7b87df6788da94", @"/Views/Home/YeniCariEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18c424fa27a8681bffc3a675a91185975d5540d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_YeniCariEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlacakVerecekTakip.Models.CariHesaplarTablosu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
  
    ViewData["Title"] = "YeniCariEkle";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int id = (int)Context.Session.GetInt32("id");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed956fed951a95f6e9c8cdc59a7b87df6788da944522", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"form-group mb-3\">\r\n\r\n        <b>Ad</b>\r\n        ");
#nullable restore
#line 14 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
   Write(Html.TextBoxFor(x => x.Ad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group mb-3\">\r\n\r\n        <b>Soyad</b>\r\n        ");
#nullable restore
#line 20 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
   Write(Html.TextBoxFor(x => x.Soyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group mb-3\">\r\n\r\n        <b>Telefon</b>\r\n        ");
#nullable restore
#line 26 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
   Write(Html.TextBoxFor(x => x.Telefon, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group mb-3\">\r\n\r\n        <b>Adres</b>\r\n        ");
#nullable restore
#line 32 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
   Write(Html.TextAreaFor(x => x.Adres, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n    <div style=\"display:none\">\r\n        ");
#nullable restore
#line 36 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
   Write(Html.DropDownListFor(x => x.uyelerTablosu.ID, (List<SelectListItem>)ViewBag.dgr));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    </div>\r\n    ");
#nullable restore
#line 38 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
Write(Html.HiddenFor(x => x.AlacakMiktar, new { @value = "0,00" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 39 "C:\Users\Toshiba\Source\Repos\AlacakVerecekTakip\AlacakVerecekTakip\Views\Home\YeniCariEkle.cshtml"
Write(Html.HiddenFor(x => x.VerecekMiktar, new { @value = "0,00" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div style=""display:none"">
        <input type=""text"" name=""AlacakVerecek"" value=""Yok"" />
        <input type=""text"" name=""Durum"" value=""True"" />
    </div>

    <div class=""form-group mb-3"">

        <button class=""btn btn-info"">Cari Hesap Ekle</button>

    </div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
