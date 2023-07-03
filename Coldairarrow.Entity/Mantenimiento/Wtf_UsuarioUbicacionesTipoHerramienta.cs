using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_UsuarioUbicacionesTipoHerramienta
    /// </summary>
    [Table("Wtf_UsuarioUbicacionesTipoHerramienta")]
    public class Wtf_UsuarioUbicacionesTipoHerramienta
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public string Id { get; set; }

        /// <summary>
        /// IdUsuario
        /// </summary>
        public String IdUsuario { get; set; }

        /// <summary>
        /// IdUbicacion
        /// </summary>
        public Int32 IdUbicacion { get; set; }

        /// <summary>
        /// IdTipoHerramienta
        /// </summary>
        public Int32 IdTipoHerramienta { get; set; }

        /// <summary>
        /// EsAdmin
        /// </summary>
        public Boolean EsAdmin { get; set; }

        public Boolean EsOper { get; set; }

    }
}