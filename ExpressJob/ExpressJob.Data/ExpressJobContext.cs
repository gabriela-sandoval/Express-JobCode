using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpressJob.Domain;


namespace ExpressJob.Data
{
    public class ExpressJobContext : IdentityDbContext<ExpressJobUser, IdentityRole, string>

    {
        public DbSet<ExpressJobUser> ExpressUsers { get; set; }

        public DbSet<Trabajador> Trabajadors { get; set; }

        public DbSet<Servicio> Servicios { get; set; }

        public DbSet<TrabajadorServicio> TrabajadorServicios { get; set; }


        public ExpressJobContext(DbContextOptions<ExpressJobContext> options)
           : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TrabajadorServicio>()
                .HasKey(x => new { x.ServicioId, x.TrabajadorId });
                

        }

    }
}
