#pragma checksum "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea694ff152edf4bac619771a1706be335aca598e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Commend_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Commend/Index.cshtml")]
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
#line 1 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\_ViewImports.cshtml"
using Tourism_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\_ViewImports.cshtml"
using Tourism_Project.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\_ViewImports.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea694ff152edf4bac619771a1706be335aca598e", @"/Areas/Member/Views/Commend/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0404821e2e26bec508d1d1d3b12c1ec4c04fae71", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Commend_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entity.Concrete.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";
    int count =0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Yorumlarım</h4>
                <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                <div class=""heading-elements"">
                    <ul class=""list-inline mb-0"">
                        <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                        <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                        <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
");
            WriteLiteral(@"                    </ul>
                </div>
            </div>
            <div class=""card-content collapse show"">
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Yapılan Yorum</th>
                                    <th>Yorum Yapılan Tatil</th>
                                    <th>Yorum Yapılan Tarih</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 36 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml"
                                 foreach (var item in Model)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml"
                       Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml"
                       Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml"
                        Write(((DateTime)item.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>");
#nullable restore
#line 44 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Areas\Member\Views\Commend\Index.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entity.Concrete.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
