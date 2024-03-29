using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_vHerramientas
    /// </summary>
    [Table("Wtf_vHerramientas")]
    public class Wtf_vHerramientas
    {

        /// <summary>
        /// Id
        /// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// IdTipoHerramienta
        /// </summary>
        public Int32 IdTipoHerramienta { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public String Descripcion { get; set; }

        /// <summary>
        /// ItemNumber
        /// </summary>
        public String ItemNumber { get; set; }

        /// <summary>
        /// TipoHerramienta
        /// </summary>
        public String TipoHerramienta { get; set; }

        /// <summary>
        /// IdClaseHerramienta
        /// </summary>
        public Int32 IdClaseHerramienta { get; set; }

        /// <summary>
        /// ClaseHerramienta
        /// </summary>
        public String ClaseHerramienta { get; set; }

        /// <summary>
        /// IdUbicacion
        /// </summary>
        public Int32 IdUbicacion { get; set; }

        /// <summary>
        /// Ubicacion
        /// </summary>
        public String Ubicacion { get; set; }

        /// <summary>
        /// Serial
        /// </summary>
        public String Serial { get; set; }

        /// <summary>
        /// CodigoActivo
        /// </summary>
        public Int32? CodigoActivo { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public Int32 Estado { get; set; }

        /// <summary>
        /// FechaAdquisicion
        /// </summary>
        public DateTime? FechaAdquisicion { get; set; }

    }
}