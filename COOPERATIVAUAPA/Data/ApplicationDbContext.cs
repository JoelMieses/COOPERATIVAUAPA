using System;
using System.Collections.Generic;
using System.Text;
using COOPERATIVAUAPA.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace COOPERATIVAUAPA.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<EstatusSolicitud>().HasData(new EstatusSolicitud() {Id = 1, Nombre  = "Pendiente Aprobacion"});
            builder.Entity<EstatusSolicitud>().HasData(new EstatusSolicitud() { Id = 2, Nombre = "Aprobado" });
            builder.Entity<EstatusSolicitud>().HasData(new EstatusSolicitud() { Id = 3, Nombre = "Rechazado" });

            builder.Entity<TipoPrestamo>().HasData(new TipoPrestamo() { Id = 1, Nombre = "Hipotecario" });
            builder.Entity<TipoPrestamo>().HasData(new TipoPrestamo() { Id = 2, Nombre = "Personal" });

        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

        public DbSet<SolicitudPrestamos> SolicitudPrestamos { get; set; }

        public DbSet<TipoPrestamo> TipoPrestamo { get; set; }

        public DbSet<EstatusSolicitud> EstatusSolicitud { get; set; }

    }
}
