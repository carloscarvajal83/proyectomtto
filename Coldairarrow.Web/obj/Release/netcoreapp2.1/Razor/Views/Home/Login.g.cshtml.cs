#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc994d5fcf115c301a08142c6e378a90cf1e4d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc994d5fcf115c301a08142c6e378a90cf1e4d6", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition login-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:80%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 1289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5725f65bbb434ccd972ee4aaa746ed5d", async() => {
                BeginContext(29, 322, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Administracion</title>
    <!-- Tell the browser to be respodnsive to screen width -->
    <meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
    <!--bootstrap-->
    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 351, "\"", 421, 1);
#line 10 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 358, Url.Scrpit("~/Scripts/vendor/bootstrap/css/bootstrap.min.css"), 358, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(422, 49, true);
                WriteLiteral(" rel=\"stylesheet\" />\n    <!--awesome-->\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 471, "\"", 548, 1);
#line 12 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 478, Url.Scrpit("~/Scripts/vendor/adminlte/dist/css/font-awesome.min.css"), 478, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(549, 52, true);
                WriteLiteral(" rel=\"stylesheet\" />\n    <!-- Ionicons -->\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 601, "\"", 674, 1);
#line 14 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 608, Url.Scrpit("~/Scripts/vendor/adminlte/dist/css/ionicons.min.css"), 608, 66, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(675, 55, true);
                WriteLiteral(" rel=\"stylesheet\" />\n    <!-- Theme style -->\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 730, "\"", 803, 1);
#line 16 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 737, Url.Scrpit("~/Scripts/vendor/adminlte/dist/css/AdminLTE.min.css"), 737, 66, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(804, 50, true);
                WriteLiteral(" rel=\"stylesheet\" />\n    <!-- iCheck -->\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 854, "\"", 915, 1);
#line 18 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 861, Url.Scrpit("~/Scripts/vendor/iCheck/square/blue.css"), 861, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(916, 389, true);
                WriteLiteral(@" rel=""stylesheet"">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
    <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->
");
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
            BeginContext(1312, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1313, 4876, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1a473f26f1347e595d5c67bb36eb74a", async() => {
                BeginContext(1373, 191, true);
                WriteLiteral("\n    <div class=\"login-box\">\n        <div class=\"login-logo\">\n            <a href=\"#\"><b>MY ADMIN HQ</b></a>\n        </div>\n        <!-- /.login-logo -->\n        <div class=\"login-box-body\">\n");
                EndContext();
                BeginContext(1639, 1478, true);
                WriteLiteral(@"            <form id=""form"" role=""form"">
                <div class=""form-group has-feedback"">
                    <input id=""userName"" name=""userName"" type=""text"" class=""form-control"" required placeholder=""Usuario"">
                    <span class=""glyphicon glyphicon-user form-control-feedback""></span>
                    <div class=""help-block with-errors""></div>
                </div>
                <div class=""form-group has-feedback"">
                    <input id=""password"" name=""password"" type=""password"" required class=""form-control"" placeholder=""Contraseña"">
                    <span class=""glyphicon glyphicon-lock form-control-feedback""></span>
                    <div class=""help-block with-errors""></div>
                </div>
                <div class=""row"">
                    <div class=""col-xs-8"">
                        <div class=""checkbox icheck"">
                            <input type=""checkbox"" id=""savePwd""><label style=""padding-left:5px"" for=""savePwd"">Recordar</label>
                ");
                WriteLiteral(@"        </div>
                    </div>
                    <!-- /.col -->
                    <div class=""col-xs-4"">
                        <button type=""submit"" class=""btn btn-primary btn-block btn-flat"">Ingresar</button>
                    </div>
                    <!-- /.col -->
                </div>
            </form>
        </div>
        <!-- /.login-box-body -->
    </div>
    <!-- /.login-box -->
    <!-- jQuery 2.2.3 -->
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3117, "\"", 3181, 1);
#line 64 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3123, Url.Scrpit("~/Scripts/vendor/jQuery/jquery-2.2.3.min.js"), 3123, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3182, 48, true);
                WriteLiteral("></script>\n\n    <!--jQuery-cookie-->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3230, "\"", 3302, 1);
#line 67 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3236, Url.Scrpit("~/Scripts/vendor/jQuery-cookie/jquery.cookie.min.js"), 3236, 66, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3303, 43, true);
                WriteLiteral("></script>\n\n    <!-- iCheck -->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3346, "\"", 3404, 1);
#line 70 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3352, Url.Scrpit("~/Scripts/vendor/iCheck/icheck.min.js"), 3352, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3405, 43, true);
                WriteLiteral("></script>\n    <!--bootstrap-->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3448, "\"", 3515, 1);
#line 72 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3454, Url.Scrpit("~/Scripts/vendor/bootstrap/js/bootstrap.min.js"), 3454, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3516, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3538, "\"", 3612, 1);
#line 73 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3544, Url.Scrpit("~/Scripts/vendor/bootstrap/js/bootstrap-BtnBuilder.js"), 3544, 68, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3613, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3635, "\"", 3709, 1);
#line 74 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3641, Url.Scrpit("~/Scripts/vendor/bootstrap-validator/validator.min.js"), 3641, 68, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3710, 39, true);
                WriteLiteral("></script>\n    <!--layer-->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3749, "\"", 3801, 1);
#line 76 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3755, Url.Scrpit("~/Scripts/vendor/layer/layer.js"), 3755, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3802, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3824, "\"", 3884, 1);
#line 77 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3830, Url.Scrpit("~/Scripts/vendor/layer/layer-extends.js"), 3830, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3885, 36, true);
                WriteLiteral("></script>\n    <!--fx-->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3921, "\"", 3964, 1);
#line 79 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 3927, Url.Scrpit("~/Scripts/util/util.js"), 3927, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3965, 48, true);
                WriteLiteral("></script>\n\n    <script>\n        var rootUrl = \'");
                EndContext();
                BeginContext(4014, 17, false);
#line 82 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Login.cshtml"
                  Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(4031, 2151, true);
                WriteLiteral(@"';

        $(function () {
            setPwd();

            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });

            //表单校验
            $('#form').validator().on('submit', function (e) {
                //校验成功
                if (!e.isDefaultPrevented()) {
                    e.preventDefault();

                    var values = $('#form').getValues();
                    //保存账号密码
                    var checked = $('#savePwd')[0].checked;
                    savePwd(values.userName, values.password, checked);
                    loading();
                    $.postJSON(rootUrl + 'Home/SubmitLogin', values, function (resJson) {
                        loading(false);

                        if (resJson.Success) {
                            window.location.href = rootUrl;
                        }
                        else {
                            dialo");
                WriteLiteral(@"gError(resJson.Msg);
                        }
                    });
                }
            })
        });

        //设置保存的账号密码
        function setPwd() {
            var userName = $.cookie('userName');
            var password = $.cookie('password');
            if (userName && password) {
                $('#userName').val(userName);
                $('#password').val(password);
                $('#savePwd').prop('checked', 'checked');
            } else {
                $('#savePwd').removeAttr('checked');
            }
        }

        //保存账号密码
        function savePwd(userName, password, isSave) {
            if (isSave) {
                $.cookie('userName', userName, {
                    expires: new Date('9999/1/1'),
                    path: '/'
                });
                $.cookie('password', password, {
                    expires: new Date('9999/1/1'),
                    path: '/'
                });
            } else {
                $.removeCookie('userName', { path: '/");
                WriteLiteral("\' });\n                $.removeCookie(\'password\', { path: \'/\' });\n            }\n        }\n    </script>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6189, 9, true);
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
