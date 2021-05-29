using analisis.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace analisis.Entidades.Compras
{
    public class detalle_ingreso
    {
        public int iddetalle_ingreso { get; set; }
        public int catindad { get; set; }
        public decimal precio { get; set; }


        List<ingreso> Ingresos { get; set; }
        List<Articulo> Articulos { get; set; }

    }
}
