#pragma checksum "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49979d701e14bf14f8b042eff7f5edd0589458d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineExamination.Pages.Admin.Pages_Admin_Managers), @"mvc.1.0.razor-page", @"/Pages/Admin/Managers.cshtml")]
namespace OnlineExamination.Pages.Admin
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
#line 1 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\_ViewImports.cshtml"
using OnlineExamination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\_ViewImports.cshtml"
using OnlineExamination.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49979d701e14bf14f8b042eff7f5edd0589458d5", @"/Pages/Admin/Managers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46ec7498e09f1ecc05148ea1e7a6f6fd6c1216e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Managers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/DeleteManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/EditManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table"" style=""border-color:blueviolet"" border=""1"">
    <tr>
        <td class=""font-italic"" style=""border:solid"">Name</td>
        <td class=""font-italic"" style=""border:solid"">User Name</td>
        <td class=""font-italic"" style=""border:solid"">Email</td>
        <td class=""font-italic"" style=""border:solid"">Phone</td>
    </tr>
");
#nullable restore
#line 12 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
     foreach (var doc in Model.managerDTOList.Managers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td class=\"font-italic\">");
#nullable restore
#line 15 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
                       Write(doc.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td class=\"font-italic\">");
#nullable restore
#line 16 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
                       Write(doc.NAMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td class=\"font-italic\">");
#nullable restore
#line 17 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
                       Write(doc.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td class=\"font-italic\">");
#nullable restore
#line 18 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
                       Write(doc.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49979d701e14bf14f8b042eff7f5edd0589458d56217", async() => {
                WriteLiteral("\r\n            Delete\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-managerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
                                                    WriteLiteral(doc.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["managerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-managerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["managerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49979d701e14bf14f8b042eff7f5edd0589458d58523", async() => {
                WriteLiteral("\r\n            Edit\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-managerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
                                                  WriteLiteral(doc.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["managerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-managerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["managerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
                                                                                   WriteLiteral(doc.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["managerEmail"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-managerEmail", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["managerEmail"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n");
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 35 "D:\ITI\ITI Study\Web Development\Examination System\project\Group\Online-Examination-System\OnlineExamination\Pages\Admin\Managers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineExamination.Pages.Admin.ManagersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineExamination.Pages.Admin.ManagersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineExamination.Pages.Admin.ManagersModel>)PageContext?.ViewData;
        public OnlineExamination.Pages.Admin.ManagersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
