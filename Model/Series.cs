using System.ComponentModel.DataAnnotations;

namespace facturacion.Model
{
    /// <summary>
    /// Modelo que gestionará las distintas series de facturación, se relaciona
    /// con empresa y las series será únicas para cada empresa. 
    /// </summary>
    public class Series
    {
        [Key]
        public int SerieID { get; set; }

        [Required]
        public int Valor { get; set; }

        [Required, MaxLength(10)]
        public string Serie { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
