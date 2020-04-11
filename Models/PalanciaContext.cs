using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Palancia.Models
{
    public partial class PalanciaContext : DbContext
    {
        public PalanciaContext()
        {
        }

        public PalanciaContext(DbContextOptions<PalanciaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CodigoPostal> CodigoPostal { get; set; }
        public virtual DbSet<Comunidades> Comunidades { get; set; }
        public virtual DbSet<Fiesta> Fiesta { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<LoginsAttemps> LoginsAttemps { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Poblaciones> Poblaciones { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }
        public virtual DbSet<TipoUsu> TipoUsu { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

       
    }
}
