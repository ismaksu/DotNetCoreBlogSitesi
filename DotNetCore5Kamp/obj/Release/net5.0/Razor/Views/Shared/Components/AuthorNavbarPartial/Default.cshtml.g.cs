#pragma checksum "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Shared\Components\AuthorNavbarPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af35c9d21f23dc560a6e0e26896b74bb401d0291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AuthorNavbarPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AuthorNavbarPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af35c9d21f23dc560a6e0e26896b74bb401d0291", @"/Views/Shared/Components/AuthorNavbarPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d98be6bfa47631ca2cfc71b0f659091e3354a3e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AuthorNavbarPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<nav class=\"sidebar sidebar-offcanvas\" id=\"sidebar\">\r\n    <ul class=\"nav\">\r\n        <li class=\"nav-item nav-profile\">\r\n            <a href=\"#\" class=\"nav-link\">\r\n                <div class=\"nav-profile-image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 237, "\"", 257, 1);
#nullable restore
#line 7 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Shared\Components\AuthorNavbarPartial\Default.cshtml"
WriteAttributeValue("", 243, ViewBag.image, 243, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"profile\">\r\n                </div>\r\n                <div class=\"nav-profile-text d-flex flex-column\">\r\n                    <span class=\"font-weight-bold mb-2\">");
#nullable restore
#line 10 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Shared\Components\AuthorNavbarPartial\Default.cshtml"
                                                   Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"text-secondary text-small\">");
#nullable restore
#line 11 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Shared\Components\AuthorNavbarPartial\Default.cshtml"
                                                       Write(ViewBag.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
                <i class=""mdi mdi-bookmark-check text-success nav-profile-badge""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Dashboard/Index/"">
                <span class=""menu-title"">Dashboard</span>
                <i class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Author/Index/"">
                <span class=""menu-title"">Profilim</span>
                <i class=""mdi mdi-account-outline menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/BlogListByAuthor/"">
                <span class=""menu-title"">Bloglarım</span>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/BlogAdd/"">
                <span class=""menu-title"">");
            WriteLiteral(@"Yeni Blog</span>
                <i class=""mdi mdi-hospital menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Message/Inbox/"">
                <span class=""menu-title"">Mesaj ~ Gelen Kutusu</span>
                <i class=""mdi mdi-message-text-outline menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Message/Sendbox/"">
                <span class=""menu-title"">Mesaj ~ Giden Kutusu</span>
                <i class=""mdi mdi-message-reply-text menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Notification/NotificationList/"">
                <span class=""menu-title"">Bildirimler</span>
                <i class=""mdi mdi-bell-outline menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Index/"">
                <span class=""menu-title""");
            WriteLiteral(@">Siteye Git</span>
                <i class=""mdi mdi-home-variant-outline menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Login/LogOut/"">
                <span class=""menu-title"">Çıkış Yap</span>
                <i class=""mdi mdi mdi-exit-to-app menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item sidebar-actions"">
            <span class=""nav-link"">
                <div class=""border-bottom"">
                    <h6 class=""font-weight-normal mb-3"">İşlemler</h6>
                </div>
                <a href=""/Blog/BlogAdd/"" class=""btn btn-block btn-lg btn-gradient-primary mt-4"">+ Yeni Blog</a>
                <a href=""/Author/AuthorEditProfile/"" style=""margin-top: 10px !important;"" class=""btn btn-block btn-lg btn-gradient-dark mt-4"">Ayarlar</a>
            </span>
        </li>
    </ul>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591