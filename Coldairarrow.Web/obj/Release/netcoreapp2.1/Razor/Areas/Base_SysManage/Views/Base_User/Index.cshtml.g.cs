#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b33069bd37b39fc78341c740734333b67cfa70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_SysManage_Views_Base_User_Index), @"mvc.1.0.view", @"/Areas/Base_SysManage/Views/Base_User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Base_SysManage/Views/Base_User/Index.cshtml", typeof(AspNetCore.Areas_Base_SysManage_Views_Base_User_Index))]
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
#line 1 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
using Coldairarrow.Business.Base_SysManage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b33069bd37b39fc78341c740734333b67cfa70", @"/Areas/Base_SysManage/Views/Base_User/Index.cshtml")]
    public class Areas_Base_SysManage_Views_Base_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";
    var manageSysPermission = PermissionManage.OperatorHasPermissionValue("sysuser.manageSysPermission");
    var userManage = PermissionManage.OperatorHasPermissionValue("sysuser.manage");

#line default
#line hidden
            BeginContext(299, 2044, true);
            WriteLiteral(@"
<div class=""fx-content"">
    <div id=""toobar"">
        <div class=""btn-group btn-group-sm"">
            <button onclick=""openForm('', 'AGREGAR USUARIO');"" type=""button"" class=""btn btn-default"" aria-label=""Left Align"">
                <span class=""glyphicon glyphicon-plus"" aria-hidden=""true""></span>
                NEW
            </button>
            <button onclick=""deleteData();"" type=""button"" class=""btn btn-default"" aria-label=""Right Align"">
                <span class=""glyphicon glyphicon-trash"" aria-hidden=""true""></span>
                DELETE
            </button>
            <button type=""button"" class=""btn btn-default"" aria-label=""Right Align"" onclick=""javascript: location.reload();"">
                <span class=""glyphicon glyphicon-refresh"" aria-hidden=""true""></span>
                REFRESH
            </button>
        </div>
    </div>
    <div class=""fx-wrapper"">
        <form class=""form-inline"" id=""searchForm"">
            <div class=""form-group"">
                <label>Co");
            WriteLiteral(@"nsulta</label>
                <select class=""selectpicker"" name=""condition"" data-style=""btn-default btn-sm"" data-width=""100px"">
                    <option value="""">Seleccione</option>
                    <option value=""UserName"">Usuario</option>
                    <option value=""RealName"">Nombre</option>
                </select>
                <input type=""text"" class=""form-control input-sm"" name=""keyword"" placeholder=""Ingrese Texto"">
            </div>
            <div class=""form-group"">
                <button type=""button"" class=""btn btn-default btn-sm"" onclick=""javascript: $('#dataTable').bootstrapTable('refresh', { silent: true });"">
                    <i class=""glyphicon glyphicon-search""></i>
                    BUSCAR
                </button>
            </div>
        </form>
    </div>
    <div class=""fx-wrapper"">
        <table id=""dataTable"" class=""table-bordered""></table>
    </div>
</div>

<script>
    var $table = $('#dataTable');
    var manageSysPermission =");
            EndContext();
            BeginContext(2344, 40, false);
#line 52 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
                        Write(manageSysPermission.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(2384, 23, true);
            WriteLiteral(";\r\n    var userManage =");
            EndContext();
            BeginContext(2408, 31, false);
#line 53 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\Base_User\Index.cshtml"
               Write(userManage.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(2439, 4751, true);
            WriteLiteral(@";

    $(function () {
        initTable();
        bindEvent();
    });

    //初始化表格
    function initTable() {
        $table.bootstrapTable({
            url: '/Base_SysManage/Base_User/GetDataList',
            idField: 'id',
            pagination: true,
            method: 'post',
            clickToSelect: false,
            sidePagination: ""server"",
            contentType: 'application/x-www-form-urlencoded',
            queryParamsType: '',
            pageNumber: 1,
            pageSize: 30,
            pageList: [10, 30, 60, 100],
            columns: [
                { title: 'ck', field: 'ck', checkbox: true },
                { title: 'USUARIO', field: 'UserName', width: 200 },
                { title: 'NOMBRE', field: 'RealName', width: 200 },
                {
                    title: 'GENERO', field: 'Sex', width: 200, formatter: function (value, row) {
                        var mapping = {
                            '1': 'HOMBRE',
                         ");
            WriteLiteral(@"   '0': 'MUJER'
                        };

                        return mapping[value];
                    }
                },
                {
                    title: 'F. NACIMIENTO', field: 'Birthday', width: 200, formatter: function (value) {
                        return toDateString(value, 'yyyy-MM-dd');
                    }
                },
                { title: 'ROL', field: 'RoleNameList', width: 600 },
                {
                    title: 'ACCIONES', field: '_', width: '20%', formatter: function (value, row) {
                        var builder = new BtnBuilder();
                        if (userManage) {
                            builder.AddBtn({ icon: 'glyphicon-edit', function: 'openForm', param: [row['Id']] });
                            builder.AddBtn({ icon: 'glyphicon-trash', function: 'deleteData', param: [row['Id']] });
                        }
                        if (manageSysPermission) {
                            builder.AddBtn({ name");
            WriteLiteral(@": 'AUTORIZAR', icon: 'glyphicon-edit', function: 'setPermission', param: [row['UserId'], row['RealName']] });
                        }

                        return builder.build();
                    }
                }
            ],
            queryParams: function (params) {
                var searchParams = $('#searchForm').getValues();
                $.extend(params, searchParams);

                return params;
            },
            onLoadSuccess: function () {
                if (!userManage) {
                    $('#dataTable').bootstrapTable('hideColumn', '_');
                }
            }
        });
    }

    //绑定事件
    function bindEvent() {

    }

    //打开表单
    function openForm(id, title) {
        dialogOpen({
            id: 'form',
            title: title,
            btn: ['Ok', 'Cancel'],
            url: '/Base_SysManage/Base_User/Form?id={0}'.format(id || ''),
            yes: function (window, body) {
                window.submitFo");
            WriteLiteral(@"rm();
            }
        });
    }

    //删除数据
    function deleteData(id) {
        dialogComfirm('Desea Eliminar？', function () {
            var ids = [];

            if (typeof (id) == 'string') {//单条数据
                ids.push(id);
            } else {//多条数据
                var rows = $table.bootstrapTable('getSelections');
                if (rows.length == 0) {
                    dialogError('Por favor, seleccione los datos que desea eliminar！');
                    return;
                } else {
                    $.each(rows, function (index, value) {
                        ids.push(value['Id']);
                    })
                }
            }

            loading();
            $.postJSON('/Base_SysManage/Base_User/DeleteData', { ids: JSON.stringify(ids) }, function (resJson) {
                loading(false);

                if (resJson.Success) {
                    $table.bootstrapTable('refresh');
                    dialogSuccess('Eliminado Exitosam");
            WriteLiteral(@"ente!');
                }
                else {
                    dialogError(resJson.Msg);
                }
            });
        });
    }

    //设置权限
    function setPermission(userId, realName) {
        dialogOpen({
            id: 'permissionForm',
            title: 'Permisos para {0}'.format(realName),
            width: '80.5%',
            height: '80.5%',
            btn: ['Asignar', 'Cancelar'],
            url: '/Base_SysManage/Base_User/PermissionForm?userId={0}'.format(userId),
            yes: function (iframeWin) {
                iframeWin.savePermission();
            }
        });
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
