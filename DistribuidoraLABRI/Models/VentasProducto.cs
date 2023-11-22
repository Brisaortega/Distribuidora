using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DistribuidoraLABRI.Models
{
    public class VentasProducto
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Display(Name = "Fecha/Hora compra")]
        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.DateTime)]
        public DateTime? FechaHoraCompra { get; set; }

        [Display(Name = "Producto")]
        public string? Producto { get; set; }


        [Display(Name = "Codigo")]
        public int? Codigo { get; set; }

        [Display(Name = "Precio")]
        public int? Precio { get; set; }


        [Display(Name = "Fecha Registro")]
        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime? FechaRegistro { get; set; }

        [NotMapped]
        public string? ValidationError { get; set; }
    }
  
}
