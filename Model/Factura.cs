using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    class Factura
    {
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Importe { get; set; }

        public virtual Cliente cliente { get; set; }
        
    }
}
