#pragma checksum "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b825b02f7c808fc1064f09718ad92e4aaafacca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_GuideMediatR_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/GuideMediatR/Index.cshtml")]
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
#line 1 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Tourism_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Tourism_Project.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Dto.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Tourism_Project.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Tourism_Project.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Tourism_Project.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\_ViewImports.cshtml"
using Tourism_Project.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b825b02f7c808fc1064f09718ad92e4aaafacca6", @"/Areas/Admin/Views/GuideMediatR/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3caaae9a3888ab833992ded8e9b2dcec06d2ed8", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_GuideMediatR_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllGuideQueryResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>CQRS MediatR Rehber Listesi</h3>\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>#</th>\n        <th>Görsel</th>\n        <th>Rehber Adı</th>\n        <th>Açıklama</th>\n        <th>Sil</th>\n        <th>Güncelle</th>\n    </tr>\n");
#nullable restore
#line 17 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 21 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><img");
            BeginWriteAttribute("src", " src=\"", 472, "\"", 489, 1);
#nullable restore
#line 22 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
WriteAttributeValue("", 478, item.Image, 478, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" /></td>\n    <td>");
#nullable restore
#line 23 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 24 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 587, "\"", 639, 2);
            WriteAttributeValue("", 594, "/Admin/GuideMediatR/DeleteGuide/", 594, 32, true);
#nullable restore
#line 25 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
WriteAttributeValue("", 626, item.GuideID, 626, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 695, "\"", 745, 2);
            WriteAttributeValue("", 702, "/Admin/GuideMediatR/GetGuides/", 702, 30, true);
#nullable restore
#line 26 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
WriteAttributeValue("", 732, item.GuideID, 732, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\n</tr>\n");
#nullable restore
#line 28 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\GuideMediatR\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<a href=\"/Admin/GuideMediatR/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Girişi</a>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllGuideQueryResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591
