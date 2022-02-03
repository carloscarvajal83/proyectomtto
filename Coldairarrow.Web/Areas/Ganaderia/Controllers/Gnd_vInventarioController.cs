using Coldairarrow.Business.Ganaderia;
using Coldairarrow.Entity.Ganaderia;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coldairarrow.Web
{
    [Area("Ganaderia")]
    public class Gnd_vInventarioController : BaseMvcController
    {
        Gnd_vInventarioBusiness _gnd_vInventarioBusiness = new Gnd_vInventarioBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Gnd_vInventario() : _gnd_vInventarioBusiness.GetTheData(id);

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
            var dataList = _gnd_vInventarioBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        public ActionResult GetParentsDataList_NoPagin()
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue,
                SortField = "Codigo"
            };
            var dataList = _gnd_vInventarioBusiness.GetParentDataList(null, null, pagination);

            return Content(dataList.ToJson());
        }

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Gnd_vInventario theData)
        {
            if(theData.Id.IsNullOrEmpty())
            {
                _gnd_vInventarioBusiness.AddData(theData);
            }
            else
            {
                _gnd_vInventarioBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _gnd_vInventarioBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        public ActionResult VerReporte(Gnd_Propietario theData)
        {
            return Json(new { success = true, fileName = "" });
        }

        #endregion
    }
}