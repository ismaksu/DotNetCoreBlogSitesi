#pragma checksum "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b43a44176afe2d16f7093e1a78814bbe0f4c5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCore5Kamp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCore5Kamp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCore5Kamp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b43a44176afe2d16f7093e1a78814bbe0f4c5e5", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d175629d92c1964a27e0dca726a0a583d8b991e4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(" \r\n");
#nullable restore
#line 7 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>

<div class=""card"">
    <div class=""card-header"">
        <h4>Kategori Listesi</h4>
    </div>
    <div class=""card-body"">
        <table class=""table table-hover"">
            <tr>
                <th>#</th>
                <th>Kategori Adı</th>
                <th>İşlemler</th>
            </tr>
");
#nullable restore
#line 25 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><b>");
#nullable restore
#line 28 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
                      Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button id=\"btnDelete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 851, "\"", 892, 3);
            WriteAttributeValue("", 861, "submitControl(", 861, 14, true);
#nullable restore
#line 31 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 875, item.CategoryID, 875, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 891, ")", 891, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger"">
                            <i class=""fa fa-toggle-off rounded-left""></i>
                            Pasif Yap
                        </button> &nbsp;
                        <a href=""#"" class=""btn btn-warning"">
                            <i class=""fa fa-edit rounded-right""></i>
                            Düzenle
                        </a>
                    </td>
                </tr>
");
#nullable restore
#line 41 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <br />\r\n        <a class=\"btn btn-info\" href=\"/Admin/Category/AddCategory/\">Yeni Kategori</a>\r\n        <br />\r\n        <br />\r\n        ");
#nullable restore
#line 47 "C:\Users\Ismail\Desktop\Yazılım\DERSLER\.NET CORE\.NET Core 5.0 Proje Kampı\Ders 133-Final\DotNetCore5Kamp\Areas\Admin\Views\Category\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

</div>

<script>
    function submitControl(id) {
        swal(""Dikkat!"", ""Bu Kategoriyi Pasif Yapmak İstediğinize Emin Misiniz?"",
            {
                icon: 'warning',
                buttons: ['İptal', ""Evet""],
                dangerMode: true
            })
            .then((silinecek) => {
                if (silinecek) {
                    window.location.href = '/Admin/Category/DeleteCategory/' + id;
                }
            });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
