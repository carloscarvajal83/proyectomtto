using Coldairarrow.Business.Mantenimiento;
using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_RegistroInspeccionesController : BaseMvcController
    {
        Wtf_RegistroInspeccionesBusiness _wtf_RegistroInspeccionesBusiness = new Wtf_RegistroInspeccionesBusiness();
        Wtf_HerramientasBusiness _wtf_HerramientasBusiness = new Wtf_HerramientasBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id, string IdHerramienta)
        {
            var theData = id.IsNullOrEmpty() ? new Wtf_RegistroInspecciones() : _wtf_RegistroInspeccionesBusiness.GetTheData(id);
            theData.IdHerramienta = int.Parse(IdHerramienta);
            Wtf_Herramientas xobj = _wtf_HerramientasBusiness.GetTheData(IdHerramienta);
            theData.IdTipoHerramienta = xobj.IdTipoHerramienta;
            theData.Herramienta = xobj.Descripcion;
            return View(theData);
        }

        #endregion

        #region 获取数据

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(string condition, string keyword, Pagination pagination)
        {
            var dataList = _wtf_RegistroInspeccionesBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        public ActionResult GetDataList_NoPagin(int IdHerramienta)
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var dataList = _wtf_RegistroInspeccionesBusiness.ListaInspeccionesHerramienta(IdHerramienta, pagination);

            return Content(dataList.ToJson());
        }

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Wtf_RegistroInspecciones theData)
        {
            if (!(theData.Id > 0))
            {
                //theData.Id = Guid.NewGuid().ToSequentialGuid();

                _wtf_RegistroInspeccionesBusiness.AddData(theData);
            }
            else
            {
                _wtf_RegistroInspeccionesBusiness.UpdateData(theData);
            }
            _wtf_RegistroInspeccionesBusiness.ActualizarInspeccionActiva(theData.IdHerramienta);
            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(int id)
        {
            var registro = _wtf_RegistroInspeccionesBusiness.ObtenerRegistro(id);
            int IdHerramienta = registro.IdHerramienta;
            _wtf_RegistroInspeccionesBusiness.DeleteData(registro);
            _wtf_RegistroInspeccionesBusiness.ActualizarInspeccionActiva(IdHerramienta);
            return Success("删除成功！");
        }

        #endregion
    }
}