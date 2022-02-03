using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Ganaderia
{
    /// <summary>
    /// Gnd_vInventario
    /// </summary>
    [Table("Gnd_vInventario")]
    public class Gnd_vInventario
    {

        /// <summary>
        /// Id
        /// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// IdPadre
        /// </summary>
        public Int32? IdPadre { get; set; }

        /// <summary>
        /// IdPropietario
        /// </summary>
        public Int32 IdPropietario { get; set; }

        /// <summary>
        /// IdFinca
        /// </summary>
        public Int32 IdFinca { get; set; }

        /// <summary>
        /// IdEstado
        /// </summary>
        public Int32 IdEstado { get; set; }

        /// <summary>
        /// IdTipoInventario
        /// </summary>
        public Int32 IdTipoInventario { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public String Descripcion { get; set; }

        /// <summary>
        /// FechaNacimiento
        /// </summary>
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Sexo
        /// </summary>
        public Int32 Sexo { get; set; }

        /// <summary>
        /// Produccion
        /// </summary>
        public Decimal Produccion { get; set; }

        /// <summary>
        /// IdUsuario
        /// </summary>
        public String IdUsuario { get; set; }

        /// <summary>
        /// ImagenUrl
        /// </summary>
        public String ImagenUrl { get; set; }

        /// <summary>
        /// ImagenNombre
        /// </summary>
        public String ImagenNombre { get; set; }

        /// <summary>
        /// EsPadre
        /// </summary>
        public Boolean EsPadre { get; set; }

        /// <summary>
        /// Propietario
        /// </summary>
        public String Propietario { get; set; }

        /// <summary>
        /// Finca
        /// </summary>
        public String Finca { get; set; }

        /// <summary>
        /// TipoInventario
        /// </summary>
        public String TipoInventario { get; set; }

        /// <summary>
        /// Padre
        /// </summary>
        public String Padre { get; set; }

        /// <summary>
        /// Codigo
        /// </summary>
        public Int32 Codigo { get; set; }

        /// <summary>
        /// Marcado
        /// </summary>
        public Boolean Marcado { get; set; }

        /// <summary>
        /// FechaVenta
        /// </summary>
        public DateTime? FechaVenta { get; set; }

        /// <summary>
        /// FechaDeceso
        /// </summary>
        public DateTime? FechaDeceso { get; set; }

        /// <summary>
        /// FechaCompra
        /// </summary>
        public DateTime? FechaCompra { get; set; }

        /// <summary>
        /// FechaPerdida
        /// </summary>
        public DateTime? FechaPerdida { get; set; }

        /// <summary>
        /// EsCompra
        /// </summary>
        public Boolean EsCompra { get; set; }

        /// <summary>
        /// DescripcionCodigo
        /// </summary>
        public String DescripcionCodigo { get; set; }

        /// <summary>
        /// DescripcionPadre
        /// </summary>
        public String DescripcionPadre { get; set; }

        /// <summary>
        /// CodigoBusqueda
        /// </summary>
        public String CodigoBusqueda { get; set; }

    }
}