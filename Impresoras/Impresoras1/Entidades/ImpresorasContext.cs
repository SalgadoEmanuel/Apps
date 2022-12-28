using Entidades.ConfiguracionTablas;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Impresoras.Models
{
    public class ImpresorasContext : DbContext
    {
        public ImpresorasContext() : base("Impresoras")
        {

        }

        public DbSet<Impresora> Impresoras { get; set; }
        public DbSet<Tonner> Tonners { get; set; }
        public DbSet<InventarioTonners> InventarioTonners { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add( new ImpresoraConfiguracion());
            modelBuilder.Configurations.Add(new TonnerConfiguracion());
            modelBuilder.Configurations.Add(new InventarioConfiguracion());
            modelBuilder.Configurations.Add(new UbicacionConfiguracion());
        }       
        
    }
}