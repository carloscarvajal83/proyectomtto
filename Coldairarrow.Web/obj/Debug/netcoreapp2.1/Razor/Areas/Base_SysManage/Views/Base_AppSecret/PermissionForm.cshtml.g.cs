#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a8bbcf3f2c1727f3ea195997bda3313bad9618a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_SysManage_Views_Base_AppSecret_PermissionForm), @"mvc.1.0.view", @"/Areas/Base_SysManage/Views/Base_AppSecret/PermissionForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Base_SysManage/Views/Base_AppSecret/PermissionForm.cshtml", typeof(AspNetCore.Areas_Base_SysManage_Views_Base_AppSecret_PermissionForm))]
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
#line 1 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
using Coldairarrow.Business.Base_SysManage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a8bbcf3f2c1727f3ea195997bda3313bad9618a", @"/Areas/Base_SysManage/Views/Base_AppSecret/PermissionForm.cshtml")]
    public class Areas_Base_SysManage_Views_Base_AppSecret_PermissionForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/vendor/jQuery/jquery-2.2.3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/util/util.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/vendor/layer/layer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/vendor/layer/layer-extends.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
  
    var permissions = PermissionManage.GetAppIdPermissionModules((string)ViewData["appId"]);

#line default
#line hidden
            BeginContext(144, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(169, 691, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ffb128b5e954faaa9ccec9bd686945e", async() => {
                BeginContext(175, 136, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>PermissionForm3</title>\n    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 311, "\"", 381, 1);
#line 13 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
WriteAttributeValue("", 318, Url.Scrpit("~/Scripts/vendor/bootstrap/css/bootstrap.min.css"), 318, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(382, 44, true);
                WriteLiteral(">\n    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 426, "\"", 502, 1);
#line 14 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
WriteAttributeValue("", 433, Url.Scrpit("~/Scripts/vendor/font-awesome/css/font-awesome.min.css"), 433, 69, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(503, 44, true);
                WriteLiteral(">\n    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 547, "\"", 596, 1);
#line 15 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
WriteAttributeValue("", 554, Url.Scrpit("~/css/fx/permisson-form.css"), 554, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(597, 9, true);
                WriteLiteral(" />\n\n    ");
                EndContext();
                BeginContext(606, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f1384bbb85c49ca8432d9b8ba21d241", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(673, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(678, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3c771929e0f438c9bf133721b889437", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(724, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(729, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb7f5747bb44d41bfe66e05798701fb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(784, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(789, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db0350162a44459a59c1181663f5dc9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(852, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(860, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(861, 2674, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4558f690dcee4a089afa0eaf1762b966", async() => {
                BeginContext(867, 339, true);
                WriteLiteral(@"
    <div style=""padding:15px;padding-right:45px;"">
        <form id=""form"" class=""form-horizontal"" role=""form"">
            <div class=""form-group form-group-sm"">
                <label class=""col-sm-1 control-label"">模块</label>
                <label class=""col-sm-10 control-label"" style=""text-align:left"">权限项</label>
            </div>
");
                EndContext();
#line 29 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
             foreach (var aModule in permissions)
            {

#line default
#line hidden
                BeginContext(1270, 113, true);
                WriteLiteral("                <div class=\"form-group form-group-sm\">\n                    <label class=\"col-sm-1 control-label\">");
                EndContext();
                BeginContext(1384, 12, false);
#line 32 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
                                                     Write(aModule.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1396, 52, true);
                WriteLiteral("</label>\n                    <div class=\"col-sm-9\">\n");
                EndContext();
#line 34 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
                         foreach (var item in aModule.Items)
                        {

#line default
#line hidden
                BeginContext(1535, 153, true);
                WriteLiteral("                            <div class=\"checkbox checkbox-success checkbox-inline\">\n                                <input type=\"checkbox\" class=\"styled\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1688, "\"", 1701, 1);
#line 37 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
WriteAttributeValue("", 1693, item.Id, 1693, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1702, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1705, 31, false);
#line 37 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
                                                                                Write(item.IsChecked ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1737, 8, true);
                WriteLiteral(" value=\"");
                EndContext();
                BeginContext(1746, 10, false);
#line 37 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
                                                                                                                         Write(item.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1756, 41, true);
                WriteLiteral("\">\n                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 1797, "\"", 1811, 1);
#line 38 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
WriteAttributeValue("", 1803, item.Id, 1803, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1812, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1814, 9, false);
#line 38 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1823, 44, true);
                WriteLiteral("</label>\n                            </div>\n");
                EndContext();
#line 40 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
                        }

#line default
#line hidden
                BeginContext(1893, 440, true);
                WriteLiteral(@"                    </div>
                    <div class=""col-sm-2"">
                        <div class=""btn-group btn-group-sm"">
                            <button onclick=""selectAll(this);"" type=""button"" class=""btn btn-success"">全选</button>
                            <button onclick=""unSelectAll(this);"" type=""button"" class=""btn btn-default"">取消</button>
                        </div>
                    </div>
                </div>
");
                EndContext();
#line 49 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_AppSecret\PermissionForm.cshtml"
            }

#line default
#line hidden
                BeginContext(2347, 1181, true);
                WriteLiteral(@"        </form>
    </div>

    <script>
        var appId = request('appId');

        function selectAll(btnObj) {
            $(btnObj).parent().parent().parent().find('input').each(function (index, item) {
                $(item).prop('checked', 'checked');
            });
        }

        function unSelectAll(btnObj) {
            $(btnObj).parent().parent().parent().find('input').each(function (index, item) {
                $(item).removeAttr('checked');
            });
        }

        function savePermission() {
            var permissions = [];
            $('input:checked').each(function (index, item) {
                permissions.push($(item).attr('value'));
            });

            loading();
            $.postJSON('/Base_SysManage/Base_AppSecret/SavePermission', {
                appId: appId,
                permissions: JSON.stringify(permissions)
            }, function (resJson) {
                loading(false);

                if (resJson.Success) {
                    dialogSucces");
                WriteLiteral("s(\'保存成功!\');\n                }\n                else {\n                    dialogError(resJson.Msg);\n                }\n            });\n        }\n    </script>\n");
                EndContext();
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
            EndContext();
            BeginContext(3535, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591