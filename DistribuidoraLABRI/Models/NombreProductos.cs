using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DistribuidoraLABRI.Models
{

    [Table("NombreProductos")]
    public class NombreProductos
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }


        [Display(Name = "NombreProductos")]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [NotMapped]


        [Display(Name = "Clasificación")]
        public int? Clasificacion { get; set; }


        [Display(Name = "Fecha Registro")]
        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? FechaRegistro { get; set; }

        [Display(Name = "Fecha Vencimiento")]
        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? FechaVencimiento { get; set; }
    }
    
}
