using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Entidades.Compras
{
    public class ingreso
    {
        public int idingreso { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public DateTime fecha_hora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public string estado { get; set; }
    }
}
