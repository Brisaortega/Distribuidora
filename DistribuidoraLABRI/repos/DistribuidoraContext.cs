using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DistribuidoraLABRI.Models;
using DistribuidoraLABRI.repos.Models;
using NPOI.SS.Formula.Functions;
using static NPOI.HSSF.Util.HSSFColor;

namespace DistribuidoraLABRI.repos
{
    public partial class DistribuidoraContext:DbContext
    {
        public DistribuidoraContext()
        {
        }

        public DistribuidoraContext(DbContextOptions<DistribuidoraContext> options)
            : base(options)
        {
        }
        public virtual DbSet<CondicionPago> CondicionPagos { get; set; }
        public virtual DbSet<ListaPrecio> ListaPrecios { get; set; }
        public virtual DbSet<Clasificacion> Clasificaciones { get; set; }
        public virtual DbSet<Marcas> Marca { get; set; }
        public virtual DbSet<NombreProductos> NombreProducto { get; set; }
        public virtual DbSet<VentasProducto> VentasProductos { get; set; }
        public virtual DbSet<Productos> Producto { get; set; }
        public virtual DbSet<Codigo> Codigos { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("name=conexion");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
