using System;
using System.ComponentModel.DataAnnotations;


namespace facturacion.Model
{
    /// <summary>
    /// Modelo que crea el objeto Albarán con todos sus atributos, actualmente está incompleto. 
    /// </summary>
    public class Albaran
    {
        [Key]
        public int Albaran_ID { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoRecargo { get; set; }
        public int TipoRetencion { get; set; }
        public decimal ImporteIva { get; set; }
        public decimal ImporteBruto { get; set; }
        public decimal ImporteRecargo { get; set; }
        public decimal Total { get; set; }


        public virtual Cliente Cliente { get; set; }
        
    }
}
