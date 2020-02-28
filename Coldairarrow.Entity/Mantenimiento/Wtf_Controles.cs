using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_Controles
    /// </summary>
    [Table("Wtf_Controles")]
    public class Wtf_Controles
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        public String Nombre { get; set; }

        /// <summary>
        /// Periodicidad
        /// </summary>
        public Int32 Periodicidad { get; set; }

        /// <summary>
        /// Preaviso
        /// </summary>
        public Int32 Preaviso { get; set; }

        [NotMapped]
        public bool selected { get; set; } = false;

    }
}