using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGlovo.Transfers
{
    public class Clientedt
    {
        public int IDCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> Telefono { get; set; }
    }
}