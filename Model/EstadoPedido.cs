using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    class EstadoPedido
    {
        
        [Key, MaxLength(30)]
        public int EstadoPedidoID { get; set; }

        [Required, MaxLength(100)]
        public string Descripcion { get; set; }


    }
}
