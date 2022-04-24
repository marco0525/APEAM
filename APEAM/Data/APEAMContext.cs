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

        public DbSet<ExamenAPEAM.Models.Proveedor> Proveedor { get; set; }

        public DbSet<ExamenAPEAM.Models.Producto> Producto { get; set; }

        public DbSet<ExamenAPEAM.Models.TipoPago> TipoPago { get; set; }

        public DbSet<ExamenAPEAM.Models.RegistroTransaccion> RegistroTransaccion { get; set; }

        public DbSet<ExamenAPEAM.Models.Inventario> Inventario { get; set; }
    }
}
