using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebGlovo.Transfers;
using WebGlovo.Models;

namespace WebGlovo.Controllers
{
    public class ProductoController : ApiController
    {
        [HttpGet]
        [Route("api/Producto/ListaProducto")]
        public IEnumerable<Productodt> ListaProducto(int idCategoria)
        {
            return Producto.ListarProducto(idCategoria);
        }

        [HttpGet]
        [Route("api/Producto/EliminarProducto")]
        public bool EliminarProducto(int idProducto)
        {
           return Producto.EliminarProducto(idProducto);
        }

        [HttpGet]
        [Route("api/Producto/ObtenerProducto")]
        public Productodt ObtenerProducto(int idProducto)
        {
            return Producto.ObtenerProducto(idProducto);
        }

        [HttpPut]
        [Route("api/Producto/ActualizarProducto")]
        public Productodt ActualizarProducto(Productodt prod)
        {
            return Producto.ActualizarProducto(prod);
        }

        [HttpPost]
        [Route("api/Producto/AgregarProducto")]
        public Productodt AgregarProducto(Productodt prod)
        {
            return Producto.AgregarProducto(prod);
        }
    }
}
