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
using System.Text.RegularExpressions;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_HerramientasController : BaseMvcController
    {
        Wtf_HerramientasBusiness _wtf_HerramientasBusiness = new Wtf_HerramientasBusiness();
        Wtf_vReporteControlesHerramientaBusiness _wtf_vReporteControlesHerramientaBusiness = new Wtf_vReporteControlesHerramientaBusiness();

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
                    return Error("Ya existe una herramienta con el serial " + theData.Serial);
                }else {
                    _wtf_HerramientasBusiness.AddData(theData);
                }
            }else{
                //theData.Id = Guid.NewGuid().ToSequentialGuid();
                if (_wtf_HerramientasBusiness.validarSerialExiste(theData, false)){
                    return Error("Ya existe una herramienta con el serial " + theData.Serial);
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

            return Success("删除成功！");
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
            string serialHerramienta = "-";
            string familiaHerramienta = "-";
            string itemNumberHerramienta = "-";
            string nombreHerramienta = "-";
            if (listado.Count > 0)
            {
                serialHerramienta = listado[0].Serial;
                familiaHerramienta = listado[0].Familia.ToUpper();
                itemNumberHerramienta = listado[0].ItemNumber;
                nombreHerramienta = listado[0].Herramienta.ToUpper();
            }
            
            var FechaHoy = DateTime.Now;
            string strYear = FechaHoy.ToString("yyyy");
            string strMes = FechaHoy.ToString("MM");
            string strDia = FechaHoy.ToString("dd");
            serialHerramienta = Regex.Replace(serialHerramienta, @"\t|\n|\r", "");
            string NombreArchivo = "ReporteHerramienta_" + serialHerramienta + "_" + strYear + strMes + strDia + ".xlsx";
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
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Reporte");
                worksheet.Column(1).Width = 70.78;
                worksheet.Column(2).Width = 12.78;
                worksheet.Column(3).Width = 12.78;
                worksheet.Column(4).Width = 16.78;
                worksheet.Cells[1, 1].Value = "FAMILIA";
                worksheet.Cells[2, 1].Value = familiaHerramienta;
                worksheet.Cells[3, 1].Value = "HERRAMIENTA";
                worksheet.Cells[4, 1].Value = nombreHerramienta;
                worksheet.Cells[5, 1].Value = "SERIAL";
                worksheet.Cells[6, 1].Value = serialHerramienta;
                worksheet.Cells[7, 1].Value = "ITEM NUMBER";
                worksheet.Cells[8, 1].Value = itemNumberHerramienta;
                worksheet.Cells[1, 1, 9, 4].Style.Font.Bold = true;
                worksheet.Cells[1, 1, 9, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, 1, 9, 4].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                for (int i = 1; i < 9; i++)
                {
                    worksheet.Cells[i, 1, i, 4].Merge = true;
                    worksheet.Cells[i, 1, i, 4].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    if (i % 2 == 0) continue;
                    worksheet.Cells[i, 1, i, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[i, 1, i, 4].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                }
                worksheet.Cells["A9:D9"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells["A9:D9"].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);
                worksheet.Cells["A9"].Value = "CONTROL";
                worksheet.Cells["B9"].Value = "FECHA INSP.";
                worksheet.Cells["C9"].Value = "VENCIMIENTO";
                worksheet.Cells["D9"].Value = "APLICA CONTROL";
                worksheet.Cells["A9"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["B9"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["C9"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["D9"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                int ffila = 9;
                foreach (var item in listado)
                {
                    ffila++;
                    worksheet.Cells[ffila, 1].Value = item.Control?.ToUpper();
                    worksheet.Cells[ffila, 2].Value = item.FechaInspeccion;
                    worksheet.Cells[ffila, 2].Style.Numberformat.Format = "dd-mmm-yyyy";
                    worksheet.Cells[ffila, 3].Value = item.ProximaInspecion;
                    worksheet.Cells[ffila, 4].Value = "SI"; // Proximamente Aplica control;
                    worksheet.Cells[ffila, 3].Style.Numberformat.Format = "dd-mmm-yyyy";
                    worksheet.Cells[ffila, 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[ffila, 2].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[ffila, 3].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[ffila, 4].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[ffila, 1, ffila, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    switch (item.Estado)
                    {
                        case 1:
                            worksheet.Cells[ffila, 1, ffila, 4].Style.Fill.BackgroundColor.SetColor(255, 0, 255, 0);
                            worksheet.Cells[ffila, 4].Value = "OPERATIVO";
                            break;
                        case 2:
                            worksheet.Cells[ffila, 1, ffila, 4].Style.Fill.BackgroundColor.SetColor(255, 255, 192, 0);
                            worksheet.Cells[ffila, 4].Value = "POR VENCER";
                            break;
                        case 3:
                            worksheet.Cells[ffila, 1, ffila, 4].Style.Fill.BackgroundColor.SetColor(255, 255, 0, 0);
                            worksheet.Cells[ffila, 4].Value = "VENCIDO";
                            break;
                        default:
                            break;
                    }
                }
                /*
                ifila++;
                for (int i = 1; i <= 4; i++)
                {
                    worksheet.Cells[ifila, i, ffila, i].Merge = true;
                    worksheet.Cells[ifila, i, ffila, i].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }*/
                package.Save();
            }
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return Json(new { fileName= NombreArchivo, type = contentType, ruta = Directorio });
        }


        #endregion
    }
}