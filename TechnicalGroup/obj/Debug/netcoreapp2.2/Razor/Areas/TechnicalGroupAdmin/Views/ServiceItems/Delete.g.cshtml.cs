#pragma checksum "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c11ebebaa8e3695c48c8e4612b8390572d1571a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_ServiceItems_Delete), @"mvc.1.0.view", @"/Areas/TechnicalGroupAdmin/Views/ServiceItems/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/TechnicalGroupAdmin/Views/ServiceItems/Delete.cshtml", typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_ServiceItems_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c11ebebaa8e3695c48c8e4612b8390572d1571a", @"/Areas/TechnicalGroupAdmin/Views/ServiceItems/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a704437deccfb2078969bdb65c3683a80aff18c", @"/Areas/TechnicalGroupAdmin/Views/_ViewImports.cshtml")]
    public class Areas_TechnicalGroupAdmin_Views_ServiceItems_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechnicalGroup.Models.ServiceItems>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/TechnicalGroupAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(165, 344, true);
            WriteLiteral(@"
<div id=""kt_content"" class=""kt-content  kt-grid__item kt-grid__item--fluid kt-grid kt-grid--hor"" style=""background:white !important"">
    <h3 class=""text-center text-danger"">Silmək istədiyinizdən əminsiniz mi ?</h3>
    <hr />
    <div class=""container-fluid"">

        <div class=""col-12"">
            <p><b>Bəndin başlığı (AZE)</b> - ");
            EndContext();
            BeginContext(510, 14, false);
#line 14 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
                                        Write(Model.Title_Az);

#line default
#line hidden
            EndContext();
            BeginContext(524, 97, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Bəndin başlığı (RUS)</b> - ");
            EndContext();
            BeginContext(622, 14, false);
#line 17 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
                                        Write(Model.Title_Ru);

#line default
#line hidden
            EndContext();
            BeginContext(636, 98, true);
            WriteLiteral(" </p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Bəndin başlığı (ENG)</b> - ");
            EndContext();
            BeginContext(735, 11, false);
#line 20 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
                                        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(746, 98, true);
            WriteLiteral(" </p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Bəndin məzmunu (AZE)</b> - ");
            EndContext();
            BeginContext(845, 16, false);
#line 23 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
                                        Write(Model.Content_Az);

#line default
#line hidden
            EndContext();
            BeginContext(861, 97, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Bəndin məzmunu (RUS)</b> - ");
            EndContext();
            BeginContext(959, 16, false);
#line 26 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
                                        Write(Model.Content_Ru);

#line default
#line hidden
            EndContext();
            BeginContext(975, 97, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Bəndin məzmunu (ENG)</b> - ");
            EndContext();
            BeginContext(1073, 13, false);
#line 29 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
                                        Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 54, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n</div>\r\n");
            EndContext();
            BeginContext(1140, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c11ebebaa8e3695c48c8e4612b8390572d1571a9234", async() => {
                BeginContext(1186, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1192, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c11ebebaa8e3695c48c8e4612b8390572d1571a9621", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 35 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\ServiceItems\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1228, 72, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Sil\" class=\"btn btn-danger\" /> |\r\n    ");
                EndContext();
                BeginContext(1300, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c11ebebaa8e3695c48c8e4612b8390572d1571a11551", async() => {
                    BeginContext(1346, 12, true);
                    WriteLiteral("Geriyə qayıt");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
                BeginContext(1362, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1371, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechnicalGroup.Models.ServiceItems> Html { get; private set; }
    }
}
#pragma warning restore 1591
