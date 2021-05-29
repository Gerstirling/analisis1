using analisis.Entidades.Compras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos.Mapping.Compras
{
    public class detalle_ingresoMap : IEntityTypeConfiguration<detalle_ingreso>

    {
        public void Configure(EntityTypeBuilder<detalle_ingreso> builder)
        {
            builder.ToTable("articulo")
                .HasKey(c => c.iddetalle_ingreso);
            builder.Property(c => c.cantidad);
            builder.Property(c => c.precio);
              
        }
    }
}
