using System;
using System.Collections.Generic;
using System.Text;

namespace analisis.Entidades.Usuarios
{
    public class Usuario
    {
        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string tipo_documento { get; set; }
        public string num_documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public byte password_hash { get; set; }
        public byte password_salt { get; set; }
        public bool condicion { get; set; }

        //relacion con la tabla roles
        public List<Rol> Roles { get; set; }
    }
}
