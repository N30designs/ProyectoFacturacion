using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    class Impuesto
    {       
        public int Impuesto_ID { get; set; }

        public string Descripcion { get; set; }

        public int ImpuestoPorcentaje { get; set; }

        public int Impuesto_Asociado_Porcentaje { get; set; }

        public virtual ICollection<Pais> Pais { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
