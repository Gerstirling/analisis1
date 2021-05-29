using analisis.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Entidades.Ventas
{
    public class venta
    {
        public int idventa { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }

        public string num_comprobante { get; set; }
        public DateTime fecha_hoara { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }

        List<persona> Personas { get; set; }
        List<Usuario> Usuarios { get; set; }

    }
}
