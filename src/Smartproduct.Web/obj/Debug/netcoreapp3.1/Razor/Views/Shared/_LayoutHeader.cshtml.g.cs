#pragma checksum "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e5970afb3deb65f6a9a41e220f27a0ca306a579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutHeader), @"mvc.1.0.view", @"/Views/Shared/_LayoutHeader.cshtml")]
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
#line 1 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\_ViewImports.cshtml"
using Smartproduct.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\_ViewImports.cshtml"
using Smartproduct.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e5970afb3deb65f6a9a41e220f27a0ca306a579", @"/Views/Shared/_LayoutHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a18a043e9714479d3fa14f059bf9406b3ba432", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
   

    var headings = ViewData.ContainsKey("HeadingDetails") ? ViewData["HeadingDetails"].ToString() : string.Empty;
    var headingSubTittle = ViewData.ContainsKey("HeadingSubTittle") ? ViewData["HeadingSubTittle"].ToString() : string.Empty;
    var headingSubDetails = ViewData.ContainsKey("HeadingSubDetails") ? ViewData["HeadingSubDetails"].ToString() : string.Empty;

    var hrefLink = ViewData.ContainsKey("hrefLink") ? ViewData["hrefLink"].ToString() : "#";
    var action = ViewData.ContainsKey("action") ? ViewData["action"].ToString() : string.Empty;
    var btnIcon = ViewData.ContainsKey("btnIcon") ? ViewData["btnIcon"].ToString() : string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content container-fluid"">
    <!-- Page Header -->
    <div class=""page-header"">
        <div class=""row align-items-end"">
            <div class=""col-sm mb-2 mb-sm-0"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb breadcrumb-no-gutter"">
                        <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">");
#nullable restore
#line 22 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
                                                                                              Write(headings);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        <li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" href=\"javascript:;\">");
#nullable restore
#line 23 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
                                                                                              Write(headingSubTittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\r\n                    </ol>\r\n                </nav>\r\n\r\n                <h1 class=\"page-header-title\">");
#nullable restore
#line 28 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
                                         Write(headingSubDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n\r\n            <div class=\"col-sm-auto\">\r\n");
#nullable restore
#line 32 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
                 if (!string.IsNullOrEmpty(hrefLink))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-sm btn-primary mr-2\"");
            BeginWriteAttribute("href", " href=", 1627, "", 1642, 1);
#nullable restore
#line 34 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
WriteAttributeValue("", 1633, hrefLink, 1633, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 1671, "\"", 1692, 2);
#nullable restore
#line 35 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
WriteAttributeValue("", 1679, btnIcon, 1679, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1687, "mr-1", 1688, 5, true);
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 35 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
                                                 Write(action);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 37 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\Shared\_LayoutHeader.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <!-- End Row -->\r\n    </div>\r\n    <!-- End Page Header -->\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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