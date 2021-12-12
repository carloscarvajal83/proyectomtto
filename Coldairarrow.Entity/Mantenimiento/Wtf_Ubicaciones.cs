using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_Ubicaciones
    /// </summary>
    [Table("Wtf_Ubicaciones")]
    public class Wtf_Ubicaciones
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
        /// Codigo
        /// </summary>
        public String Codigo { get; set; }

    }
}