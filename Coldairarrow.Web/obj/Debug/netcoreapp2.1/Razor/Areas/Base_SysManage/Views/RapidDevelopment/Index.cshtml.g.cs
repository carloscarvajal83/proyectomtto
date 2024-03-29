#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\RapidDevelopment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be54ef4d3372d4ccc8be61a62418a52b73183d2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Base_SysManage_Views_RapidDevelopment_Index), @"mvc.1.0.view", @"/Areas/Base_SysManage/Views/RapidDevelopment/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Base_SysManage/Views/RapidDevelopment/Index.cshtml", typeof(AspNetCore.Areas_Base_SysManage_Views_RapidDevelopment_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be54ef4d3372d4ccc8be61a62418a52b73183d2a", @"/Areas/Base_SysManage/Views/RapidDevelopment/Index.cshtml")]
    public class Areas_Base_SysManage_Views_RapidDevelopment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Base_SysManage\Views\RapidDevelopment\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout_List.cshtml";

#line default
#line hidden
            BeginContext(56, 3234, true);
            WriteLiteral(@"
<div class=""fx-content"">
    <div class=""fx-wrapper"">
        <form class=""form-inline"" id=""searchForm"">
            <div class=""form-group"">
                <label>Por favor seleccione una base de datos</label>
                <select class=""selectpicker"" id=""linkId"" name=""linkId"" data-style=""btn-default btn-sm"" data-width=""200px"">
                </select>
            </div>
            <div class=""form-group"">
                <button id=""buildCode"" type=""button"" class=""btn btn-default btn-sm"">
                    <i class=""glyphicon glyphicon-search""></i>
                    Generar Codigo
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

    $(function () {
        initTable();
        bindEvent();
    });

    //初始化表格
    function initTable() {
        $table.bootstrapTable({
            url: rootUrl + 'Base_SysManage/RapidDevelop");
            WriteLiteral(@"ment/GetDbTableList',
            idField: 'Id',
            pagination: false,
            method: 'post',
            clickToSelect: true,
            //sidePagination: ""server"",
            //pageNumber: 1,
            //pageSize: 30,
            //pageList: [10, 30, 60, 100],
            columns: [
                { title: 'ck', field: 'ck', checkbox: true, width: '3%' },
                { title: 'Tabla', field: 'TableName', width: '10%' },
                { title: 'Descripcion', field: 'Description', width: '20%' },
                {
                    title: '', field: '_', width: '100%', formatter: function () {
                        return '';
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
        $('#linkId').selectpicker({
         ");
            WriteLiteral(@"   url: '/Base_SysManage/RapidDevelopment/GetAllDbLink',
            textField: 'LinkName',
            valueField: 'Id',
            onSelect: function (value) {
                $table.bootstrapTable('refresh');
            }
        });

        $('#buildCode').click(function () {
            var tables = [];

            var rows = $table.bootstrapTable('getSelections');
            if (rows.length == 0) {
                dialogError('Por favor selecciona la tabla que quieres generar！');
                return;
            } else {
                $.each(rows, function (index, value) {
                    tables.push(value['TableName']);
                })
            }

            var linkId = $('#linkId').val();
            dialogOpen({
                id: 'form',
                height:'50%',
                title: 'Construir',
                btn: ['Generar', 'Cancelar'],
                url: rootUrl + 'Base_SysManage/RapidDevelopment/Form?linkId={0}&tables={1}'.format(linkId, encodeURI(JSON.stringify");
            WriteLiteral("(tables))),\n                yes: function (window, body) {\n                    window.submitForm();\n                }\n            });\n        });\n    }\n</script>\n");
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
