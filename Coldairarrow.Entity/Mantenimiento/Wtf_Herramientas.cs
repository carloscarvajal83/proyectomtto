using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_Herramientas
    /// </summary>
    [Table("Wtf_Herramientas")]
    public class Wtf_Herramientas
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// IdTipoHerramienta
        /// </summary>
        public Int32 IdTipoHerramienta { get; set; }

        /// <summary>
        /// IdClaseHerramienta
        /// </summary>
        public Int32 IdClaseHerramienta { get; set; }

        /// <summary>
        /// IdUbicacion
        /// </summary>
        public Int32 IdUbicacion { get; set; }

        /// <summary>
        /// Serial
        /// </summary>
        public String Serial { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public String Descripcion { get; set; }

        /// <summary>
        /// CodigoActivo
        /// </summary>
        public Int32 CodigoActivo { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public Int32 Estado { get; set; }

        /// <summary>
        /// FechaAdquisicion
        /// </summary>
        public DateTime? FechaAdquisicion { get; set; }

        public string EstadoNoOperativo { get; set; }

    }
}