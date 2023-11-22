using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DistribuidoraLABRI.Models
{
    [Table("Productos")]
    public class Productos
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }


        [Display(Name = "Imagen")]
        public string? ImagenProducto { get; set; }

        [Display(Name = "Codigo")]
        public int? Codigo { get; set; }

        [Display(Name = "NombreProducto")]
        public string? NombreProducto { get; set; }

        [Display(Name = "TipoMarca")]
        public string? TipoMarca { get; set; }

        [Display(Name = "Clasificacion")]
        [StringLength(50)]
        public string? Clasificacion { get; set; }



        [Display(Name = "Fecha Registro")]
        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? FechaRegistro { get; set; }
    }
  
}
