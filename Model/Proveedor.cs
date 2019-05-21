using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de gestionar los distintos proveedores.
    /// Actualmente se encuentra incompleto pero funcional.
    /// </summary>
    public class Proveedor
    {

        [Key]
        public int Proveedor_ID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }


    }
}
