#pragma checksum "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b74665468825199da5bb9053d7d9d1fd0431b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b74665468825199da5bb9053d7d9d1fd0431b6", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be83bafa180d5662c534d72f9e956e6973b1a4f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entity.Concrete.Destination>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
   ViewData["Title"] = "DestinationDetails";
                Layout = "~/Views/Shared/_UILayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!doctype html>\n<html lang=\"zxx\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b74665468825199da5bb9053d7d9d1fd0431b63746", async() => {
                WriteLiteral(@"

    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Tur Detayları</h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li><a href=""/Default/Index/"">Ana Sayfa</a></li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rehberin Yorumları </li>
                </ul>
            </div>
        </div>
    </section>

    <div class=""py-5 w3l-homeblock1 text-center"">
        <div class=""container mt-md-3"">
            <h3 class=""blog-desc-big text-center mb-4"">
                Alanında en yetkin rehberlerimizle
                en güncel seyahat hikayelerimizi okumalısınız!
            </h3>
            <div class=""blog-post-align"">
                <div class=""blog-post-img"">
                    <a href=""#""><img");
                BeginWriteAttribute("src", " src=\"", 1124, "\"", 1148, 1);
#nullable restore
#line 30 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 1130, Model.Guide.Image, 1130, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1149, "\"", 1155, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-fluid\" /></a>\n                </div>\n                <div class=\"blog-post-info\">\n                    <div class=\"author align-items-center mb-1\">\n                        <a href=\"#\">");
#nullable restore
#line 34 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
                               Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> Tur Rotaları: <a href=\"#url\">");
#nullable restore
#line 34 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
                                                                                  Write(Model.Guide.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n                    </div>\n                    <ul class=\"blog-meta\">\n                        <li class=\"meta-item blog-lesson\">\n                            <span class=\"meta-value\"> ");
#nullable restore
#line 38 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
                                                  Write(((DateTime)Model.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span>
                        </li>
                        <li class=""meta-item blog-students"">
                            <span class=""meta-value""> 6min read</span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <section class=""blog-post-main w3l-homeblock1"">

        <div class=""blog-content-inf pb-5"">
            <div class=""container pb-lg-4"">
                <div class=""single-post-image"">
                    <div class=""post-content"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 2237, "\"", 2260, 1);
#nullable restore
#line 54 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 2243, Model.CoverImage, 2243, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:1170px;height:500px\" class=\"radius-image img-fluid mb-5\"");
                BeginWriteAttribute("alt", " alt=\"", 2331, "\"", 2337, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n                    </div>\n                </div>\n                <div class=\"single-post-content\">\n                    <p class=\"alphabet mb-4\">\n                        <span class=\"big-letter\"></span>");
#nullable restore
#line 59 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
                                                   Write(Model.Details1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>
                    <blockquote class=""blockquote my-5"">
                        <div class=""icon-quote""><span class=""fa fa-quote-left"" aria-hidden=""true""></span></div>
                        Gezi Tur Seyahat Rotalar Dünya.
                        <footer class=""blockquote-footer mt-3"">
                            Smith lara
                        </footer>
                    </blockquote>
                    <div class=""sing-post-thumb mb-5 row pt-3"">
                        <div class=""col-sm-6"">
                            <a href=""#url""><img");
                BeginWriteAttribute("src", " src=\"", 3139, "\"", 3157, 1);
#nullable restore
#line 70 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 3145, Model.Image, 3145, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:400px;height:400px;\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 3223, "\"", 3229, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\n                        </div>\n                        <div class=\"col-sm-6 mt-sm-0 mt-3\">\n                            <a href=\"#url\"><img");
                BeginWriteAttribute("src", " src=\"", 3374, "\"", 3393, 1);
#nullable restore
#line 73 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 3380, Model.Image2, 3380, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:400px;height:400px;\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 3459, "\"", 3465, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\n                        </div>\n                    </div>\n                    <h3 class=\"blog-desc-big m-0 mb-lg-4 mb-3\">2.Paragraf</h3>\n                    <p class=\"mb-4\">\n                        ");
#nullable restore
#line 78 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
                   Write(Model.Details2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </p>

                    <div class=""d-grid left-right mt-5 pb-md-5"">
                        <div class=""buttons-singles tags"">
                            <h4>Etiketler :</h4>
                            <a href=""#blog-tag"">Seyahat</a>
                            <a href=""#blog-tag"">Gezi</a>
                            <a href=""#blog-tag"">Hotel</a>
                            <a href=""#blog-tag"">Yemek</a>
                            <a href=""#blog-tag"">Tur</a>
                            <a href=""#blog-tag"">Dünya</a>
                        </div>
                        <div class=""buttons-singles"">
                            <h4>Paylaş :</h4>
                            <a href=""#blog-share""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                            <a href=""#blog-share""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
              ");
                WriteLiteral(@"              <a href=""#blog-share""><span class=""fa fa-pinterest-p"" aria-hidden=""true""></span></a>
                        </div>
                    </div>

                    <div class=""author-card mt-5"">
                        <div class=""row align-items-center"">
                            <div class=""col-sm-3 col-6"">
                                <div>
                                    <img");
                BeginWriteAttribute("src", " src=\"", 5114, "\"", 5138, 1);
#nullable restore
#line 104 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 5120, Model.Guide.Image, 5120, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 5139, "\"", 5145, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded-circle img-fluid\">\n                                </div>\n                            </div>\n                            <div class=\"col-sm-9 mt-sm-0 mt-3\">\n                                <h3 class=\"mb-3 title\">");
#nullable restore
#line 108 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
                                                  Write(Model.Guide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                                <p>\n                                    ");
#nullable restore
#line 110 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
                               Write(Model.Guide.Description2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </p>
                                <ul class=""author-icons mt-4"">
                                    <li>
                                        <a class=""facebook"" href=""#url"">
                                            <span class=""fa fa-facebook""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""twitter"" href=""#url"">
                                            <span class=""fa fa-twitter""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""google"" href=""#url"">
                                            <span class=""fa fa-google-plus""
                                   ");
                WriteLiteral(@"               aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""linkedin"" href=""#url"">
                                            <span class=""fa fa-linkedin""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""github"" href=""#url"">
                                            <span class=""fa fa-github""
                                                  aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a class=""dribbble"" href=""#url"">
                                            <span class=""fa fa-dribbble""
          ");
                WriteLiteral(@"                                        aria-hidden=""true""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>

                    ");
#nullable restore
#line 154 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
               Write(await Component.InvokeAsync("_CommentList", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                    ");
#nullable restore
#line 156 "C:\Users\yunus.yılmaz\Desktop\Tourism_Project\Tourism_Project\Views\Destination\DestinationDetails.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml", new { id = ViewBag.destID }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    <br /><br />\n                </div>\n            </div>\n\n        </div>\n    </section>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entity.Concrete.Destination> Html { get; private set; }
    }
}
#pragma warning restore 1591