using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Entidades.ConfiguracionTablas
{
    public class UbicacionConfiguracion : EntityTypeConfiguration<Ubicacion>
    {
        public UbicacionConfiguracion()
        {
            ToTable("Ubicacion");

            HasKey(c => c.Id);

            Property(c => c.Descripcion).HasMaxLength(150).IsRequired();

            Property(c => c.FechaCreacion).IsOptional();

        }
    }
}
