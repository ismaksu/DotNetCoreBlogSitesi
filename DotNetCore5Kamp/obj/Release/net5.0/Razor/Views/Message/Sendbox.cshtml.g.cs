#pragma checksum "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b34c77d3c05f1aec6db5b91ff940ce7914d706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Sendbox), @"mvc.1.0.view", @"/Views/Message/Sendbox.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b34c77d3c05f1aec6db5b91ff940ce7914d706", @"/Views/Message/Sendbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d98be6bfa47631ca2cfc71b0f659091e3354a3e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Sendbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
  
    ViewData["Title"] = "Sendbox";
    Layout = "~/Views/Shared/_AuthorLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    tr {
        cursor: pointer;
    }
</style>

<div class=""card"">
    <h3 class=""card-header"">Sendbox</h3>
    <div class=""card-body"">
        <h4 class=""card-title"">Giden Mesajlar</h4>

        <table class=""table table-hover"">
            <tr style=""cursor: default !important;"">
                <th>#</th>
                <th>Alıcı</th>
                <th>Mesaj Başlığı</th>
                <th>Mesaj İçeriği</th>
                <th>Mesaj Tarihi</th>
            </tr>
");
#nullable restore
#line 27 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
             foreach (var item in Model)
            {
                string msgTitle = item.MessageTitle;
                string msgCont = item.MessageContent;
                if (item.MessageTitle.Length > 30)
                {
                    msgTitle = item.MessageTitle.Substring(0, 30) + "..";
                }
                if (item.MessageContent.Length > 50)
                {
                    msgCont = item.MessageContent.Substring(0, 50) + "..";
                }

                var totalH = Math.Round((DateTime.Now - item.MessageDate).TotalHours);
                var total = totalH.ToString();
                string zamanTur = "saat önce.";
                if (totalH > 48)
                {
                    total = item.MessageDate.ToString("dd MMMM yyyy ~ HH:mm:ss");

                    zamanTur = "";
                }
                else if (totalH <= 1)
                {
                    var totalM = Math.Round((DateTime.Now - item.MessageDate).TotalMinutes);

                    total = totalM.ToString();
                    zamanTur = "dakika önce.";

                    if (totalM <= 1)
                    {
                        var totalS = Math.Round((DateTime.Now - item.MessageDate).TotalSeconds);

                        total = totalS.ToString();
                        zamanTur = "saniye önce.";
                    }
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 2113, "\"", 2181, 3);
            WriteAttributeValue("", 2123, "window.location=\'/Message/MessageDetails/", 2123, 41, true);
#nullable restore
#line 65 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
WriteAttributeValue("", 2164, item.MessageID, 2164, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2179, "/\'", 2179, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td><b>");
#nullable restore
#line 66 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
                      Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                    <td>\r\n                        <img class=\"profile-pic\"");
            BeginWriteAttribute("src", " src=\"", 2312, "\"", 2348, 1);
#nullable restore
#line 68 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
WriteAttributeValue("", 2318, item.ReceiverUser.AuthorImage, 2318, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                        ");
#nullable restore
#line 69 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
                   Write(item.ReceiverUser.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
                   Write(msgTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
                   Write(msgCont);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
                   Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
                          Write(zamanTur);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Views\Message\Sendbox.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <br />\r\n        <a href=\"/Message/MessageSend/\" class=\"btn btn-gradient-info\">Mesaj Oluştur</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
