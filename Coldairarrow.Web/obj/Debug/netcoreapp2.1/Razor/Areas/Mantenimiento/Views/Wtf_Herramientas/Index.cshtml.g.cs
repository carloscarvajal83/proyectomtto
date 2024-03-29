#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abd3c5f7539a04e32d8f0b40b0d4deca47f042b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mantenimiento_Views_Wtf_Herramientas_Index), @"mvc.1.0.view", @"/Areas/Mantenimiento/Views/Wtf_Herramientas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Mantenimiento/Views/Wtf_Herramientas/Index.cshtml", typeof(AspNetCore.Areas_Mantenimiento_Views_Wtf_Herramientas_Index))]
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
#line 1 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Index.cshtml"
using Coldairarrow.Util;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Index.cshtml"
using Coldairarrow.Business.Base_SysManage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abd3c5f7539a04e32d8f0b40b0d4deca47f042b3", @"/Areas/Mantenimiento/Views/Wtf_Herramientas/Index.cshtml")]
    public class Areas_Mantenimiento_Views_Wtf_Herramientas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";
    var toolsManage = PermissionManage.OperatorHasPermissionValue("sysuser.admintools");


#line default
#line hidden
            BeginContext(224, 2063, true);
            WriteLiteral(@"<div class=""fx-content"">
    <div id=""toobar"">
        <div class=""btn-group btn-group-sm"">
            <button id=""btnAdd"" onclick=""openForm('', 'NUEVA HERRAMIENTA');"" type=""button"" class=""btn btn-default"" aria-label=""Left Align"">
                <span class=""glyphicon glyphicon-plus"" aria-hidden=""true""></span>
                NEW
            </button>
            <button id=""btnDelete"" onclick=""deleteData();"" type=""button"" class=""btn btn-default"" aria-label=""Right Align"">
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
            <div class=""form-group"">");
            WriteLiteral(@"
                <label>Consulta</label>
                <select class=""selectpicker"" name=""condition"" data-style=""btn-default btn-sm"" data-width=""100px"">
                    <option value="""">Seleccione</option>

                    <option value=""Serial"">Serial</option>
                    <option value=""Descripcion"">Descripcion</option>
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
 ");
            WriteLiteral("   var raiz = \'");
            EndContext();
            BeginContext(2288, 23, false);
#line 51 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Index.cshtml"
           Write(GlobalSwitch.WebRootUrl);

#line default
#line hidden
            EndContext();
            BeginContext(2311, 25, true);
            WriteLiteral("\';\r\n    var toolsManage =");
            EndContext();
            BeginContext(2337, 32, false);
#line 52 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Index.cshtml"
                Write(toolsManage.ToString().ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(2369, 4761, true);
            WriteLiteral(@";

    $(function () {
        initTable();
        bindEvent();
        raiz = raiz + ""/"";
        $('[data-toggle=""tooltip""]').tooltip();
        if (!toolsManage) {
            $(""#btnAdd"").css('display', 'none');
            $(""#btnDelete"").css('display', 'none');
        }
    });

    //初始化表格
    function initTable() {
        $table.bootstrapTable({
            url: '/Mantenimiento/Wtf_vHerramientas/GetDataList',
            idField: 'Id',
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
                { title: 'ck', field: 'ck', checkbox: true, width: '3%' },
                { title: 'Serial', field: 'Serial', width: '10%' },
                { title: 'Descripcion', field: 'Descripcio");
            WriteLiteral(@"n', width: '40%' },
                { title: 'Tipo H.', field: 'TipoHerramienta', width: '20%' },
                {
                    title: 'ACCIONES', field: '_', width: '20%', formatter: function (value, row) {
                        var builder = new BtnBuilder();
                        if (toolsManage) {
                            builder.AddBtn({ icon: 'glyphicon-edit', function: 'openForm', param: [row['Id'], 'EDITAR HERRAMIENTA'], title: ""Editar Herramienta"" });
                            builder.AddBtn({ icon: 'glyphicon-trash', function: 'deleteData', param: [row['Id']], title: ""Eliminar Herramienta"" });
                            builder.AddBtn({ icon: 'glyphicon-list-alt', function: 'openForm2', param: [row['Id'], 'REGISTRO INSPECCIONES'], title: ""Agregar Inspeccion"" });
                        }
                        builder.AddBtn({ icon: 'glyphicon-save-file', function: 'loadReport', param: [row['Id']], title: ""Ver Reporte"" });
                        return builder.build();");
            WriteLiteral(@"
                    }
                }
            ],
            queryParams: function (params) {
                var searchParams = $('#searchForm').getValues();
                $.extend(params, searchParams);

                return params;
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
            height: '100%',
            url: '/Mantenimiento/Wtf_Herramientas/Form?id={0}'.format(id || ''),
            yes: function (window, body) {
                window.submitForm();
            }
        });
    }

    function openForm2(id, typeId, title) {
        dialogOpen({
            id: 'form',
            title: title,
            btn: ['Ok', 'Cancel'],
            height: '100%',
            url: '/Mantenimiento/Wtf_RegistroInspecciones/Form?id={0}&IdHerramienta={1}'.format('', id),
   ");
            WriteLiteral(@"         yes: function (window, body) {
                window.submitForm();
            }
        });
    }

    function loadReport(Id) {
        $.ajax({
            url: '/Mantenimiento/Wtf_Herramientas/VerReporte?Id='+Id,
            contentType: 'application/json; charset=utf-8',
            datatype: 'json',
            type: ""GET"",
            success: function (data) {
                //alert(""sucess"");
                window.location = raiz + data.ruta + data.fileName;
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
                } else {");
            WriteLiteral(@"
                    $.each(rows, function (index, value) {
                        ids.push(value['Id']);
                    })
                }
            }

            loading();
            $.postJSON('/Mantenimiento/Wtf_Herramientas/DeleteData', { ids: JSON.stringify(ids) }, function (resJson) {
                loading(false);

                if (resJson.Success) {
                    $table.bootstrapTable('refresh');
                    dialogSuccess('Eliminado Exitosamente!');
                }
                else {
                    dialogError(resJson.Msg);
                }
            });
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
