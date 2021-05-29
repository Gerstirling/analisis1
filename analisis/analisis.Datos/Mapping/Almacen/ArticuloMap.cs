using analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("articulo")
                .HasKey(c => c.idarticulo);
            builder.Property(c => c.idcategoria);
            builder.Property(c => c.codigo)
                .HasMaxLength(50);
            builder.Property(c => c.nombre)
                .HasMaxLength(200);
            builder.Property(c => c.precioVenta);
            builder.Property(c => c.stock);
            builder.Property(c => c.descripcion)
                .HasMaxLength(256);
            builder.Property (c => c. condicion)
                .HasMaxLength(256);
        }
    }
}
