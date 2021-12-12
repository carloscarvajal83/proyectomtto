using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_RegistroInspecciones
    /// </summary>
    [Table("Wtf_RegistroInspecciones")]
    public class Wtf_RegistroInspecciones
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// IdHerramienta
        /// </summary>
        public Int32 IdHerramienta { get; set; }

        /// <summary>
        /// IdControl
        /// </summary>
        public Int32 IdControl { get; set; }

        /// <summary>
        /// FechaInspeccion
        /// </summary>
        public DateTime? FechaInspeccion { get; set; }

        /// <summary>
        /// CodigoWO
        /// </summary>
        public String CodigoWO { get; set; }

        /// <summary>
        /// Activo
        /// </summary>
        public Boolean Activo { get; set; }

        [NotMapped]
        public Int32 IdTipoHerramienta { get; set; }

        [NotMapped]
        public String Herramienta { get; set; }

        [NotMapped]
        public String Control { get; set; }
    }
}