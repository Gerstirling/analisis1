using analisis.Entidades.Compras;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos.Mapping.Compras
{
    class ingresoMap : IEntityTypeConfiguration<ingreso>
    {
        public void Configure(EntityTypeBuilder<ingreso> builder)
        {
            builder.ToTable("ingreso")
               .HasKey(c => c.idingreso);
            builder.Property(c => c.tipo_comprobante)
                .HasMaxLength(200);
            builder.Property(c => c.serie_comprobante)
               .HasMaxLength(200);
            builder.Property(c => c.num_comprobante);
                
            builder.Property(c => c.fecha_hora)
                .HasMaxLength(10);
            builder.Property(c => c.impuesto);
            builder.Property(c => c.total);
            builder.Property(c => c.estado)
                .HasMaxLength(256);
        }
    }
}
