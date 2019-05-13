using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    class Albaran
    {
        public int ID_Albaran { get; set; }

        public DateTime Fecha { get; set; }
        public int TipoRecargo { get; set; }
        public int TipoRetencion { get; set; }
        public decimal ImporteIva { get; set; }
        public decimal ImporteBruto { get; set; }
        public decimal ImporteRecargo { get; set; }
        public int MyProperty { get; set; }


        public virtual Cliente cliente { get; set; }
        
    }
}
