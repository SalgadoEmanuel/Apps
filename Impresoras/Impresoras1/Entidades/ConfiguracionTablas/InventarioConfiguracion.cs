using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;


namespace Entidades.ConfiguracionTablas
{
    public class InventarioConfiguracion : EntityTypeConfiguration<InventarioTonners>
    {
        public InventarioConfiguracion()
        {
            ToTable("InventarioTonners");

            HasKey(c => c.Id);

            Property(c => c.Cantidad).IsRequired();

            Property(c => c.FechaCreacion).IsOptional();
        }
    }
}
