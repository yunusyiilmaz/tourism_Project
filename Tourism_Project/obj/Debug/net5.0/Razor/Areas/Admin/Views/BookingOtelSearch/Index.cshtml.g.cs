#pragma checksum "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "209f6f62de87da5cd90ac5b8dd6a00a5c78abb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BookingOtelSearch_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BookingOtelSearch/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209f6f62de87da5cd90ac5b8dd6a00a5c78abb14", @"/Areas/Admin/Views/BookingOtelSearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3caaae9a3888ab833992ded8e9b2dcec06d2ed8", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BookingOtelSearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingHotelSearchViewModel.Result>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;
    double score; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Booking Otel Rezervasyon Sayfası</h1>

<h3>Arama Yapılan Şehir: Paris/Fransa</h3>


<table class=""table table-striped"">
    <tr>
        <th>#</th>
        <th>Otel Adı</th>
        <th>Otel Puanı</th>
        <th>Otel Değerlendirmesi</th>
        <th>Detaylar</th>
    </tr>

");
#nullable restore
#line 21 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 25 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 26 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
   Write(item.hotel_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 27 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
       score = double.Parse(item.review_score.ToString()) / 10;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>");
#nullable restore
#line 28 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
   Write(score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 29 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
       if (item.review_score_word == "Very good")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>Çok İyi</td> ");
#nullable restore
#line 31 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
                 }
                if (item.review_score_word == "Good")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>İyi</td> ");
#nullable restore
#line 34 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
             }
                if (item.review_score_word == "Fabulous")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>Harika</td> ");
#nullable restore
#line 37 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td><a href=\"#\" class=\"btn btn-outline-dark\">Detaylar</a></td>\n</tr>");
#nullable restore
#line 39 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Admin\Views\BookingOtelSearch\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingHotelSearchViewModel.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
