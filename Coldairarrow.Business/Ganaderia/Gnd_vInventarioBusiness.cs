using Coldairarrow.Business.Common;
using Coldairarrow.Entity.Ganaderia;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Coldairarrow.Business.Ganaderia
{
    public class Gnd_vInventarioBusiness : BaseBusiness<Gnd_vInventario>
    {
        #region 外部接口

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public List<Gnd_vInventario> GetDataList(string condition, string keyword, Pagination pagination)
        {
            var q = GetIQueryable();

            //模糊查询
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty()) {
                int keyInt = 0;
                int.TryParse(keyword, out keyInt);
                if (keyInt > 0)
                {
                    q = q.Where($@"{condition}.Equals(@0)", keyword);
                }
                else {
                    q = q.Where($@"{condition}.Contains(@0)", keyword);
                }
            }
            q = q.Where(c => c.IdUsuario == Operator.Id);

            return q.GetPagination(pagination).ToList();
        }

        public List<Gnd_vInventario> GetParentDataList(string condition, string keyword, Pagination pagination)
        {
            var q = GetIQueryable();

            //模糊查询
            q = q.Where(c => c.Sexo == 2 && c.EsPadre && c.IdUsuario == Operator.Id);

            return q.GetPagination(pagination).ToList();
        }

        /// <summary>
        /// 获取指定的单条数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public Gnd_vInventario GetTheData(string id)
        {
            return GetEntity(id);
        }

        /// <summary>
        /// AGREGAR DATOS添加数据
        /// </summary>
        /// <param name="newData">数据</param>
        public void AddData(Gnd_vInventario newData)
        {
            Insert(newData);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData(Gnd_vInventario theData)
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
    }
}