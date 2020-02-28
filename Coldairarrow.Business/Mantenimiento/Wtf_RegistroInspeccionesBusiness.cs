using Coldairarrow.Entity.Mantenimiento;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Coldairarrow.Business.Mantenimiento
{
    public class Wtf_RegistroInspeccionesBusiness : BaseBusiness<Wtf_RegistroInspecciones>
    {
        #region 外部接口

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public List<Wtf_RegistroInspecciones> GetDataList(string condition, string keyword, Pagination pagination)
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
        public Wtf_RegistroInspecciones GetTheData(string id)
        {
            return GetEntity(id);
        }

        /// <summary>
        /// AGREGAR DATOS添加数据
        /// </summary>
        /// <param name="newData">数据</param>
        public void AddData(Wtf_RegistroInspecciones newData)
        {
            Insert(newData);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        public void UpdateData(Wtf_RegistroInspecciones theData)
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

        public void DeleteData(Wtf_RegistroInspecciones entidad)
        {
            //var e = GetEntity(id);
            Delete(entidad);
        }

        public Wtf_RegistroInspecciones ObtenerRegistro(int id)
        {
            var retorno = GetEntity(id);
            return retorno;
           
        }

        #region 私有成员

        #endregion

        #region 数据模型

        #endregion

        public void ActualizarInspeccionActiva(int IdHerramienta)
        {
            var q = from c in GetIQueryable()
                    where c.IdHerramienta == IdHerramienta
                    orderby c.IdControl ascending
                    select c;
            List<int> IdCtrl = new List<int>();

            foreach (var s in q.ToList())
            {
                if (!IdCtrl.Contains(s.IdControl)) IdCtrl.Add(s.IdControl);
            }
            List<Wtf_RegistroInspecciones> registros = new List<Wtf_RegistroInspecciones>();
            foreach (var IdControl in IdCtrl)
            {
                Wtf_RegistroInspecciones registroActivo = null;
                foreach (var x in q.ToList())
                {
                    if (x.IdControl != IdControl) continue;
                    if (registroActivo.IsNullOrEmpty()) registroActivo = x;
                    x.Activo = false;
                    if (x.FechaInspeccion > registroActivo.FechaInspeccion) registroActivo = x;
                    registros.Add(x);
                }
                if (registros.Exists(c => c.Id == registroActivo.Id))
                {
                    var s = registros.Find(c => c.Id == registroActivo.Id);
                    s.Activo = true;
                }
            }
            if (registros.Count() > 0)
            {
                Service.Update(registros);
            }
        }

        public List<Wtf_RegistroInspecciones> ListaInspeccionesHerramienta(int IdHerramienta, Pagination pagination)
        {
            var q = from r in GetIQueryable()
                    join h in Service.GetIQueryable<Wtf_Herramientas>() on r.IdHerramienta equals h.Id
                    join c in Service.GetIQueryable<Wtf_Controles>() on r.IdControl equals c.Id
                    where r.IdHerramienta == IdHerramienta
                    select new Wtf_RegistroInspecciones {
                        Id = r.Id,
                        IdHerramienta = r.IdHerramienta,
                        IdTipoHerramienta = h.IdTipoHerramienta,
                        Herramienta = h.Descripcion,
                        IdControl = r.IdControl,
                        FechaInspeccion = r.FechaInspeccion,
                        CodigoWO = r.CodigoWO,
                        Activo = r.Activo,
                        Control = c.Nombre
                    };
            q = q.OrderBy(r => r.IdControl).ThenByDescending(r => r.FechaInspeccion);
            return q.ToList();
        }
    }
}