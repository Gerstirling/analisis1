using analisis.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Entidades.Ventas
{
    public class DetalleVenta
    {
        public int iddetalle_venta { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal descuento { get; set; }

        List<venta> ventas { get; set; }
        List<Articulo> Articulos { get; set; }
    }
}
