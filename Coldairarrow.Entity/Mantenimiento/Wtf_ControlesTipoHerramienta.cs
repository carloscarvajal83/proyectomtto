using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_ControlesTipoHerramienta
    /// </summary>
    [Table("Wtf_ControlesTipoHerramienta")]
    public class Wtf_ControlesTipoHerramienta
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
        /// IdControl
        /// </summary>
        public Int32 IdControl { get; set; }

    }
}