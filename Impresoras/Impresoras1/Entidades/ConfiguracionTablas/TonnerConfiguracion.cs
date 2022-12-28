using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Entidades.ConfiguracionTablas
{
    public class TonnerConfiguracion : EntityTypeConfiguration<Tonner>
    {
        public TonnerConfiguracion()
        {
            ToTable("Tonner");

            HasKey(c => c.Id);

            Property(c => c.Marca).HasMaxLength(150).IsRequired();

            Property(c => c.Modelo).HasMaxLength(150).IsRequired();

            Property(c => c.Estado).IsOptional();

            Property(c => c.FechaCreacion).IsOptional();

        }
    }
}