using System;
using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo encargado de gestionar los distintos tipos de clientes
    /// cuenta con un modelo propio puesto que en un futuro cada tipo
    /// de cliente puede contener diferencias importantes, de momento
    /// es una clase innecesaria.
    /// </summary>
    public class TipoCliente
    {
        [Key]
        public int Tipo_Cliente_ID { get; set; }

        [Required, MaxLength(100)]
        public string Denominacion { get; set; }


    }
}
