using Coldairarrow.Business.Mantenimiento;
using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.IO;
using OfficeOpenXml;
using System.Xml;
using System.Drawing;
using OfficeOpenXml.Style;
using Microsoft.AspNetCore.Hosting;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_HerramientasController : BaseMvcController
    {
        Wtf_HerramientasBusiness _wtf_HerramientasBusiness = new Wtf_HerramientasBusiness();
        Wtf_vReporteControlesHerramientaBusiness _wtf_vReporteControlesHerramientaBusiness = new Wtf_vReporteControlesHerramientaBusiness();
        Wtf_vHerramientasBusiness _wtf_VHerramientasBusiness = new Wtf_vHerramientasBusiness();

        private readonly IHostingEnvironment _env;

        public Wtf_HerramientasController(IHostingEnvironment env)
        {
            _env = env;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Wtf_Herramientas() : _wtf_HerramientasBusiness.GetTheData(id);

            return View(theData);
        }

        

        #region 获取数据

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(string condition, string keyword, Pagination pagination)
        {
            var dataList = _wtf_HerramientasBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Wtf_Herramientas theData)
        {
            if (!(theData.Id > 0)){
                if (_wtf_HerramientasBusiness.validarSerialExiste(theData)){
                    return Error("Already exists a tool with serial number " + theData.Serial);
                }else {
                    _wtf_HerramientasBusiness.AddData(theData);
                }
            }else{
                //theData.Id = Guid.NewGuid().ToSequentialGuid();
                if (_wtf_HerramientasBusiness.validarSerialExiste(theData, false)){
                    return Error("Already exists a tool with serial number " + theData.Serial);
                }else {
                    _wtf_HerramientasBusiness.UpdateData(theData);
                }
            }
            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _wtf_HerramientasBusiness.DeleteData(ids.ToList<string>());

            return Success("Successfully deleted!");
        }

        /// <summary>
        /// Genera Reporte en Excel
        /// </summary>
        /// <param name="id">El Identificador de la Herramienta</param>
        public ActionResult VerReporte(int Id)
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var listado = _wtf_vReporteControlesHerramientaBusiness.GetDataList(Id, pagination);
            string Serial = "NA";
            if (listado.Count > 0)
            {
                Serial = listado[0].Serial;
            }
            
            var FechaHoy = DateTime.Now;
            string strYear = FechaHoy.ToString("yyyy");
            string strMes = FechaHoy.ToString("MM");
            string strDia = FechaHoy.ToString("dd");
            string NombreArchivo = "ToolsReport_" + Serial + "_" + strYear + strMes + strDia + ".xlsx";
            string Directorio = "ExportFiles/";
            var serverPath = Path.Combine(_env.WebRootPath, Directorio);
            DirectoryInfo outputDir = new DirectoryInfo(serverPath);
            FileInfo newfile = new FileInfo(outputDir.FullName + NombreArchivo);
            if (newfile.Exists)
            {
                newfile.Delete();
                newfile = new FileInfo(outputDir.FullName + NombreArchivo);
            }
            
            using (var package = new ExcelPackage(newfile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Report");
                worksheet.Row(1).Height = 25;
                worksheet.Cells[1, 1].Value = "REPORTE ESTADO HERRAMIENTA";
                worksheet.Cells[1, 1, 2, 7].Style.Font.Bold = true;
                worksheet.Cells[1, 1, 2, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, 1, 2, 7].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[1, 1, 1, 7].Merge = true;
                worksheet.Cells["A1:G1"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Column(1).Width = 30.78;
                worksheet.Column(2).Width = 15.78;
                worksheet.Column(3).Width = 10.78;
                worksheet.Column(4).Width = 30.78;
                worksheet.Column(5).Width = 50.78;
                worksheet.Column(6).Width = 12.78;
                worksheet.Column(7).Width = 12.78;
                worksheet.Cells["A2:G2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells["A2:G2"].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);
                worksheet.Cells["A2"].Value = "TOOL";
                worksheet.Cells["B2"].Value = "SERIAL";
                worksheet.Cells["C2"].Value = "ITEM NO";
                worksheet.Cells["D2"].Value = "GROUP";
                worksheet.Cells["E2"].Value = "CONTROL";
                worksheet.Cells["F2"].Value = "INSP. DATE";
                worksheet.Cells["G2"].Value = "DUE DATE";
                worksheet.Cells["A2"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["B2"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["C2"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["D2"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["E2"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["F2"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["G2"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                int ifila = 2;
                int ffila = 2;
                foreach (var item in listado)
                {
                    ffila++;
                    worksheet.Cells[ffila, 1].Value = item.Herramienta.ToUpper();
                    worksheet.Cells[ffila, 2].Value = item.Serial.ToUpper();
                    worksheet.Cells[ffila, 3].Value = item.ItemNumber.ToUpper();
                    worksheet.Cells[ffila, 4].Value = item.Familia.ToUpper();
                    worksheet.Cells[ffila, 5].Value = item.Control?.ToUpper();
                    worksheet.Cells[ffila, 6].Value = item.FechaInspeccion;
                    worksheet.Cells[ffila, 6].Style.Numberformat.Format = "dd-mmm-yyyy";
                    worksheet.Cells[ffila, 7].Value = item.ProximaInspecion;
                    worksheet.Cells[ffila, 7].Style.Numberformat.Format = "dd-mmm-yyyy";
                    worksheet.Cells[ffila, 5].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[ffila, 6].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[ffila, 7].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[ffila, 5, ffila, 7].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    switch (item.Estado)
                    {
                        case 1:
                            worksheet.Cells[ffila, 5, ffila, 7].Style.Fill.BackgroundColor.SetColor(255, 0, 255, 0);
                            break;
                        case 2:
                            worksheet.Cells[ffila, 5, ffila, 7].Style.Fill.BackgroundColor.SetColor(255, 255, 192, 0);
                            break;
                        case 3:
                            worksheet.Cells[ffila, 5, ffila, 7].Style.Fill.BackgroundColor.SetColor(255, 255, 0, 0);
                            break;
                        default:
                            break;
                    }
                }
                ifila++;
                for (int i = 1; i <= 4; i++)
                {
                    worksheet.Cells[ifila, i, ffila, i].Merge = true;
                    worksheet.Cells[ifila, i, ffila, i].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                package.Save();
            }
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return Json(new { fileName= NombreArchivo, type = contentType, ruta = Directorio });
        }

        public ActionResult VerReporteGeneral()
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var listado = _wtf_VHerramientasBusiness.GetDataList(null, null, pagination);
            string Control1 = "-";
            string Control2 = "-";
            if (listado.Count > 0)
            {
                Control1 = listado[0].Control1;
                Control2 = listado[0].Control2;
            }

            var FechaHoy = DateTime.Now;
            string strYear = FechaHoy.ToString("yyyy");
            string strMes = FechaHoy.ToString("MM");
            string strDia = FechaHoy.ToString("dd");
            string NombreArchivo = "GeneralToolsReport_" + strYear + strMes + strDia + ".xlsx";
            string Directorio = "ExportFiles/";
            var serverPath = Path.Combine(_env.WebRootPath, Directorio);
            DirectoryInfo outputDir = new DirectoryInfo(serverPath);
            FileInfo newfile = new FileInfo(outputDir.FullName + NombreArchivo);
            if (newfile.Exists)
            {
                newfile.Delete();
                newfile = new FileInfo(outputDir.FullName + NombreArchivo);
            }

            using (var package = new ExcelPackage(newfile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Report");
                worksheet.Row(1).Height = 30;
                worksheet.Row(2).Height = 30;
                worksheet.Cells[1, 1].Value = "REPORTE GENERAL DE HERRAMIENTAS";
                worksheet.Cells[2, 1].Value = "NOMBRE";
                worksheet.Cells[2, 2].Value = "SERIAL";
                worksheet.Cells[2, 3].Value = "FAMILIA";
                worksheet.Cells[2, 4].Value = "UBICACION";
                worksheet.Cells[2, 5].Value = "ESTADO";
                worksheet.Cells[2, 6].Value = "OBSERVACION ESTADO";
                worksheet.Cells[2, 7].Value = Control1;
                worksheet.Cells[2, 8].Value = Control2;

                worksheet.Column(1).Width = 30.78;
                worksheet.Column(2).Width = 15.78;
                worksheet.Column(3).Width = 30.78;
                worksheet.Column(4).Width = 25.78;
                worksheet.Column(5).Width = 15.78;
                worksheet.Column(6).Width = 45.78;
                worksheet.Column(7).Width = 15.78;
                worksheet.Column(8).Width = 15.78;

                worksheet.Cells[1, 1, 2, 8].Style.Font.Bold = true;
                worksheet.Cells[1, 1, 2, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, 1, 2, 8].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[1, 1, 1, 8].Merge = true;
                worksheet.Cells[2, 1, 2, 8].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[2, 1, 2, 8].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);
                worksheet.Cells[1, 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 2].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 3].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 4].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 5].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 6].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 7].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells[2, 8].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                int ffila = 2;
                foreach (var item in listado) {
                    ffila++;
                    worksheet.Cells[ffila, 1].Value = item.Descripcion.ToUpper();
                    worksheet.Cells[ffila, 2].Value = item.Serial.ToUpper();
                    worksheet.Cells[ffila, 3].Value = item.TipoHerramienta.ToUpper();
                    worksheet.Cells[ffila, 4].Value = item.Ubicacion;
                    worksheet.Cells[ffila, 5].Value = item.Estado == 1 ? "Operativo" : "No Operativo";
                    worksheet.Cells[ffila, 6].Value = item.EstadoNoOperativo?.ToUpper();
                    worksheet.Cells[ffila, 7].Style.Numberformat.Format = "dd-mmm-yyyy";
                    worksheet.Cells[ffila, 7].Value = item.ProximaInspecion1;
                    worksheet.Cells[ffila, 7, ffila, 8].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[ffila, 8].Style.Numberformat.Format = "dd-mmm-yyyy";
                    worksheet.Cells[ffila, 8].Value = item.ProximaInspecion2;
                    switch (item.EstadoControl1)
                    {
                        case 1:
                            worksheet.Cells[ffila, 7].Style.Fill.BackgroundColor.SetColor(255, 0, 255, 0);
                            break;
                        case 2:
                            worksheet.Cells[ffila, 7].Style.Fill.BackgroundColor.SetColor(255, 255, 192, 0);
                            break;
                        case 3:
                            worksheet.Cells[ffila, 7].Style.Fill.BackgroundColor.SetColor(255, 255, 0, 0);
                            break;
                        default:
                            break;
                    }
                    switch (item.EstadoControl2)
                    {
                        case 1:
                            worksheet.Cells[ffila, 8].Style.Fill.BackgroundColor.SetColor(255, 0, 255, 0);
                            break;
                        case 2:
                            worksheet.Cells[ffila, 8].Style.Fill.BackgroundColor.SetColor(255, 255, 192, 0);
                            break;
                        case 3:
                            worksheet.Cells[ffila, 8].Style.Fill.BackgroundColor.SetColor(255, 255, 0, 0);
                            break;
                        default:
                            break;
                    }

                }
                package.Save();
            }
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return Json(new { fileName = NombreArchivo, type = contentType, ruta = Directorio });
        }
            #endregion
        }
}