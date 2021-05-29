using System.ComponentModel.DataAnnotations;

namespace analisis.Entidades.Almacen
{
    public class Articulo
    {
        public int idarticulo { get; set; }
        [Required]
        public int idcategoria { get; set; }
        public string codigo { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public string nombre { get; set; }
        [Required]
        public decimal precioVenta { get; set; }
        [Required]
        public int stock { get; set; }
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        //realcion con la tabla categorias
        public Categoria categoria { get; set; }

    }
}
