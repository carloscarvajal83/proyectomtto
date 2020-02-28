using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Coldairarrow.Business.Mantenimiento
{
    public class Wtf_TipoHerramientaBusiness : BaseBusiness<Wtf_TipoHerramienta>
    {
        #region 外部接口

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public List<Wtf_TipoHerramienta> GetDataList(string condition, string keyword, Pagination pagination)
        {
            var q = GetIQueryable();

            //模糊查询
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        /// <summary>
        /// 获取指定的单条数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public Wtf_TipoHerramienta GetTheData(string id)
        {
            return GetEntity(id);
        }

        /// <summary>
        /// AGREGAR DATOS添加数据
        /// </summary>
        /// <param name="newData">数据</param>
        public void AddData(Wtf_TipoHerramienta newData)
        {
            Insert(newData);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData(Wtf_TipoHerramienta theData)
        {
            Update(theData);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public void DeleteData(List<string> ids)
        {
            Delete(ids);
        }

        #endregion

        #region 私有成员

        #endregion

        #region 数据模型

        #endregion

        public static List<int> GetControlIds(int IdTipoHerramienta)
        {
            var retorno = new Wtf_ControlesTipoHerramientaBusiness();
            return retorno.ObtenerControlesTipoHerramientas(IdTipoHerramienta);
        }

        public void EstblecerControlesTipoHerramienta(int IdTipoHerramienta, List<int> controlIds)
        {
            Service.Delete<Wtf_ControlesTipoHerramienta>(x => x.IdTipoHerramienta == IdTipoHerramienta);
            var insertList = controlIds.Select(x => new Wtf_ControlesTipoHerramienta
            {
                IdTipoHerramienta = IdTipoHerramienta,
                IdControl = x
            }).ToList();
            Service.Insert(insertList);
        }

        public bool validarItemNumberExiste(Wtf_TipoHerramienta theData, bool nuevo = true)
        {
            var q = GetIQueryable();
            int conteo = 0;
            if (nuevo)
            {
                conteo = q.Where(c => c.ItemNumber == theData.ItemNumber).Count();
            }
            else
            {
                conteo = q.Where(c => c.ItemNumber == theData.ItemNumber && c.Id != theData.Id).Count();
            }
            return conteo > 0;
        }
    }
}