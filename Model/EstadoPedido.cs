using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Clase que representa el estado de los pedidos, se relacionará con el modelo pedidos. 
    /// </summary>
  public  class EstadoPedido
    {
        
        [Key]
        public int EstadoPedidoID { get; set; }

        [Required, MaxLength(100)]
        public string Descripcion { get; set; }


    }
}
