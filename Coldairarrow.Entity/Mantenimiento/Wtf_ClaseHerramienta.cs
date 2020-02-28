using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_ClaseHerramienta
    /// </summary>
    [Table("Wtf_ClaseHerramienta")]
    public class Wtf_ClaseHerramienta
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

    }
}