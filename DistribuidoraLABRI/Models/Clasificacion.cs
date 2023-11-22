using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DistribuidoraLABRI.Models
{
    [Table("Clasificacion")]
    public class Clasificacion
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, ingresar la clasificacion")]
        [Display(Name = "Clasificacion")]
        [StringLength(50)]
        public string? Clasificaciones { get; set; }

        [Column(TypeName = "smalldatetime")]
        [DataType(DataType.Date)]
        public DateTime? FechaRegistro { get; set; }
    }
    
}
