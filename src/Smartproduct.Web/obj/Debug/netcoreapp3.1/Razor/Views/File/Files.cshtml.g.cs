#pragma checksum "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9781569589620a8871b275a6469bb321f200f07d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Files), @"mvc.1.0.view", @"/Views/File/Files.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9781569589620a8871b275a6469bb321f200f07d", @"/Views/File/Files.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a18a043e9714479d3fa14f059bf9406b3ba432", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Files : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Smartproduct.Web.Models.FileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar avatar-xs avatar-4by3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/src/assets/svg/brands/excel.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar avatar-xl avatar-4by3 mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/src/assets/svg/illustrations/browse.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Files", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "File", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/dist/assets/vendor/dropzone/dist/dropzone.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/dist/assets/vendor/dropzone/dist/min/dropzone.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/dist/assets/vendor/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/front-dashboard-v1.1/src/assets/js/hs.validation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
  
    ViewData["Title"] = "Files";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""content"" role=""main"" class=""main"">
    <!-- Breadcrumb Section -->
    <div class=""content container-fluid"">
        <!-- Page Header -->
        <div class=""page-header"">
            <div class=""row align-items-end"">
                <div class=""col-sm mb-2 mb-sm-0"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb breadcrumb-no-gutter"">
                            <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">Administration</a></li>
                            <li class=""breadcrumb-item""><a class=""breadcrumb-link"" href=""javascript:;"">Files</a></li>

                        </ol>
                    </nav>
                    <h1 class=""page-header-title"">Current files</h1>
                </div>

                <div class=""col-sm-auto"">
                    <a class=""btn btn-primary"" href=""javascript:;"" data-toggle=""modal"" data-target=""#exampleModal""><i class=""tio-upload-on-cloud mr-1""></i> Upload</a>
 ");
            WriteLiteral(@"                   <!-- Unfold -->
                    <div class=""hs-unfold hs-nav-scroller-unfold ml-3"">
                        <a class=""js-hs-unfold-invoker btn btn-icon btn-sm btn-white"" href=""javascript:;"" data-hs-unfold-options=""{
                         &quot;target&quot;: &quot;#profileDropdown&quot;,
                         &quot;type&quot;: &quot;css-animation&quot;
                       }"" data-hs-unfold-target=""#profileDropdown"" data-hs-unfold-invoker="""">
                            <i class=""fal fa-user-lock""></i>
                        </a>
                    </div>
                    <!-- End Unfold -->
                </div>
            </div>
            <!-- End Row -->
        </div>
        <!-- End Page Header -->
    </div>
    <!-- End Breadcrumb Section -->
    <!-- Content Section -->
    <div class=""content container-fluid my-n9"">
        <div class=""page-header"">
            <div class=""js-nav-scroller hs-nav-scroller-horizontal"">
                <span c");
            WriteLiteral(@"lass=""hs-nav-scroller-arrow-prev"" style=""display: none;"">
                    <a class=""hs-nav-scroller-arrow-link"" href=""javascript:;"">
                        <i class=""tio-chevron-left""></i>
                    </a>
                </span>

                <span class=""hs-nav-scroller-arrow-next"" style=""display: none;"">
                    <a class=""hs-nav-scroller-arrow-link"" href=""javascript:;"">
                        <i class=""tio-chevron-right""></i>
                    </a>
                </span>

                <ul class=""nav nav-tabs page-header-tabs"" id=""projectsTab"" role=""tablist"">
                    <li class=""nav-item"">;
                        <a class=""nav-link active"" href=""#"">Files <span class=""badge badge-soft-dark rounded-circle ml-1"">");
#nullable restore
#line 62 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                                                                                     Write(Model.CountFiles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n\r\n            <!-- End Nav -->\r\n        </div>\r\n        <ul class=\"list-group\">\r\n");
#nullable restore
#line 70 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
             if (Model.Files != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                 foreach (var item in Model.Files.Where(x => x.ProductId == null))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- List Item -->\r\n                    <li class=\"list-group-item\">\r\n                        <div class=\"row align-items-center gx-2\">\r\n                            <div class=\"col-auto\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9781569589620a8871b275a6469bb321f200f07d13537", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"col\">\r\n                                <h5 class=\"mb-0\">\r\n                                    <a class=\"text-dark\">");
#nullable restore
#line 83 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                    Write(item.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <ul class=\"list-inline list-separator small\">\r\n                                    <li class=\"list-inline-item\">Created by ");
#nullable restore
#line 86 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                                       Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li class=\"list-inline-item\">Created on ");
#nullable restore
#line 87 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                                       Write(item.CreatedOn.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 87 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                                                                                Write(item.CreatedOn.ToString("hh:mm:tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                </ul>
                            </div>

                            <div class=""col-auto"">
                                <div class=""hs-unfold"">
                                    <a class=""js-hs-unfold-invoker btn btn-sm btn-white"" href=""javascript:;"" data-hs-unfold-options=""{
                                            &quot;target&quot;: &quot;#");
#nullable restore
#line 94 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                                  Write(item.FileId);

#line default
#line hidden
#nullable disable
            WriteLiteral("&quot;,\r\n                                            &quot;type&quot;: &quot;css-animation&quot;\r\n                                        }\" data-hs-unfold-target=\"#");
#nullable restore
#line 96 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                              Write(item.FileId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-hs-unfold-invoker=\"\">\r\n                                        Actions <i class=\"tio-chevron-down ml-1\"></i>\r\n                                    </a>\r\n\r\n                                    <div");
            BeginWriteAttribute("id", " id=\"", 5024, "\"", 5041, 1);
#nullable restore
#line 100 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
WriteAttributeValue("", 5029, item.FileId, 5029, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""hs-unfold-content dropdown-unfold dropdown-menu dropdown-menu-sm dropdown-menu-right hs-unfold-content-initialized hs-unfold-css-animation animated hs-unfold-hidden"" data-hs-target-height=""145.078"" data-hs-unfold-content="""" data-hs-unfold-content-animation-in=""slideInUp"" data-hs-unfold-content-animation-out=""fadeOut"" style=""animation-duration: 300ms;"">
                                        <span class=""dropdown-header"">Actions</span>
                                        <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 5556, "\"", 5623, 1);
#nullable restore
#line 102 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
WriteAttributeValue("", 5563, Url.Action("Download", "File", new { FileId = item.FileId}), 5563, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank""><i class=""tio-download-to dropdown-item-icon""></i>Download</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- End Row -->
                    </li>
                    <!-- End List Item -->
");
#nullable restore
#line 110 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
    <!-- End Content Section -->
    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9781569589620a8871b275a6469bb321f200f07d20175", async() => {
                WriteLiteral(@"
                <div class=""modal-content"">
                    <!-- Header -->
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Upload Files</h5>
                        <button type=""button"" class=""btn btn-icon btn-sm btn-ghost-secondary"" data-dismiss=""modal"" aria-label=""Close"">
                            <i class=""tio-clear tio-lg"" aria-hidden=""true""></i>
                        </button>
                    </div>
                    <!-- End Header -->
                    <!-- Body -->
                    <div class=""modal-body"">
                        <!-- Dropzone -->
                        <!-- Dropzone -->
                        <center><div class=""dz-max-files-reached"" id=""MaxFileMessage"" style=""color:red;""></div></center>
                        <div class=""col-sm-12"">
                            <div id=""attachFilesLabel"" class=""js-dropzone dropzone-custom custom-file-boxed"">
                                ");
                WriteLiteral("<div class=\"dz-message custom-file-boxed-label\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9781569589620a8871b275a6469bb321f200f07d21614", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                    <h5>Drag and drop your file here</h5>

                                    <p class=""mb-2"">or</p>

                                    <span class=""btn btn-sm btn-white"">Browse files</span>
                                </div>
                            </div>
                        </div>
                        <!-- End Dropzone -->
                        <!-- End Dropzone -->
                    </div>
                    <input type=""hidden"" name=""categoryDocument"" id=""categoryDocument"" value=""value"" />
                    <!-- Footer -->
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-white"" data-dismiss=""modal"">Close</button>
                        <button type=""submit"" class=""btn btn-primary"" id=""submit"">Save</button>
                    </div>
                    <!-- End Footer -->
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!-- End Modal -->\r\n</main>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9781569589620a8871b275a6469bb321f200f07d25859", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9781569589620a8871b275a6469bb321f200f07d26960", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9781569589620a8871b275a6469bb321f200f07d28061", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9781569589620a8871b275a6469bb321f200f07d29162", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(document).on('ready', function () {
            // INITIALIZATION OF FORM VALIDATION
            // =======================================================
            $('.js-validate').each(function () {
                $.HSCore.components.HSValidation.init($(this));
            });
        });
    </script>
    <script>
        $(document).on('ready', function () {
            // INITIALIZATION OF DROPZONE FILE ATTACH MODULE
            // =======================================================
            $('.js-dropzone').each(function () {
                var dropzone = $.HSCore.components.HSDropzone.init('#' + $(this).attr('id'));

                dropzone.on(""addedfile"", function (file) {
                    console.log(file.name);
                    document.getElementById('MaxFileMessage').innerHTML = """";
                });
            });
        });

        ; (function ($) {
            'use strict';

            $.HSCore.components.HSDropzone =");
                WriteLiteral(@" {
                defaults: {
                    // Default variables
                    url: ""#"",
                    thumbnailWidth: 300,
                    maxFiles: 1,
                    maxFilesize: 4,
                    autoDiscover: false,
                    uploadMultiple: false,
                    autoProcessQueue: false,
                    parallelUploads: 10,
                    paramName: function myParamName() {
                        return ""File"";
                    },
                    thumbnailHeight: 300,
                    previewTemplate: $('<div>' +
                        '  <div class=""col h-100 px-1 mb-2"">' +
                        '    <div class=""dz-preview dz-file-preview"">' +
                        '      <div class=""d-flex justify-content-end dz-close-icon"">' +
                        '        <small class=""tio-clear"" data-dz-remove></small>' +
                        '      </div>' +
                        '      <div class=""dz-details media""");
                WriteLiteral(@">' +
                        '        <div class=""dz-img"">' +
                        '         <img class=""img-fluid dz-img-inner"" data-dz-thumbnail>' +
                        '        </div>' +
                        '        <div class=""media-body dz-file-wrapper"">' +
                        '         <h6 class=""dz-filename"">' +
                        '          <span class=""dz-title"" data-dz-name></span>' +
                        '         </h6>' +
                        '         <div class=""dz-size"" data-dz-size></div>' +
                        '        </div>' +
                        '      </div>' +
                        '      <div class=""dz-progress progress"">' +
                        '        <div class=""dz-upload progress-bar bg-success"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100"" data-dz-uploadprogress></div>' +
                        '      </div>' +
                        '      <div class=""d-flex align-items-center""");
                WriteLiteral(@">' +
                        '        <div class=""dz-success-mark"">' +
                        '          <span class=""tio-checkmark-circle""></span>' +
                        '        </div>' +
                        '      </div>' +
                        '    </div>' +
                        '  </div>' +
                        '</div>').html()
                },

                init: function (el, options) {
                    if (!el.length) return;

                    var context = this,
                        $el = $(el),
                        defaults = Object.assign({}, context.defaults),
                        dataSettings = $el.attr('data-hs-dropzone-options') ? JSON.parse($el.attr('data-hs-dropzone-options')) : {},
                        settings = {
                            init: function () {
                                var $this = this,
                                    $message = $($this.element).find('.dz-message');

                                $t");
                WriteLiteral(@"his.on('addedfile', function (file) {
                                    if (String(file.type).slice(0, 6) !== 'image/') {
                                        $(file.previewElement).find('.dz-img').replaceWith('<span class=""dz-file-initials"">' + file.name.substring(0, 1).toUpperCase() + '</span>');
                                    }

                                    $message.hide();
                                });

                                $this.on('removedfile', function () {
                                    if ($this.files.length <= 0) {
                                        $message.show();
                                    }
                                });

                                $this.on(""error"", function (file, message) {
                                    if (file.size > 1024 * 1024 * 4/*4MB*/) {
                                        document.getElementById('MaxFileMessage').innerHTML = message;
                                        this.r");
                WriteLiteral(@"emoveFile(file);
                                    } else {
                                        document.getElementById('MaxFileMessage').innerHTML = """";
                                    }
                                });

                                var submitButton = document.querySelector(""#submit"");
                                var myDropzone = this; //closure

                                submitButton.addEventListener(""click"", function (e) {

                                    //tell Dropzone to process all queued files
                                    if ($(""#addForm"").valid())
                                    {
                                        jQuery.validator.addClassRules('myselect',
                                            {
                                                required: true
                                            });
                                        console.log($(""#addForm"").valid());
                                  ");
                WriteLiteral(@"  }
                                    if ($(""#addForm"").valid())
                                    {
                                        e.preventDefault();
                                        myDropzone.processQueue();
                                        $('#exampleModal').modal('hide');
                                        console.log($(""#addForm"").valid());
                                        $this.on(""success"", function (file, responseText) {
                                            var responseText = file.name // or however you would point to your assigned file ID here;
                                            console.log(responseText); // console should show the ID you pointed to
                                            // do stuff with file.id ...
                                            window.location.href = '");
#nullable restore
#line 298 "C:\Users\zaino\source\repos\Smartproduct.Web\src\Smartproduct.Web\Views\File\Files.cshtml"
                                                               Write(Url.Action("Currentproducts", "Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
                                        });
                                    }
                                });

                                $this.on(""sending"", function (file, xhr, formData) {
                                    $('#addForm').find('input').each(function ()
                                    {
                                        formData.append($(this).attr('name'), $(this).val());
                                    });
                                });
                            }
                        };
                    settings = $.extend(true, defaults, settings, dataSettings, options);

                    /* Start : Init */

                    var newDropzone = new Dropzone(el, settings);

                    /* End : Init */

                    return newDropzone;
                }

            };

        })(jQuery);
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Smartproduct.Web.Models.FileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591