using analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos.Mapping.Usuarios
{
    class RolMap : IEntityTypeConfiguration<Rol>
    {

        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol")
                          .HasKey(c => c.indrol);
            builder.Property(c => c.nombre)
                .HasMaxLength(200);
            builder.Property(c => c.descripcion)
                .HasMaxLength(200);
            builder.Property(c => c.condicion)
                  .HasMaxLength(200);
            
        }
    }
}