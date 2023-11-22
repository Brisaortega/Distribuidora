using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistribuidoraLABRI.Models
{

    [Table("Marcas")]
    public class Marcas
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, ingresar la marca del producto")]
        [Display(Name = "Marcas")]
        [StringLength(50)]
        public string? Marca { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        public DateTime? FechaRegistro { get; set; }
    }
  
}
