#pragma checksum "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b2bb7cae585bd1a6aa6068d0a1b7261bd3ad1ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogEdit), @"mvc.1.0.view", @"/Views/Blog/BlogEdit.cshtml")]
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
#line 1 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\_ViewImports.cshtml"
using DotNetCore5Kamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\_ViewImports.cshtml"
using DotNetCore5Kamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b2bb7cae585bd1a6aa6068d0a1b7261bd3ad1ca", @"/Views/Blog/BlogEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d98be6bfa47631ca2cfc71b0f659091e3354a3e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
  
    ViewData["Title"] = "BlogEdit";
    Layout = "~/Views/Shared/_AuthorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3>Blog Düzenleme Sayfası</h3>\r\n    </div>\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 12 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
         using (Html.BeginForm("BlogEdit", "Blog", FormMethod.Post))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.HiddenFor(x => x.AuthorID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.HiddenFor(x => x.BlogStat));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.TextBoxFor(x => x.BlogID, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n");
#nullable restore
#line 21 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control", @placeholder = "Blog Başlığını Giriniz..", @autocomplete = "off", @spellcheck = "false" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.ValidationMessageFor(x => x.BlogTitle, "", new { @style = "color: red; margin-bottom: 15px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n");
#nullable restore
#line 26 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control", @placeholder = "Görsel URL'si..", @autocomplete = "off", @spellcheck = "false" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.ValidationMessageFor(x => x.BlogImage, "", new { @style = "color: red;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n");
#nullable restore
#line 31 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.Label("Blog Küçük Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.TextBoxFor(x => x.BlogThumbnail, new { @class = "form-control", @placeholder = "Küçük Görsel URL'si..", @autocomplete = "off", @spellcheck = "false" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n");
#nullable restore
#line 35 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.Label("Blog Kategorisi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.categoryValues, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n");
#nullable restore
#line 39 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.TextAreaFor(x => x.BlogContent, 15, 3, new { @class = "form-control", @placeholder = "Bir Blog Yazısı Oluşturun!", @autocomplete = "off" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.ValidationMessageFor(x => x.BlogContent, "", new { @style = "color: red; margin-bottom: 15px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n");
#nullable restore
#line 44 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.Label("Blog Oluşturulma Tarihi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
       Write(Html.TextBoxFor(x => x.BlogCreationDate, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <br />\r\n            <button class=\"btn btn-outline-success\">Değişiklikleri Kaydet</button>\r\n");
#nullable restore
#line 49 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Blog\BlogEdit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
