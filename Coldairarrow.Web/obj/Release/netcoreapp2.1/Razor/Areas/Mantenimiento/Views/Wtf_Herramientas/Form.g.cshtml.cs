#pragma checksum "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ccc7a84e21953040ef1e9f2c2d02bc3786f3fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mantenimiento_Views_Wtf_Herramientas_Form), @"mvc.1.0.view", @"/Areas/Mantenimiento/Views/Wtf_Herramientas/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Mantenimiento/Views/Wtf_Herramientas/Form.cshtml", typeof(AspNetCore.Areas_Mantenimiento_Views_Wtf_Herramientas_Form))]
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
#line 1 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
using Coldairarrow.Entity.Mantenimiento;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
using Coldairarrow.Util;

#line default
#line hidden
#line 3 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
using Coldairarrow.Business.Mantenimiento;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ccc7a84e21953040ef1e9f2c2d02bc3786f3fc", @"/Areas/Mantenimiento/Views/Wtf_Herramientas/Form.cshtml")]
    public class Areas_Mantenimiento_Views_Wtf_Herramientas_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout_Form.cshtml";

    var obj = (Wtf_Herramientas)Model;
    var objStr = Html.Raw(obj.ToJson());

#line default
#line hidden
            BeginContext(260, 296, true);
            WriteLiteral(@"
<div style=""padding:15px;padding-right:45px;"">
    <form id=""form"" class=""form-horizontal"" role=""form"">

        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Serial</label>
            <div class=""col-sm-5"">
                <input name=""Serial""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 556, "\"", 575, 1);
#line 18 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
WriteAttributeValue("", 564, obj.Serial, 564, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(576, 337, true);
            WriteLiteral(@" type=""text"" class=""form-control"" required>
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Descripcion</label>
            <div class=""col-sm-5"">
                <input name=""Descripcion""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 913, "\"", 937, 1);
#line 25 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
WriteAttributeValue("", 921, obj.Descripcion, 921, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(938, 2311, true);
            WriteLiteral(@" type=""text"" class=""form-control"" required>
                <div class=""help-block with-errors""></div>
            </div>
        </div>

        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Familia</label>
            <div class=""col-sm-5"">
                <select id=""tipoHList"" class=""selectpicker form-control"" name=""tipoHList"" data-style=""btn-default btn-sm"" required title=""Seleccione un Tipo""></select>
                <div class=""help-block with-errors""></div>
            </div>
        </div>

        <!--
        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Clase H.</label>
            <div class=""col-sm-5"">
                <select id=""claseHList"" class=""selectpicker form-control"" name=""claseHList"" data-style=""btn-default btn-sm"" required title=""Seleccione una clase""></select>
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        -->
        <!--
 ");
            WriteLiteral(@"       <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Ubicacion</label>
            <div class=""col-sm-5"">
                <select id=""plantHList"" class=""selectpicker form-control"" name=""plantHList"" data-style=""btn-default btn-sm"" required title=""Seleccione una base""></select>
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        -->
        <!--
        <div class=""form-group form-group-sm"">
            <label class=""col-sm-2 control-label"">Estado</label>
            <div class=""col-sm-5"">
                <select id=""Estado"" name=""Estado"" class=""selectpicker form-control"" data-style=""btn-default btn-sm"">
                    <option value=""0"">Inactivo</option>
                    <option value=""1"">Activo</option>
                </select>
                <div class=""help-block with-errors""></div>
            </div>
        </div>
        -->
        <!--
        <div class=""form-group form-group-sm"" i");
            WriteLiteral(@"d=""container"" style=""position:relative"">
            <label class=""col-sm-2 control-label"">Adquisicion</label>
            <div class=""col-sm-5"" style=""position:relative"">
                <input id=""FechaAdquisicion"" name=""FechaAdquisicion"" type=""text"" value=""");
            EndContext();
            BeginContext(3251, 44, false);
#line 72 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
                                                                                    Write(obj.FechaAdquisicion?.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(3296, 281, true);
            WriteLiteral(@""" data-date-format=""yyyy-mm-dd"" class=""form-control"">
            </div>
        </div>
        -->

        <div class=""form-group"">
            <button id=""submit"" type=""submit"" class=""hidden"">提交</button>
        </div>
    </form>
</div>
<script>
    var theEntity = ");
            EndContext();
            BeginContext(3578, 6, false);
#line 83 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
               Write(objStr);

#line default
#line hidden
            EndContext();
            BeginContext(3584, 20, true);
            WriteLiteral(";\r\n    var typeId = ");
            EndContext();
            BeginContext(3605, 21, false);
#line 84 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
            Write(obj.IdTipoHerramienta);

#line default
#line hidden
            EndContext();
            BeginContext(3626, 23, true);
            WriteLiteral(";\r\n    //var classId = ");
            EndContext();
            BeginContext(3650, 22, false);
#line 85 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
               Write(obj.IdClaseHerramienta);

#line default
#line hidden
            EndContext();
            BeginContext(3672, 22, true);
            WriteLiteral(";\r\n    //var baseId = ");
            EndContext();
            BeginContext(3695, 15, false);
#line 86 "C:\Users\ADMIN\source\repos\Coldairarrow\Coldairarrow.Web\Areas\Mantenimiento\Views\Wtf_Herramientas\Form.cshtml"
              Write(obj.IdUbicacion);

#line default
#line hidden
            EndContext();
            BeginContext(3710, 3150, true);
            WriteLiteral(@";

    $(function () {
        initEvent();
    });

    //事件绑定
    function initEvent() {
        /*
        $('#Estado').selectpicker({
            value: theEntity.Estado
        });
        $('#FechaAdquisicion').datetimepicker({
            language: 'es',
            minView: 2//日期选择
        });
        */
        $('#tipoHList').selectpicker({
            url: '/Mantenimiento/Wtf_TipoHerramienta/GetDataList_NoPagin',
            value: typeId,
            valueField: 'Id',
            textField: 'Descripcion',
            pleaseSelect: false
        });
        $('#tipoHList').on('refreshed.bs.select', function (e) {
            // calls on data loaded
            if (typeId > 0) {
                $(this).selectpicker('val', typeId);
            }
        });

        /*
        $('#claseHList').selectpicker({
            url: '/Mantenimiento/Wtf_ClaseHerramienta/GetDataList_NoPagin',
            value: classId,
            valueField: 'Id',
            textField: 'N");
            WriteLiteral(@"ombre',
            pleaseSelect: false
        });
        $('#claseHList').on('refreshed.bs.select', function (e) {
            // calls on data loaded
            if (classId > 0) {
                $(this).selectpicker('val', classId);
            }
        });

        $('#plantHList').selectpicker({
            url: '/Mantenimiento/Wtf_Ubicaciones/GetDataList_NoPagin',
            value: baseId,
            valueField: 'Id',
            textField: 'Nombre',
            pleaseSelect: false
        });
        $('#plantHList').on('refreshed.bs.select', function (e) {
            // calls on data loaded
            if (baseId > 0) {
                $(this).selectpicker('val', baseId);
            }
        });
        */

        //表单校验
        $('#form').validator().on('submit', function (e) {
            //校验成功
            if (!e.isDefaultPrevented()) {
                e.preventDefault();

                var values = $('#form').getValues();
                $.extend(theEnti");
            WriteLiteral(@"ty, values);

                theEntity['IdTipoHerramienta'] = $('#tipoHList').val();
                //theEntity['IdClaseHerramienta'] = $('#claseHList').val();
                //theEntity['IdUbicacion'] = $('#plantHList').val();
                theEntity['IdClaseHerramienta'] = 1;
                theEntity['IdUbicacion'] = 1;
                theEntity['Estado'] = 1;
                theEntity['FechaAdquisicion'] = ""2018-01-01"";

                loading();
                $.postJSON('/Mantenimiento/Wtf_Herramientas/SaveData', theEntity, function (resJson) {
                    loading(false);

                    if (resJson.Success) {
                        parent.$('#dataTable').bootstrapTable('refresh');
                        parent.dialogSuccess();
                        dialogClose();
                    }
                    else {
                        dialogError(resJson.Msg);
                    }
                });
            }
        })
    }

    //提交表单
    fun");
            WriteLiteral("ction submitForm() {\r\n        $(\'#submit\').trigger(\'click\');\r\n    }\r\n</script>");
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
