using Coldairarrow.Business.Base_SysManage;
using Coldairarrow.Business.Mantenimiento;
using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coldairarrow.Web
{
    [Area("Mantenimiento")]
    public class Wtf_UbicacionesController : BaseMvcController
    {
        Wtf_UbicacionesBusiness _wtf_UbicacionesBusiness = new Wtf_UbicacionesBusiness();
        Wtf_UserUbicacionMapBusiness _wtf_UserUbicacionMapBusiness = new Wtf_UserUbicacionMapBusiness();
        Base_UserBusiness _base_UserBusiness = new Base_UserBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Wtf_Ubicaciones() : _wtf_UbicacionesBusiness.GetTheData(id);

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
            var dataList = _wtf_UbicacionesBusiness.GetDataList(condition, keyword, pagination);

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

            var oUsuario = Base_UserBusiness.GetCurrentUser();

            var dataList = _wtf_UbicacionesBusiness.GetDataList(null, null, pagination);
            if (!oUsuario.EsRoot)
            {
                var BasesUsuario = _wtf_UserUbicacionMapBusiness.GetUserUbicaciones(oUsuario.UserId);
                IEnumerable<Wtf_Ubicaciones> oLista = dataList.Where(obase => BasesUsuario.Any(Id => Id.Equals(obase.Id)));
                dataList = oLista.ToList();
            }

            return Content(dataList.ToJson());
        }

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Wtf_Ubicaciones theData)
        {
            if (!(theData.Id > 0))
            {
                //theData.Id = Guid.NewGuid().ToSequentialGuid();

                _wtf_UbicacionesBusiness.AddData(theData);
            }
            else
            {
                _wtf_UbicacionesBusiness.UpdateData(theData);
            }

            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _wtf_UbicacionesBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        #endregion
    }
}