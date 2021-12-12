using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Mantenimiento
{
    /// <summary>
    /// Wtf_vReporteControlesHerramienta
    /// </summary>
    [Table("Wtf_vReporteControlesHerramienta")]
    public class Wtf_vReporteControlesHerramienta
    {

        /// <summary>
        /// Id
        /// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// Serial
        /// </summary>
        public String Serial { get; set; }

        /// <summary>
        /// ItemNumber
        /// </summary>
        public String ItemNumber { get; set; }

        /// <summary>
        /// IdTipoHerramienta
        /// </summary>
        public Int32 IdTipoHerramienta { get; set; }


        /// <summary>
        /// Familia
        /// </summary>
        public String Familia { get; set; }

        /// <summary>
        /// Herramienta
        /// </summary>
        public String Herramienta { get; set; }

        /// <summary>
        /// IdControl
        /// </summary>
        public Int32 IdControl { get; set; }

        /// <summary>
        /// Control
        /// </summary>
        public String Control { get; set; }

        /// <summary>
        /// FechaInspeccion
        /// </summary>
        public DateTime? FechaInspeccion { get; set; }

        /// <summary>
        /// ProximaInspecion
        /// </summary>
        public DateTime? ProximaInspecion { get; set; }

        /// <summary>
        /// Configuradas
        /// </summary>
        public Int32 Configuradas { get; set; }

        /// <summary>
        /// SinConfigurar
        /// </summary>
        public Int32 SinConfigurar { get; set; }

        /// <summary>
        /// Vigentes
        /// </summary>
        public Int32 Vigentes { get; set; }

        /// <summary>
        /// EnPreaviso
        /// </summary>
        public Int32 EnPreaviso { get; set; }

        /// <summary>
        /// Vencidas
        /// </summary>
        public Int32 Vencidas { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        public Int32 Estado { get; set; }

    }
}