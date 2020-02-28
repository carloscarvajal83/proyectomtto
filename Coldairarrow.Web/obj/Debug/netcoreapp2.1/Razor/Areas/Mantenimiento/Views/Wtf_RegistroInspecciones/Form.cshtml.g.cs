#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52511b499202caa3980ea999d01694a3df59e64f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mantenimiento_Views_Wtf_RegistroInspecciones_Form), @"mvc.1.0.view", @"/Areas/Mantenimiento/Views/Wtf_RegistroInspecciones/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Mantenimiento/Views/Wtf_RegistroInspecciones/Form.cshtml", typeof(AspNetCore.Areas_Mantenimiento_Views_Wtf_RegistroInspecciones_Form))]
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
#line 1 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
using Coldairarrow.Entity.Mantenimiento;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
using Coldairarrow.Util;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52511b499202caa3980ea999d01694a3df59e64f", @"/Areas/Mantenimiento/Views/Wtf_RegistroInspecciones/Form.cshtml")]
    public class Areas_Mantenimiento_Views_Wtf_RegistroInspecciones_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout_Form.cshtml";

    var obj = (Wtf_RegistroInspecciones)Model;
    var objStr = Html.Raw(obj.ToJson());
    var idTool = obj.IdHerramienta;
    string Herramienta = obj.Herramienta;

#line default
#line hidden
            BeginContext(293, 303, true);
            WriteLiteral(@"<div style=""padding:15px;padding-right:45px;"">
    <form id=""form"" class=""form-horizontal"" role=""form"">

        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Herramienta</label>
            <div class=""col-sm-5"">
                <input name=""Herramienta""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 596, "\"", 616, 1);
#line 18 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
WriteAttributeValue("", 604, Herramienta, 604, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(617, 863, true);
            WriteLiteral(@" type=""text"" class=""form-control"" disabled>
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Control</label>
            <div class=""col-sm-5"">
                <select id=""controlList"" class=""selectpicker form-control"" name=""controlList"" data-style=""btn-default btn-sm"" required title=""Seleccione un Tipo""></select>
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        <div class=""form-group form-group-sm"" id=""container"" style=""position:relative"">
            <label class=""col-sm-2 control-label"">F. Inspeccion</label>
            <div class=""col-sm-5"" style=""position:relative"">
                <input id=""FechaInspeccion"" name=""FechaInspeccion"" type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1480, "\"", 1534, 1);
#line 32 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
WriteAttributeValue("", 1488, obj.FechaInspeccion?.ToString("yyyy-MM-dd"), 1488, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1535, 404, true);
            WriteLiteral(@" data-date-format=""yyyy-mm-dd"" class=""form-control"" required autocomplete=""off"">
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        <!--
        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">CodigoWO</label>
            <div class=""col-sm-5"">
                <input name=""CodigoWO"" id=""CodigoWO"" value=""");
            EndContext();
            BeginContext(1940, 12, false);
#line 40 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
                                                       Write(obj.CodigoWO);

#line default
#line hidden
            EndContext();
            BeginContext(1952, 596, true);
            WriteLiteral(@""" type=""text"" class=""form-control"" hidden>
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        -->
        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Inspecciones</label>
            <div class=""col-sm-5"">
                <table id=""inspecTable"" class=""table-bordered""></table>
            </div>
        </div>

        <div class=""form-group"">
            <button id=""submit"" type=""submit"" class=""hidden"">Enviar</button>
        </div>
    </form>
</div>
<script>
    var theEntity = ");
            EndContext();
            BeginContext(2549, 6, false);
#line 58 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
               Write(objStr);

#line default
#line hidden
            EndContext();
            BeginContext(2555, 19, true);
            WriteLiteral(";\n    var typeId = ");
            EndContext();
            BeginContext(2575, 21, false);
#line 59 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
            Write(obj.IdTipoHerramienta);

#line default
#line hidden
            EndContext();
            BeginContext(2596, 60, true);
            WriteLiteral(";\n    var $inspectable = $(\'#inspecTable\')\n    var idTool = ");
            EndContext();
            BeginContext(2657, 17, false);
#line 61 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_RegistroInspecciones\Form.cshtml"
            Write(obj.IdHerramienta);

#line default
#line hidden
            EndContext();
            BeginContext(2674, 3659, true);
            WriteLiteral(@";

    $(function () {
        initEvent();
    });

    //事件绑定
    function initEvent() {
        $('#FechaInspeccion').datetimepicker({
            language: 'es',
            minView: 2//日期选择
        });
        $('#controlList').selectpicker({
            url: '/Mantenimiento/Wtf_Controles/GetDataList_ByType?IdTipoHerramienta={0}'.format(typeId),
            valueField: 'Id',
            textField: 'Nombre',
            pleaseSelect: false
        });
        $inspectable.bootstrapTable({
            url: '/Mantenimiento/Wtf_RegistroInspecciones/GetDataList_NoPagin',
            idField: 'Id',
            pagination: false,
            method: 'post',
            clickToSelect: true,
            height: 220,
            contentType: 'application/x-www-form-urlencoded',
            columns: [
                { title: 'Control', field: 'Control', width: '55%' },
                {title: 'F. Inspeccion', field: 'FechaInspeccion', width: '20%', formatter: function (value) {
                 ");
            WriteLiteral(@"       return toDateString(value, 'yyyy-MM-dd');
                    }
                },
                {
                    title: 'Accion', field: '_', width: '15%', formatter: function (value, row) {
                        var builder = new BtnBuilder();
                        builder.AddBtn({ icon: 'glyphicon-trash', function: 'deleteData', param: [row['Id']] });
                        return builder.build();
                    }
                }
            ],
            queryParams: function (params) {
                var searchParams = { IdHerramienta: idTool };
                $.extend(params, searchParams);

                return params;
            },
        });
        //表单校验
        $('#form').validator().on('submit', function (e) {
            //校验成功
            if (!e.isDefaultPrevented()) {
                e.preventDefault();

                var values = $('#form').getValues();

                $.extend(theEntity, values);
                theEntity['IdControl'] = $(");
            WriteLiteral(@"'#controlList').val();
                theEntity['CodigoWO'] = 0;
                loading();
                $.postJSON('/Mantenimiento/Wtf_RegistroInspecciones/SaveData', theEntity, function (resJson) {
                    loading(false);

                    if (resJson.Success) {
                        //parent.$('#dataTable').bootstrapTable('refresh');
                        $('#inspecTable').bootstrapTable('refresh');
                        parent.dialogSuccess();
                        //dialogClose();
                        //$('#FechaInspeccion').val("""");
                        $(""#controlList"").val('default');
                        $(""#controlList"").selectpicker(""refresh"");
                        //$(""#CodigoWO"").val('');

                    }
                    else {
                        dialogError(resJson.Msg);
                    }
                });
            } else {
            }
        })
    }

    function deleteData(id) {
        dialogComfirm('Desea Eliminar？', functi");
            WriteLiteral(@"on () {
            loading();
            $.postJSON('/Mantenimiento/Wtf_RegistroInspecciones/DeleteData', { id: id }, function (resJson) {
                loading(false);

                if (resJson.Success) {
                    $('#inspecTable').bootstrapTable('refresh');
                    dialogSuccess('Eliminado Exitosamente!');
                }
                else {
                    dialogError(resJson.Msg);
                }
            });
        });
    }

    //提交表单
    function submitForm() {
        $('#submit').trigger('click');
    }
</script>");
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
