using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Entidades.ConfiguracionTablas
{
    public class ImpresoraConfiguracion : EntityTypeConfiguration<Impresora>
    {
        public ImpresoraConfiguracion()
        {
            ToTable("Impresora");

            HasKey(c => c.Id);

            Property(c => c.Marca).HasMaxLength(150).IsRequired();

            Property(c => c.Modelo).HasMaxLength(150).IsRequired();

            Property(c => c.SN).HasMaxLength(150).IsRequired();

            Property(c => c.IP).HasMaxLength(150);

            Property(c => c.FechaCreacion).IsOptional();

            Property(c => c.Estado).IsOptional();
        }
    }
}