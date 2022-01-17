using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Ganaderia
{
    /// <summary>
    /// Gnd_Finca
    /// </summary>
    [Table("Gnd_Finca")]
    public class Gnd_Finca
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public String Descripcion { get; set; }

        /// <summary>
        /// IdUsuario
        /// </summary>
        public String IdUsuario { get; set; }

    }
}