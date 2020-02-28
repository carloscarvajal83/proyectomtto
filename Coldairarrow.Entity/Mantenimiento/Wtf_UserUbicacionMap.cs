using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_UserUbicacionMap
    /// </summary>
    [Table("Wtf_UserUbicacionMap")]
    public class Wtf_UserUbicacionMap
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public Int32 Id { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// IdUbicacion
        /// </summary>
        public Int32 IdUbicacion { get; set; }

    }
}