#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be497d6df3515a19e9b9cd9ad83c74899376625b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
using Coldairarrow.Web;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
using Coldairarrow.Util;

#line default
#line hidden
#line 3 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
using Coldairarrow.Business.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be497d6df3515a19e9b9cd9ad83c74899376625b", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/vendor/adminlte/dist/css/skins/all-skins.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/vendor/adminlte/dist/img/user128x128.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/vendor/adminlte/dist/img/user128x128.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-red sidebar-mini fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
  
    var menus = SystemMenuManage.GetOperatorMenu();
    var menusJson = Html.Raw(menus.ToJson());

#line default
#line hidden
            BeginContext(200, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(227, 1578, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8f3dd2a1544119a17bb904a0632dce", async() => {
                BeginContext(233, 348, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Admin LTE</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
    <!-- Bootstrap 3.3.6 -->
    <link rel=""stylesheet""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 581, "\"", 651, 1);
#line 19 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 588, Url.Scrpit("~/Scripts/vendor/bootstrap/css/bootstrap.min.css"), 588, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(652, 56, true);
                WriteLiteral(">\r\n    <!-- Font Awesome -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 708, "\"", 785, 1);
#line 21 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 715, Url.Scrpit("~/Scripts/vendor/adminlte/dist/css/font-awesome.min.css"), 715, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(786, 52, true);
                WriteLiteral(">\r\n    <!-- Ionicons -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 838, "\"", 911, 1);
#line 23 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 845, Url.Scrpit("~/Scripts/vendor/adminlte/dist/css/ionicons.min.css"), 845, 66, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(912, 55, true);
                WriteLiteral(">\r\n    <!-- Theme style -->\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 967, "\"", 1040, 1);
#line 25 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 974, Url.Scrpit("~/Scripts/vendor/adminlte/dist/css/AdminLTE.min.css"), 974, 66, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1041, 142, true);
                WriteLiteral(">\r\n    <!-- AdminLTE Skins. Choose a skin from the css/skins\r\n         folder instead of downloading all of them to reduce the load. -->\r\n    ");
                EndContext();
                BeginContext(1183, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de6f06277b7041729346ef12c18d2d51", async() => {
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
                EndContext();
                BeginContext(1272, 526, true);
                WriteLiteral(@"


    <!--http://aimodu.org:7777/admin/index_iframe.html?q=audio&search=#-->
    <style type=""text/css"">

        html {
            overflow: hidden;
        }
    </style>
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""~/Scripts/vendor/ie9/html5shiv.min.js""></script>
    <script src=""~/Scripts/vendor/ie9/respond.min.js""></script>
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
            BeginContext(1805, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1807, 11790, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e1c1bff0e4e4277b2773269bbe32747", async() => {
                BeginContext(1865, 1471, true);
                WriteLiteral(@"
    <div class=""wrapper"">
        <header class=""main-header"">
            <!-- Logo -->
            <a href=""https://github.com/Coldairarrow/Colder.Fx.Net.AdminLTE"" class=""logo"">
                <!-- mini logo for sidebar mini 50x50 pixels -->
                <span class=""logo-mini""><b>Colder 1</b></span>
                <!-- logo for regular state and mobile devices -->
                <span class=""logo-lg""><b>My Admin</b>HQ5</span>
            </a>
            <!-- Header Navbar: style can be found in header.less -->
            <nav class=""navbar navbar-static-top"">
                <!-- Sidebar toggle button-->
                <a href=""#"" class=""sidebar-toggle"" data-toggle=""offcanvas"" role=""button"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span id=""tituloforma""></span>
                </a>");
                WriteLiteral(@"
                <div class=""navbar-custom-menu"">
                    <ul class=""nav navbar-nav"">
                        <!-- Messages: style can be found in dropdown.less-->
                        <!-- User Account: style can be found in dropdown.less -->
                        <li class=""dropdown user user-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                ");
                EndContext();
                BeginContext(3336, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0006fcda996a46d4a6ac2d91262b5113", async() => {
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
                EndContext();
                BeginContext(3434, 58, true);
                WriteLiteral("\r\n                                <span class=\"hidden-xs\">");
                EndContext();
                BeginContext(3493, 26, false);
#line 72 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
                                                   Write(Operator.Property.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(3519, 246, true);
                WriteLiteral("</span>\r\n                            </a>\r\n                            <ul class=\"dropdown-menu\">\r\n                                <!-- User image -->\r\n                                <li class=\"user-header\">\r\n                                    ");
                EndContext();
                BeginContext(3765, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97b0ee4e1ae34a02b68d060d405d46c3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3863, 83, true);
                WriteLiteral("\r\n                                    <p>\r\n                                        ");
                EndContext();
                BeginContext(3947, 26, false);
#line 79 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
                                   Write(Operator.Property.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(3973, 135, true);
                WriteLiteral("\r\n                                    </p>\r\n                                </li>\r\n                                <!-- Menu Body -->\r\n");
                EndContext();
                BeginContext(4933, 570, true);
                WriteLiteral(@"                                <!-- Menu Footer-->
                                <li class=""user-footer"">
                                    <div class=""pull-left"">
                                        <button id=""changePwd"" class=""btn btn-default btn-flat"">Cambiar Contraseña</button>
                                    </div>
                                    <div class=""pull-right"">
                                        <button id=""logout"" type=""button"" class=""btn btn-default btn-flat"">Salir</button>
                                    </div>
");
                EndContext();
                BeginContext(5550, 755, true);
                WriteLiteral(@"                            </ul>
                        </li>
                        <!-- Control Sidebar Toggle Button -->
                        <li>
                            <a href=""#"" data-toggle=""control-sidebar""><i class=""fa fa-gears""></i></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <!-- Left side column. contains the logo and sidebar -->
        <aside class=""main-sidebar"">
            <!-- sidebar: style can be found in sidebar.less -->
            <section class=""sidebar"">
                <!-- Sidebar user panel -->
                <div class=""user-panel"">
                    <div class=""pull-left image"">
                        ");
                EndContext();
                BeginContext(6305, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "81f36b27dbb54ffbab2523bbee12de71", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6403, 107, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"pull-left info\">\r\n                        <p>");
                EndContext();
                BeginContext(6511, 26, false);
#line 125 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
                      Write(Operator.Property.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(6537, 3055, true);
                WriteLiteral(@"</p>
                        <a href=""#""><i class=""fa fa-circle text-success""></i> Online</a>
                    </div>
                </div>
                <!-- search form -->
                <form action=""#"" method=""get"" class=""sidebar-form"">
                    <div class=""input-group"">
                        <input type=""text"" name=""q"" class=""form-control"">
                        <span class=""input-group-btn"">
                            <button type=""button"" name=""search"" id=""search-btn"" class=""btn btn-flat"" onclick=""search_menu()"">
                                <i class=""fa fa-search""></i>
                            </button>
                        </span>
                    </div>
                </form>
                <!-- /.search form -->
                <!-- sidebar menu: : style can be found in sidebar.less -->
                <ul class=""sidebar-menu""></ul>
            </section>
            <!-- /.sidebar -->
        </aside>
        <!-- Content Wrapper. Contains");
                WriteLiteral(@" page content -->
        <div class=""content-wrapper"" id=""content-wrapper"" style=""min-height: 421px;"">
            <!--bootstrap tab风格 多标签页-->
            <div class=""content-tabs"">
                <button class=""roll-nav roll-left tabLeft"" onclick=""scrollTabLeft()"">
                    <i class=""fa fa-backward""></i>
                </button>
                <nav class=""page-tabs menuTabs tab-ui-menu"" id=""tab-menu"">
                    <div class=""page-tabs-content"" style=""margin-left: 0px;"">
                    </div>
                </nav>
                <button class=""roll-nav roll-right tabRight"" onclick=""scrollTabRight()"">
                    <i class=""fa fa-forward"" style=""margin-left: 3px;""></i>
                </button>
                <div class=""btn-group roll-nav roll-right"">
                    <button class=""dropdown tabClose"" data-toggle=""dropdown"">
                        Tabulacion<i class=""fa fa-caret-down"" style=""padding-left: 3px;""></i>
                    </button>
    ");
                WriteLiteral(@"                <ul class=""dropdown-menu dropdown-menu-right"" style=""min-width: 128px;"">
                        <li><a class=""tabReload"" href=""javascript:refreshTab();"">Actualizar</a></li>
                        <li><a class=""tabCloseCurrent"" href=""javascript:closeCurrentTab();"">Cerrar</a></li>
                        <li><a class=""tabCloseAll"" href=""javascript:closeOtherTabs(true);"">Cerrar Todo</a></li>
                        <li><a class=""tabCloseOther"" href=""javascript:closeOtherTabs();"">Este No</a></li>
                    </ul>
                </div>
                <button class=""roll-nav roll-right fullscreen"" onclick=""App.handleFullScreen()"">
                    <i class=""fa fa-arrows-alt""></i>
                </button>
            </div>
            <div class=""content-iframe "" style=""background-color: #ffffff; "">
                <div class=""tab-content "" id=""tab-content"">
                </div>
            </div>
        </div>
        <!-- /.content-wrapper -->
");
                EndContext();
                BeginContext(9931, 326, true);
                WriteLiteral(@"        <!-- Control Sidebar -->
        
        <!-- /.control-sidebar -->
        <!-- Add the sidebar's background. This div must be placed
             immediately after the control sidebar -->
        <div class=""control-sidebar-bg""></div>
    </div>
    <!-- ./wrapper -->
    <!-- jQuery 2.2.3 -->
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10257, "\"", 10321, 1);
#line 197 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10263, Url.Scrpit("~/Scripts/vendor/jQuery/jquery-2.2.3.min.js"), 10263, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10322, 53, true);
                WriteLiteral("></script>\r\n    <!-- Bootstrap 3.3.6 -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10375, "\"", 10442, 1);
#line 199 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10381, Url.Scrpit("~/Scripts/vendor/bootstrap/js/bootstrap.min.js"), 10381, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10443, 48, true);
                WriteLiteral("></script>\r\n    <!-- Slimscroll -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10491, "\"", 10564, 1);
#line 201 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10497, Url.Scrpit("~/Scripts/vendor/slimScroll/jquery.slimscroll.min.js"), 10497, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10565, 47, true);
                WriteLiteral("></script>\r\n    <!-- FastClick -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10612, "\"", 10672, 1);
#line 203 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10618, Url.Scrpit("~/Scripts/vendor/fastclick/fastclick.js"), 10618, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10673, 50, true);
                WriteLiteral("></script>\r\n    <!-- AdminLTE App -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10723, "\"", 10784, 1);
#line 205 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10729, Url.Scrpit("~/Scripts/vendor/adminlte/dist/js/app.js"), 10729, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10785, 64, true);
                WriteLiteral("></script>\r\n    <!-- AdminLTE for demo purposes -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10849, "\"", 10911, 1);
#line 207 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10855, Url.Scrpit("~/Scripts/vendor/adminlte/dist/js/demo.js"), 10855, 56, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10912, 40, true);
                WriteLiteral("></script>\r\n    <!--tabs-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10952, "\"", 11020, 1);
#line 209 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10958, Url.Scrpit("~/Scripts/vendor/adminlte/dist/js/app_iframe.js"), 10958, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11021, 43, true);
                WriteLiteral("></script>\r\n\r\n    <!--layer-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 11064, "\"", 11116, 1);
#line 212 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 11070, Url.Scrpit("~/Scripts/vendor/layer/layer.js"), 11070, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11117, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 11140, "\"", 11200, 1);
#line 213 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 11146, Url.Scrpit("~/Scripts/vendor/layer/layer-extends.js"), 11146, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11201, 40, true);
                WriteLiteral("></script>\r\n\r\n    <!--fx-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 11241, "\"", 11284, 1);
#line 216 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 11247, Url.Scrpit("~/Scripts/util/util.js"), 11247, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11285, 74, true);
                WriteLiteral("></script>\r\n\r\n    <script type=\"text/javascript\">\r\n        var rootUrl = \'");
                EndContext();
                BeginContext(11360, 17, false);
#line 219 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
                  Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(11377, 25, true);
                WriteLiteral("\';\r\n\r\n        var menus =");
                EndContext();
                BeginContext(11403, 9, false);
#line 221 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Views\Home\Index.cshtml"
              Write(menusJson);

#line default
#line hidden
                EndContext();
                BeginContext(11412, 2178, true);
                WriteLiteral(@";
        /**
         * 本地搜索菜单
         */
        function search_menu() {
            //要搜索的值
            var text = $('input[name=q]').val();

            var $ul = $('.sidebar-menu');
            $ul.find(""a.nav-link"").each(function () {
                var $a = $(this).css(""border"", """");

                //判断是否含有要搜索的字符串
                if ($a.children(""span.menu-text"").text().indexOf(text) >= 0) {

                    //如果a标签的父级是隐藏的就展开
                    $ul = $a.parents(""ul"");

                    if ($ul.is("":hidden"")) {
                        $a.parents(""ul"").prev().click();
                    }

                    //点击该菜单
                    $a.click().css(""border"", ""1px solid"");
                }
            });
        }

        $(function () {
            //更改密码
            $('#changePwd').click(function () {
                dialogOpen({
                    id: 'changePwdForm',
                    title: 'Cambiar Contraseña',
                    btn: ['Ok', ");
                WriteLiteral(@"'Cancelar'],
                    height: '40%',
                    width:'50%',
                    url: rootUrl + 'Base_SysManage/Base_User/ChangePwdForm',
                    yes: function (window, body) {
                        window.submitForm();
                    }
                });
            });

            //注销
            $('#logout').click(function () {
                dialogComfirm('Desea salir？', function () {
                    $.postJSON(rootUrl + 'Home/Logout', {}, function (resJson) {
                        if (resJson.Success)
                            top.location.href = rootUrl + 'Home/Login';
                    });
                });
            });

            App.setbasePath(""/Scripts/vendor/adminlte/"");
            App.setGlobalImgPath(""dist/img/"");

            addTabs({
                id: '324708b9-5027-4fd0-a9eb-a001d214ca72',
                title: 'INTRO',
                close: true,
                url: '/Home/Desktop',
            });");
                WriteLiteral("\r\n\r\n            App.fixIframeCotent();\r\n            $(\'.sidebar-menu\').sidebarMenu({ data: menus });\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13597, 9, true);
            WriteLiteral("\r\n</html>");
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
