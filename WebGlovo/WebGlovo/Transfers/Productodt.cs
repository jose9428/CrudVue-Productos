using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGlovo.Transfers
{
    public class Productodt
    {
        public int IDproducto { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> IDCategoria { get; set; }
    }
}