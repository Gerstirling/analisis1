using analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos.Mapping.Ventas
{
    class detalleVentaMap : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalle venta")
                 .HasKey(c => c.iddetalle_venta);
            builder.Property(c => c.cantidad);
            builder.Property(c => c.precio);
            builder.Property(c => c.descuento);

        }
    }

}
