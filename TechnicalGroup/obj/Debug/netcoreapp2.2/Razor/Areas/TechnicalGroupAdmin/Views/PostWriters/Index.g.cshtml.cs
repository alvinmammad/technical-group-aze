#pragma checksum "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fae4dd77dede75822aee9e73dfadffc62dd9d32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_PostWriters_Index), @"mvc.1.0.view", @"/Areas/TechnicalGroupAdmin/Views/PostWriters/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/TechnicalGroupAdmin/Views/PostWriters/Index.cshtml", typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_PostWriters_Index))]
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
#line 1 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\_ViewImports.cshtml"
using TechnicalGroup;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\_ViewImports.cshtml"
using TechnicalGroup.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fae4dd77dede75822aee9e73dfadffc62dd9d32", @"/Areas/TechnicalGroupAdmin/Views/PostWriters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a704437deccfb2078969bdb65c3683a80aff18c", @"/Areas/TechnicalGroupAdmin/Views/_ViewImports.cshtml")]
    public class Areas_TechnicalGroupAdmin_Views_PostWriters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TechnicalGroup.Models.PostWriter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PostWriters", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-brand btn-elevate btn-icon-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyişdir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/TechnicalGroupAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(175, 1017, true);
            WriteLiteral(@"
    <div class=""kt-content  kt-grid__item kt-grid__item--fluid kt-grid kt-grid--hor"" id=""kt_content"">
        <div class=""kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">
           
           
            <hr />
            <div class=""kt-portlet kt-portlet--mobile"">

                <div class=""kt-portlet__head kt-portlet__head--lg"">
                    <div class=""kt-portlet__head-label"">
                        <span class=""kt-portlet__head-icon"">
                            <i class=""fa fa-check-circle""></i>
                        </span>
                        <h3 class=""kt-portlet__head-title"">
                            Post yazarları
                        </h3>
                    </div>
                    <div class=""kt-portlet__head-toolbar"">
                        <div class=""kt-portlet__head-wrapper"">
                            <div class=""kt-portlet__head-actions"">
                                &nbsp;
                                ");
            EndContext();
            BeginContext(1192, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fae4dd77dede75822aee9e73dfadffc62dd9d327597", async() => {
                BeginContext(1290, 141, true);
                WriteLiteral("\r\n                                    <i class=\"la la-plus\"></i>\r\n                                    Yarat\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1435, 1588, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""kt-portlet__body"">
                    <!--begin: Datatable -->
                    <div id=""kt_table_1_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <table class=""table table-striped- table-bordered table-hover table-checkable dataTable no-footer dtr-inline collapsed"" id=""kt_table_1"" role=""grid"" aria-describedby=""kt_table_1_info"" style=""width: 982px;"">
                                    <thead>
                                        <tr role=""row"">
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 38.25px;"" aria-sort=""descending"" aria-label=""Order ID: activate to sort column ascending"">ID</th>
                            ");
            WriteLiteral(@"                <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 58.25px;"" aria-label=""Country: activate to sort column ascending"">Yazar ad soyadı</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 58.25px;"" aria-label=""Country: activate to sort column ascending"">Dəyiş/Sil</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 50 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml"
                                         foreach (var writer in Model)
                                        {

#line default
#line hidden
            BeginContext(3138, 133, true);
            WriteLiteral("                                            <tr role=\"row\" class=\"odd admintr\">\r\n                                                <td>");
            EndContext();
            BeginContext(3272, 9, false);
#line 53 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml"
                                               Write(writer.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3281, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3341, 15, false);
#line 54 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml"
                                               Write(writer.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(3356, 113, true);
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3469, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fae4dd77dede75822aee9e73dfadffc62dd9d3212577", async() => {
                BeginContext(3556, 137, true);
                WriteLiteral("\r\n                                                        <i class=\"fa fa-pen\"></i>\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml"
                                                                           WriteLiteral(writer.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3697, 54, true);
            WriteLiteral("\r\n                                                    ");
            EndContext();
            BeginContext(3751, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fae4dd77dede75822aee9e73dfadffc62dd9d3215337", async() => {
                BeginContext(3827, 139, true);
                WriteLiteral("\r\n                                                        <i class=\"fa fa-trash\"></i>\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml"
                                                                             WriteLiteral(writer.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3970, 110, true);
            WriteLiteral("\r\n                                                </td>\r\n\r\n                                            </tr>\r\n");
            EndContext();
#line 65 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\PostWriters\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4123, 336, true);
            WriteLiteral(@"                                    </tbody>

                                </table>
                            </div>
                        </div>

                    </div>
                    <!--end: Datatable -->
                </div>
            </div>
        </div>
        <!-- end:: Content -->
    </div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TechnicalGroup.Models.PostWriter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
