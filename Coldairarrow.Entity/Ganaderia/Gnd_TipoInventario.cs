using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Ganaderia
{
    /// <summary>
    /// Gnd_TipoInventario
    /// </summary>
    [Table("Gnd_TipoInventario")]
    public class Gnd_TipoInventario
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// Min
        /// </summary>
        public Int32 Min { get; set; }

        /// <summary>
        /// Max
        /// </summary>
        public Int32? Max { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public String Descripcion { get; set; }

        /// <summary>
        /// Min
        /// </summary>
        public Int32 IdSexo { get; set; }

    }
}