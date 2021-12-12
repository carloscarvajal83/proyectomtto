using Coldairarrow.Business.Mantenimiento;
using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_ClaseHerramientaController : BaseMvcController
    {
        Wtf_ClaseHerramientaBusiness _wtf_ClaseHerramientaBusiness = new Wtf_ClaseHerramientaBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Wtf_ClaseHerramienta() : _wtf_ClaseHerramientaBusiness.GetTheData(id);

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
            var dataList = _wtf_ClaseHerramientaBusiness.GetDataList(condition, keyword, pagination);

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
            var dataList = _wtf_ClaseHerramientaBusiness.GetDataList(null, null, pagination);

            return Content(dataList.ToJson());
        }


        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Wtf_ClaseHerramienta theData)
        {
            if (!(theData.Id > 0))
            {
                ///theData.Id = Guid.NewGuid().ToSequentialGuid();

                _wtf_ClaseHerramientaBusiness.AddData(theData);
            }
            else
            {
                _wtf_ClaseHerramientaBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _wtf_ClaseHerramientaBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}