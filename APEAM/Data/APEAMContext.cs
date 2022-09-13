#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenAPEAM.Models;

namespace APEAM.Data
{
    public class APEAMContext : DbContext
    {
        public APEAMContext (DbContextOptions<APEAMContext> options)
            : base(options)
        {
        }

        public DbSet<Proveedor> Proveedor { get; set; }

        public DbSet<Producto> Producto { get; set; }

        public DbSet<TipoPago> TipoPago { get; set; }

        public DbSet<RegistroTransaccion> RegistroTransaccion { get; set; }

        public DbSet<Inventario> Inventario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>()
                .HasMany(a => a.Transacciones)
                .WithOne(a => a.Producto)
                .HasForeignKey(f => f.IdProducto);

            modelBuilder.Entity<Producto>()
                .HasMany(a => a.Inventarios)
                .WithOne(a => a.Producto)
                .HasForeignKey(f => f.IdProducto);

            modelBuilder.Entity<Proveedor>()
                .HasMany(a => a.Transacciones)
                .WithOne(a => a.Proveedor)
                .HasForeignKey(f => f.IdProveedor);

            modelBuilder.Entity<Proveedor>()
                .HasMany(a => a.Inventarios)
                .WithOne(a => a.Proveedor)
                .HasForeignKey(f => f.IdProveedor);

            modelBuilder.Entity<TipoPago>()
                .HasMany(a => a.Transacciones)
                .WithOne(a => a.TipoPago)
                .HasForeignKey(f => f.IdTipoPago);

        }
    }
}
