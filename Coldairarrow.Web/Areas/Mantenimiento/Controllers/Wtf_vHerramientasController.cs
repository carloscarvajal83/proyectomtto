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
    public class Wtf_vHerramientasController : BaseMvcController
    {
        Wtf_vHerramientasBusiness _wtf_vHerramientasBusiness = new Wtf_vHerramientasBusiness();
        Wtf_UserUbicacionMapBusiness _wtf_UserUbicacionMapBusiness = new Wtf_UserUbicacionMapBusiness();

        #region 获取数据

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(string condition, string keyword, Pagination pagination)
        {
            var dataList = _wtf_vHerramientasBusiness.GetDataList(condition, keyword, pagination);

            var oUsuario = Base_UserBusiness.GetCurrentUser();
            if (!oUsuario.EsRoot)
            {
                var BasesUsuario = _wtf_UserUbicacionMapBusiness.GetUserUbicaciones(oUsuario.UserId);
                IEnumerable<Wtf_vHerramientas> oLista = dataList.Where(oHerramienta => BasesUsuario.Any(Id => Id.Equals(oHerramienta.IdUbicacion)));
                dataList = oLista.ToList();
            }

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion
    }
}