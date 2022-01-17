using Coldairarrow.Business.Ganaderia;
using Coldairarrow.Entity.Ganaderia;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;
using System;
using Coldairarrow.Business.Common;
using System.IO;

namespace Coldairarrow.Web
{
    [Area("Ganaderia")]
    public class Gnd_InventarioController : BaseMvcController
    {
        Gnd_InventarioBusiness _gnd_InventarioBusiness = new Gnd_InventarioBusiness();

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Gnd_Inventario() : _gnd_InventarioBusiness.GetTheData(id);

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
            var dataList = _gnd_InventarioBusiness.GetDataList(condition, keyword, pagination);

            return Content(pagination.BuildTableResult_DataGrid(dataList).ToJson());
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Gnd_Inventario theData)
        {
            string imagenUrl = ConfigHelper.GetValue("UploadUrl");
            if(!String.IsNullOrEmpty(theData.ImagenBase64)) theData.ImagenUrl = imagenUrl + theData.ImagenNombre;
            if (!(theData.Id > 0))
            {
                theData.IdUsuario = Operator.UserId;
                theData.IdEstado = 1;
                _gnd_InventarioBusiness.AddData(theData);
            }
            else
            {
                _gnd_InventarioBusiness.UpdateData(theData);
            }
            UploadFile(theData.ImagenBase64, theData.ImagenNombre, imagenUrl);
            return Success();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            _gnd_InventarioBusiness.DeleteData(ids.ToList<string>());

            return Success("删除成功！");
        }

        public void UploadFile(string fileBase64, string fileName, string folder)
        {
            try
            {
                if (String.IsNullOrEmpty(fileBase64))
                    return;
                byte[] bytes = fileBase64.ToBytes_FromBase64Str();
                string fileDir = Path.Combine(GlobalSwitch.WebRootPath, "Upload", "File");
                if (!Directory.Exists(fileDir))
                    Directory.CreateDirectory(fileDir);
                string filePath = Path.Combine(fileDir, fileName);
                string fullPath = Path.GetFullPath(filePath);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (MemoryStream m = new MemoryStream(bytes))
                    {
                        m.WriteTo(fileStream);
                    }
                }
            }
            catch (Exception ex) {
            }
        }


        #endregion
    }
}