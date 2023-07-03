using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Coldairarrow.Business.Mantenimiento
{
    public class Wtf_UsuarioUbicacionesTipoHerramientaBusiness : BaseBusiness<Wtf_UsuarioUbicacionesTipoHerramienta>
    {
        #region 外部接口

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public List<Wtf_UsuarioUbicacionesTipoHerramienta> GetDataList(string condition, string keyword, Pagination pagination)
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
        public Wtf_UsuarioUbicacionesTipoHerramienta GetTheData(string id)
        {
            return GetEntity(id);
        }

        /// <summary>
        /// AGREGAR DATOS添加数据
        /// </summary>
        /// <param name="newData">数据</param>
        public void AddData(Wtf_UsuarioUbicacionesTipoHerramienta newData)
        {
            Insert(newData);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData(Wtf_UsuarioUbicacionesTipoHerramienta theData)
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


        public IQueryable<Wtf_UsuarioUbicacionesTipoHerramienta> ObtenerTipoHerramientasUbicacionUsuario(int IdUbicacion, int IdTipoHerramienta, string IdUsuario)
        {
            var q = GetIQueryable();
            var retorno = q.Where(t => t.IdTipoHerramienta == IdTipoHerramienta && t.IdUbicacion == IdUbicacion && t.IdUsuario == IdUsuario).Select(c => new Wtf_UsuarioUbicacionesTipoHerramienta {
                EsAdmin = c.EsAdmin,
                EsOper = c.EsOper
            });
            return retorno;
        }

        public void EstblecerUsuarioUbicacionTipoHerramienta(string IdUsuario, int IdUbicacion, List<Wtf_TipoHerramienta> toolTypesId)
        {
            Service.Delete<Wtf_UsuarioUbicacionesTipoHerramienta>(x => x.IdUsuario == IdUsuario && x.IdUbicacion == IdUbicacion);
            var insertList = toolTypesId.Select(x => new Wtf_UsuarioUbicacionesTipoHerramienta
            {
                Id = GuidHelper.GenerateNewId(),
                IdUbicacion = IdUbicacion,
                IdUsuario= IdUsuario,
                IdTipoHerramienta = x.Id,
                EsAdmin = x.EsAdmin,
                EsOper = x.EsOper
            }).ToList();
            Service.Insert(insertList);
        }
    }
}