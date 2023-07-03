using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_TipoHerramienta
    /// </summary>
    [Table("Wtf_TipoHerramienta")]
    public class Wtf_TipoHerramienta
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// ItemNumber
        /// </summary>
        public String ItemNumber { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public String Descripcion { get; set; }

        [NotMapped]
        public bool selected { get; set; } = false;

        [NotMapped]
        public bool EsAdmin { get; set; } = false;

        [NotMapped]
        public bool EsOper { get; set; } = false;
    }
}