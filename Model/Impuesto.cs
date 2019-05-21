using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de la gestión de los tipos de impuesto. Se relacionará con pedidos, facturas, etc...
    /// Originalmente era tratado como IVA(impuesto) y retención(impuesto asociado).
    /// </summary>
    public class Impuesto
    {       
        [Key]
        public int Impuesto_ID { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int ImpuestoPorcentaje { get; set; }


        public int Impuesto_Asociado_Porcentaje { get; set; }

        [Required]
        public virtual ICollection<Pais> Pais { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
