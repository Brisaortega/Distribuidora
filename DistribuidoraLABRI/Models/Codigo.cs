using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DistribuidoraLABRI.Models
{

    [Table("Codigo")]
    public partial class Codigo

    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, ingresar el codigo del producto")]
        [StringLength(50)]
        public string? CodigoProducto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaRegistro { get; set; }
    }
    
}
