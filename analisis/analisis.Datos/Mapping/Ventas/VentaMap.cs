using analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace analisis.Datos.Mapping.Ventas
{
    public class VentaMap : IEntityTypeConfiguration<venta>
    {
        public void Configure(EntityTypeBuilder<venta> builder)
        {

            builder.ToTable("venta")
          .HasKey(c => c.idventa);
            builder.Property(c => c.tipo_comprobante)
                .HasMaxLength(200);
            builder.Property(c => c.serie_comprobante)
               .HasMaxLength(25);
            builder.Property(c => c.num_comprobante);
            builder.Property(c => c.fecha_hoara)
                  .HasMaxLength(30);
            builder.Property(c => c.impuesto);
            builder.Property(c => c.total);
            builder.Property(c => c.estado)
                  .HasMaxLength(200);


        }
    }

}
