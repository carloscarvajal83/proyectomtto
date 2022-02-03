using Coldairarrow.Business.Common;
using Coldairarrow.Business.Ganaderia;
using Coldairarrow.Entity.Ganaderia;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coldairarrow.Web
{
    [Area("Ganaderia")]
    public class Gnd_PropietarioController : BaseMvcController
    {
        Gnd_PropietarioBusiness _gnd_PropietarioBusiness = new Gnd_PropietarioBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Gnd_Propietario() : _gnd_PropietarioBusiness.GetTheData(id);

            return View(theData);
        }

        public ActionResult FormOwnerReport(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Gnd_Propietario() : _gnd_PropietarioBusiness.GetTheData(id);

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
            var dataList = _gnd_PropietarioBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        public ActionResult GetDataList_NoPagin()
        {
            Pagination pagination = new Pagination
            {
                PageIndex = 1,
                PageRows = int.MaxValue
            };
            var dataList = _gnd_PropietarioBusiness.GetDataList(null, null, pagination);

            return Content(dataList.ToJson());
        }

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Gnd_Propietario theData)
        {
            if(!(theData.Id>0))
            {
                theData.IdUsuario = Operator.Id;
                _gnd_PropietarioBusiness.AddData(theData);
            }
            else
            {
                _gnd_PropietarioBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _gnd_PropietarioBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}