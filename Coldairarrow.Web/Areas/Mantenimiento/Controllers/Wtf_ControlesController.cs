using Coldairarrow.Business.Mantenimiento;
using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_ControlesController : BaseMvcController
    {
        Wtf_ControlesBusiness _wtf_ControlesBusiness = new Wtf_ControlesBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Wtf_Controles() : _wtf_ControlesBusiness.GetTheData(id);

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
            var dataList = _wtf_ControlesBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        public ActionResult GetDataList_ByType(int IdTipoHerramienta = 0)
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var dataList = _wtf_ControlesBusiness.ListaControlesTipoHerramienta(IdTipoHerramienta, pagination);
            return Content((dataList).ToJson());
        }

        public ActionResult GetDataList_NoPagin(int IdTipoHerramienta = 0)
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var dataList = _wtf_ControlesBusiness.GetDataList(null, null, pagination);
            if (IdTipoHerramienta > 0)
            {
                //var controlIds = Wtf_HerramientasBusiness.GetControlIds(IdTipoHerramienta);
                foreach (var xdata in dataList)
                {
                    int IdControl = xdata.Id;
                    int conteo = new Wtf_ControlesTipoHerramientaBusiness().ObtenerControlesTipoHerramientas(IdTipoHerramienta, IdControl);
                    if (conteo > 0)
                    {
                        xdata.selected = true;
                    }
                }
            }
            return Content(dataList.ToJson());
        }

        #region 提交数据
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Wtf_Controles theData)
        {
            if (!(theData.Id > 0))
            {
                //theData.Id = Guid.NewGuid().ToSequentialGuid();

                _wtf_ControlesBusiness.AddData(theData);
            }
            else
            {
                _wtf_ControlesBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _wtf_ControlesBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}