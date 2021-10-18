using Microsoft.EntityFrameworkCore;
using RolDetalle_II.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolDetalle_II.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Permiso> Permiso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\RoldDetalle.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permiso>().HasData(new Permiso
            {
                PermisoId = 1,
                Nombre = "Permiso para estudios",
                Descripcion = "Permiso para que el trabajador pueda estudiar"
            });
            modelBuilder.Entity<Permiso>().HasData(new Permiso
            {
                PermisoId = 2,
                Nombre = "Permiso por Vacaiones",
                Descripcion = "Permiso para que el trabajador descanse"
            });
            modelBuilder.Entity<Permiso>().HasData(new Permiso
            {
                PermisoId = 3,
                Nombre = "Permiso de emergencia",
                Descripcion = "Permiso para que el trbajador salga en caso de emergencia"
            });
            modelBuilder.Entity<Permiso>().HasData(new Permiso
            {
                PermisoId = 4,
                Nombre = "Permiso de salud",
                Descripcion = "Permiso para que el trabajador visite a medico en caso de enfermedad"
            });
        }
    }
}
