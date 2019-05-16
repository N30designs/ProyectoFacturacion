using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion.Model
{
    class Series
    {
        [Key, MaxLength(30)]
        public int SerieID { get; set; }

        [Required, MaxLength(30)]
        public int Valor { get; set; }

        [Required, MaxLength(10)]
        public string Serie { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
