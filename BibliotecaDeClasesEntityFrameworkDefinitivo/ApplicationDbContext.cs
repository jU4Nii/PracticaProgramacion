using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaDeClasesEntityFrameworkDefinitivo
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=FinanzasDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }


    }
}
