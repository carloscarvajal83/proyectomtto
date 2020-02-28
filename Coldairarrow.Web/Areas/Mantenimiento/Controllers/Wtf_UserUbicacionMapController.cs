using Coldairarrow.Business.Mantenimiento;
using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_UserUbicacionMapController : BaseMvcController
    {
        Wtf_UserUbicacionMapBusiness _wtf_UserUbicacionMapBusiness = new Wtf_UserUbicacionMapBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Wtf_UserUbicacionMap() : _wtf_UserUbicacionMapBusiness.GetTheData(id);

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
            var dataList = _wtf_UserUbicacionMapBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Wtf_UserUbicacionMap theData)
        {
            if (!(theData.Id > 0))
            {
                //theData.Id = Guid.NewGuid().ToSequentialGuid();

                _wtf_UserUbicacionMapBusiness.AddData(theData);
            }
            else
            {
                _wtf_UserUbicacionMapBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _wtf_UserUbicacionMapBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}