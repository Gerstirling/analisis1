using analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos.Mapping.Usuarios
{
    class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.ToTable("usuario")
                       .HasKey(c => c.idusuario);
            builder.Property(c => c.nombre)
                .HasMaxLength(200);
            builder.Property(c => c.tipo_documento)
               .HasMaxLength(200);
            builder.Property(c => c.num_documento);
            builder.Property(c => c.direccion)
                  .HasMaxLength(200);
            builder.Property(c => c.telefono);
            builder.Property(c => c.email)
                 .HasMaxLength(200);
            builder.Property(c => c.password_hash)
                .HasMaxLength(16);
            builder.Property(c => c.password_salt)
               .HasMaxLength(16);
            builder.Property(c => c.condicion);
             


        }
    }
}
