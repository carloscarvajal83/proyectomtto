using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Coldairarrow.Business.Mantenimiento
{
    public class Wtf_ControlesTipoHerramientaBusiness : BaseBusiness<Wtf_ControlesTipoHerramienta>
    {
        #region 外部接口

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public List<Wtf_ControlesTipoHerramienta> GetDataList(string condition, string keyword, Pagination pagination)
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
        public Wtf_ControlesTipoHerramienta GetTheData(string id)
        {
            return GetEntity(id);
        }

        /// <summary>
        /// AGREGAR DATOS添加数据
        /// </summary>
        /// <param name="newData">数据</param>
        public void AddData(Wtf_ControlesTipoHerramienta newData)
        {
            Insert(newData);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData(Wtf_ControlesTipoHerramienta theData)
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

        public List<int> ObtenerControlesTipoHerramientas(int IdTipoHerramienta)
        {
            var q = GetIQueryable();
            var retorno = q.Where(t => t.IdTipoHerramienta == IdTipoHerramienta).Select(c=> c.IdControl);
            return retorno.ToList();
        }

        public int ObtenerControlesTipoHerramientas(int IdTipoHerramienta, int IdControl)
        {
            var q = GetIQueryable();
            var retorno = q.Where(t => t.IdTipoHerramienta == IdTipoHerramienta && t.IdControl == IdControl).Select(c => c.IdControl);
            return retorno.Count();
        }
    }
}