#pragma checksum "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Excel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4566589f9775ebfcc5e3ba9e2f4d0ab54a4a1032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Excel_Index), @"mvc.1.0.view", @"/Views/Excel/Index.cshtml")]
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
#line 1 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\_ViewImports.cshtml"
using Tourism_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\_ViewImports.cshtml"
using Tourism_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\_ViewImports.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4566589f9775ebfcc5e3ba9e2f4d0ab54a4a1032", @"/Views/Excel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be83bafa180d5662c534d72f9e956e6973b1a4f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Excel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Excel\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Excel Raporları Sayfası</h1>\r\n<br />\r\n<a href=\"/Excel/StaticExcelReport/\" class=\"btn btn-outline-info\">Statick Excel Raporu</a>\r\n<br /><br />\r\n<a href=\"/Excel/DestinationExcelReport/\" class=\"btn btn-outline-primary\">Tur Rotaları Excel Raporu</a>\r\n\r\n");
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