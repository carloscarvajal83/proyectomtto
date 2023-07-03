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
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Drawing;
using Coldairarrow.Business.Common;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_TipoHerramientaController : BaseMvcController
    {
        Wtf_TipoHerramientaBusiness _wtf_TipoHerramientaBusiness = new Wtf_TipoHerramientaBusiness();
        Wtf_vReporteControlesHerramientaBusiness _wtf_vReporteControlesHerramientaBusiness = new Wtf_vReporteControlesHerramientaBusiness();
        Wtf_UsuarioUbicacionesTipoHerramientaBusiness _wtf_UsuarioUbicacionesTipoHerramientaBusiness = new Wtf_UsuarioUbicacionesTipoHerramientaBusiness();

        private readonly IHostingEnvironment _env;

        public Wtf_TipoHerramientaController(IHostingEnvironment env)
        {
            _env = env;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Wtf_TipoHerramienta() : _wtf_TipoHerramientaBusiness.GetTheData(id);

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
            var dataList = _wtf_TipoHerramientaBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        /// <summary>
        /// »ñÈ¡½ÇÉ«ÁÐ±í
        /// ×¢£ºÎÞ·ÖÒ³
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDataList_NoPagin()
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var dataList = _wtf_TipoHerramientaBusiness.GetDataList(null, null, pagination);

            return Content(dataList.ToJson());
        }

        public List<Wtf_TipoHerramienta> GetDataListByUser_NoPaginList(int IdUbicacion, string IdUsuario) {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var dataList = _wtf_TipoHerramientaBusiness.GetDataList(null, null, pagination);
            if (IdUbicacion > 0)
            {
                foreach (var xdata in dataList)
                {
                    int IdTipo = xdata.Id;
                    var iMapping = _wtf_UsuarioUbicacionesTipoHerramientaBusiness.ObtenerTipoHerramientasUbicacionUsuario(IdUbicacion, IdTipo, IdUsuario);
                    if (iMapping.Count() > 0)
                    {
                        xdata.selected = true;
                        xdata.EsAdmin = iMapping.First().EsAdmin;
                        xdata.EsOper = iMapping.First().EsOper;
                    }
                }
            }
            return dataList;
        }

        public ActionResult GetDataListByUser_NoPagin(int IdUbicacion, string IdUsuario)
        {
            var dataList = GetDataListByUser_NoPaginList(IdUbicacion, IdUsuario);
            return Content(dataList.ToJson());
        }

        public ActionResult GetDataListByUserLocation_NoPagin(int IdUbicacion, string IdUsuario)
        {
            var dataList = GetDataListByUser_NoPaginList(IdUbicacion, IdUsuario);
            return Content(dataList.Where(x => x.selected == true).ToJson());
        }


        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Wtf_TipoHerramienta theData, string ControlIdList)
        {
            var controlIdList = ControlIdList.ToList<int>();
            if (!(theData.Id > 0)) {
                if (_wtf_TipoHerramientaBusiness.validarItemNumberExiste(theData)) {
                    return Error("Ya existe un Tipo de Herramienta con el Item Number " + theData.ItemNumber);
                } else {
                    _wtf_TipoHerramientaBusiness.AddData(theData);
                }
            } else {
                if (_wtf_TipoHerramientaBusiness.validarItemNumberExiste(theData, false)) {
                    return Error("Ya existe un Tipo de Herramienta con el Item Number " + theData.ItemNumber);
                } else {
                    _wtf_TipoHerramientaBusiness.UpdateData(theData);
                }
            }

            _wtf_TipoHerramientaBusiness.EstblecerControlesTipoHerramienta(theData.Id, controlIdList);

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _wtf_TipoHerramientaBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion

        public ActionResult VerReporte(int Id)
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var listado = _wtf_vReporteControlesHerramientaBusiness.GetDataListByType(Id, pagination);
            string Familia = "NO HAY HERRAMIENTAS ASOCIADAS A ESTA FAMILIA";
            string strItemNo = "000";
            if (listado.Count > 0)
            {
                Familia = listado[0].Familia;
                strItemNo = listado[0].ItemNumber;
            }

            //var listadoControles = listado.Select(x => x.Control).Distinct().ToList();
            //var listadoControles2 = listado.Select(x => x.IdControl).Distinct().ToList();
            //var listadoControles3 = listado.Select(c => new Icontrol { IdControl = c.IdControl, Control = c.Control });
            var listadoControles = listado.GroupBy(z => new { z.IdControl, z.Control }).Select(y => new Icontrol { IdControl = y.Key.IdControl, Control = y.Key.Control }).ToList();
            if (listadoControles.Count() > 0 && listadoControles[0].IdControl == 0)
            {
                listadoControles = new List<Icontrol>();
            }
            //Se almacena la columna incial cada control, para posicionarse en el excel
            //La clave es la columa asociada al Id del Control
            Dictionary<int, int> PosicionControles = new Dictionary<int, int>();
            //Se almacena la fila incial cada control, para posicionarse en el excel
            //La clave es el serial de la herramienta
            Dictionary<string, int> PosicionHerramientas = new Dictionary<string, int>();
            //Se almacenan los datos consolidados de cada control por estado
            //La clave es el Id del Control y la clave interna es el Id del Estado
            List<IConsolidado> Consolidado = new List<IConsolidado>();

            var FechaHoy = DateTime.Now;
            string strYear = FechaHoy.ToString("yyyy");
            string strMes = FechaHoy.ToString("MM");
            string strDia = FechaHoy.ToString("dd");
            string NombreArchivo = "ReporteFamiliaHerramienta_" + strItemNo + "_" + strYear + strMes + strDia + ".xlsx";
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
                worksheet.Row(1).Height = 25;
                worksheet.Cells[1, 1].Value = "REPORTE ESTADO FAMILIA HERRAMIENTAS";
                worksheet.Cells[2, 1].Value = "[" + strItemNo + "] " + Familia.ToUpper();
                worksheet.Cells[3, 1].Value = "NOMBRE";
                worksheet.Cells[3, 2].Value = "SERIAL";
                worksheet.Column(1).Width = 25;
                worksheet.Column(2).Width = 15;

                List<IEstado> iEstados = new List<IEstado>();
                iEstados.Add(new IEstado { IdEstado = 1, strEstado = "OK", iColor= Color.FromArgb(255, 0, 255, 0) });
                iEstados.Add(new IEstado { IdEstado = 2, strEstado = "ALERTA", iColor = Color.FromArgb(255, 255, 192, 0) });
                iEstados.Add(new IEstado { IdEstado = 3, strEstado = "VENCIDA", iColor = Color.FromArgb(255, 255, 0, 0) });
                // Fila inicio Controles
                int irow = 3;
                // Columna Inicio controles
                int icol = 1;
                foreach (var icontrol1 in listadoControles)
                {
                    icol = icol + 2;
                    worksheet.Cells[irow, icol].Value = icontrol1.Control.ToUpper();
                    worksheet.Cells[irow + 1, icol].Value = "FECHA INICIAL";
                    worksheet.Cells[irow + 1, icol].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[irow + 1, icol + 1].Value = "FECHA FINAL";
                    worksheet.Cells[irow + 1, icol + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    PosicionControles.Add(icontrol1.IdControl, icol);

                    worksheet.Column(icol).Width = 24;
                    worksheet.Column(icol + 1).Width = 24;
                    worksheet.Cells[irow, icol, irow, icol + 1].Merge = true;
                    worksheet.Cells[irow, icol, irow, icol + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                }

                if (listadoControles.Count() > 0)
                {
                    worksheet.Cells[1, 1, 1, icol + 1].Merge = true;
                    worksheet.Cells[2, 1, 2, icol + 1].Merge = true;
                }
                worksheet.Cells[irow, 1, irow + 1, 1].Merge = true;
                worksheet.Cells[1, 1, irow, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, 1, irow, 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                worksheet.Cells[irow, 2, irow + 1, 2].Merge = true;
                worksheet.Cells[2, 2, irow, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[2, 2, irow, 2].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                //Rellena Encabezado Serial
                worksheet.Cells["A3:A4"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                worksheet.Cells["B3:B4"].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                //Centra toda
                worksheet.Cells[irow, 1, irow + 1, icol + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[irow, 1, irow + 1, icol + 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                worksheet.Cells[1, 1, irow + 1, icol + 1].Style.Font.Bold = true;
                worksheet.Cells[3, 1, 4, icol + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[3, 1, 4, icol + 1].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                irow = irow + 2;
                int wrow = irow;
                foreach (var itool in listado)
                {
                    if (PosicionHerramientas.Count(x => x.Key == itool.Serial) == 0)
                    {
                        wrow = irow;
                        PosicionHerramientas.Add(itool.Serial, irow);
                        worksheet.Cells[wrow, 1].Value = itool.Herramienta.ToUpper();
                        worksheet.Cells[wrow, 2].Value = itool.Serial.ToUpper();
                        irow++;
                    }
                    else {
                        wrow = PosicionHerramientas[itool.Serial];
                    }

                    if (listadoControles.Count() > 0)
                    {
                        int wcol = PosicionControles[itool.IdControl];
                        worksheet.Cells[wrow, wcol].Value = itool.FechaInspeccion;
                        worksheet.Cells[wrow, wcol].Style.Numberformat.Format = "dd-mmm-yyyy";
                        worksheet.Cells[wrow, wcol + 1].Value = itool.ProximaInspecion;
                        worksheet.Cells[wrow, wcol + 1].Style.Numberformat.Format = "dd-mmm-yyyy";
                        worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;

                        bool _existe = false;
                        if (Consolidado.Count(x => x.IdEstado == itool.Estado && x.IdControl == itool.IdControl) > 0)
                        {
                            _existe = true;
                        }
                        if (!_existe)
                        {
                            var innerDic = new IConsolidado
                            {
                                IdEstado = itool.Estado,
                                IdControl = itool.IdControl,
                                vControl = new Icontrol
                                {
                                    IdControl = itool.IdControl,
                                    Control = itool.Control,
                                    StatusQty = 0,
                                    StatusPct = 0
                                }
                            };
                            Consolidado.Add(innerDic);
                        }


                        var registroEstadistica = Consolidado.First(x => x.IdControl == itool.IdControl && x.IdEstado == itool.Estado).vControl;

                        switch (itool.Estado)
                        {
                            // Estado Vigente
                            case 1:
                                worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.BackgroundColor.SetColor(255, 0, 255, 0);
                                registroEstadistica.StatusQty++;
                                break;
                            // Estado Alerta
                            case 2:
                                worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.BackgroundColor.SetColor(255, 255, 192, 0);
                                registroEstadistica.StatusQty++;
                                break;
                            // Estado Vencido
                            case 3:
                                worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.BackgroundColor.SetColor(255, 255, 0, 0);
                                registroEstadistica.StatusQty++;
                                break;
                            default:
                                break;
                        }
                    }
                }

                foreach (IEstado iestado in iEstados)
                {
                    foreach (var item in listadoControles)
                    {
                        bool _existe = false;
                        if (Consolidado.Count(x => x.IdEstado == iestado.IdEstado && x.IdControl == item.IdControl) > 0) _existe = true;
                        if (!_existe)
                        {
                            var innerDic = new IConsolidado
                            {
                                IdEstado = iestado.IdEstado,
                                IdControl = item.IdControl,
                                vControl = new Icontrol
                                {
                                    IdControl = item.IdControl,
                                    Control = item.Control,
                                    StatusQty = 0,
                                    StatusPct = 0
                                }
                            };
                            Consolidado.Add(innerDic);
                        }
                    }
                }

                foreach (var itool in listado)
                {
                    foreach (var item in Consolidado)
                    {
                        if (item.IdControl == itool.IdControl)
                        {
                            item.vControl.TotalControl++;
                        }
                    }
                }


                if (!(listadoControles.Count() > 0))
                {
                    worksheet.Cells[1, 1, 1, 7].Merge = true;
                    worksheet.Cells[2, 1, 2, 7].Merge = true;
                }

                irow++;
                wrow = irow;

                worksheet.Cells[wrow + 1, 1].Value = "OK";
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Merge = true;
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[wrow + 1, 1].Style.Font.Bold = true;
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                worksheet.Cells[wrow + 2, 1].Value = "ALERTA";
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Merge = true;
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[wrow + 2, 1].Style.Font.Bold = true;
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                worksheet.Cells[wrow + 3, 1].Value = "VENCIDA";
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Merge = true;
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[wrow + 3, 1].Style.Font.Bold = true;
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                foreach (var icontrol in listadoControles)
                {
                    int wcol = PosicionControles[icontrol.IdControl];
                    worksheet.Cells[wrow, wcol].Value = icontrol.Control.ToUpper();
                    worksheet.Cells[wrow, wcol].Style.Font.Bold = true;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Merge = true;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                foreach (var item in Consolidado)
                {
                    int wcol = PosicionControles[item.IdControl];
                    // Se Aprovecha el hecho que los estados son 1, 2, y 3
                    worksheet.Cells[wrow + item.IdEstado, wcol].Value = item.vControl.StatusQty;
                    worksheet.Cells[wrow + item.IdEstado, wcol, wrow + item.IdEstado, wcol + 1].Merge = true;
                    worksheet.Cells[wrow + item.IdEstado, wcol, wrow + item.IdEstado, wcol + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[wrow + item.IdEstado, wcol, wrow + item.IdEstado, wcol + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                wrow = wrow + 5;

                worksheet.Cells[wrow + 1, 1].Value = "OK";
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Merge = true;
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[wrow + 1, 1].Style.Font.Bold = true;
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[wrow + 1, 1, wrow + 1, 2].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                worksheet.Cells[wrow + 2, 1].Value = "ALERTA";
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Merge = true;
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[wrow + 2, 1].Style.Font.Bold = true;
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[wrow + 2, 1, wrow + 2, 2].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                worksheet.Cells[wrow + 3, 1].Value = "VENCIDA";
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Merge = true;
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                worksheet.Cells[wrow + 3, 1].Style.Font.Bold = true;
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells[wrow + 3, 1, wrow + 3, 2].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);

                foreach (var icontrol in listadoControles)
                {
                    int wcol = PosicionControles[icontrol.IdControl];
                    worksheet.Cells[wrow, wcol].Value = icontrol.Control.ToUpper();
                    worksheet.Cells[wrow, wcol].Style.Font.Bold = true;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Merge = true;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Fill.BackgroundColor.SetColor(255, 191, 191, 191);
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[wrow, wcol, wrow, wcol + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                foreach (var item in Consolidado)
                {
                    int wcol = PosicionControles[item.IdControl];
                    // Se Aprovecha el hecho que los estados son 1, 2, y 3
                    worksheet.Cells[wrow + item.IdEstado, wcol].Value = (float)item.vControl.StatusPct/100.0;
                    worksheet.Cells[wrow + item.IdEstado, wcol].Style.Numberformat.Format = "0%";
                    worksheet.Cells[wrow + item.IdEstado, wcol, wrow + item.IdEstado, wcol + 1].Merge = true;
                    worksheet.Cells[wrow + item.IdEstado, wcol, wrow + item.IdEstado, wcol + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[wrow + item.IdEstado, wcol, wrow + item.IdEstado, wcol + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                }

                
                if (listadoControles.Count() > 0)
                {
                    ExcelBarChart lineChart = worksheet.Drawings.AddChart("lineChart", eChartType.ColumnClustered) as ExcelBarChart;
                    lineChart.Title.Text = "ESTADO " + Familia.ToUpper();

                    //Define el label de datos para cada rango de datos
                    ExcelRange rangeLabel = worksheet.Cells[wrow, 3, wrow, icol + 1];
                    var iserie = 1;
                    foreach (var icontrol in iEstados)
                    {
                        var range = worksheet.Cells[wrow + iserie, 3, wrow + iserie, icol + 1];
                        lineChart.Series.Add(range, rangeLabel);
                        lineChart.Series[iserie - 1].Header = worksheet.Cells[wrow + iserie, 1].Value.ToString();
                        lineChart.Series[iserie - 1].Fill.Style = eFillStyle.SolidFill;
                        lineChart.Series[iserie - 1].Fill.Color = icontrol.iColor;
                        iserie++;
                    }

                    lineChart.DataLabel.ShowValue = true;

                    lineChart.SetSize(2 * listadoControles.Count() * 180 + 120, 560);
                    lineChart.SetPosition(wrow + 5, 1, 1, 0);
                }

                package.Save();
            }

            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            return Json(new { fileName = NombreArchivo, type = contentType, ruta = Directorio });
        }
    }

    public class Icontrol
    {
        public int IdControl { get; set; }
        public string Control { get; set; }
        public int StatusQty { get; set; }
        public int StatusPct
        {
            get
            { if (TotalControl > 0) {
                    float pct = (float)StatusQty / (float)TotalControl;
                    pct = 100 * pct;
                    return (int)pct;
                }
                else { return 0; }
            }
            set { }
        }
        public int TotalControl { get; set; }
    }

    public class IConsolidado
    {
        public int IdEstado { get; set; }
        public int IdControl { get; set; }
        public Icontrol vControl { get; set; }
    }

    public class IEstado
    { 
        public int IdEstado { get; set; }
        public string strEstado { get; set; }
        public Color iColor { get; set; }
    }
}