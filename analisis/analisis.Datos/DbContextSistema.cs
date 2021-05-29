using analisis.Datos.Mapping.Almacen;
using analisis.Entidades.Almacen;
using analisis.Datos.Mapping.Compras;
using analisis.Entidades.Compras;
using analisis.Datos.Mapping.Usuarios;
using analisis.Entidades.Usuarios;
using analisis.Datos.Mapping.Ventas;
using analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Articulo> Articulos { get; set; }

        public DbContextSistema(DbContextOptions<DbContextSistema>options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ArticuloMap());
            modelBuilder.ApplyConfiguration(new detalle_ingresoMap());
            modelBuilder.ApplyConfiguration(new ingresoMap());
            modelBuilder.ApplyConfiguration(new personaMap());
            modelBuilder.ApplyConfiguration(new RolMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new detalleVentaMap());
            modelBuilder.ApplyConfiguration(new VentaMap());

        }
    }
}
