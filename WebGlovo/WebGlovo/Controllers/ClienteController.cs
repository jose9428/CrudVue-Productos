using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebGlovo.Models;
using WebGlovo.Transfers;


namespace WebGlovo.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        [Route("api/cliente/IniciarSesion")]
        public bool IniciarSesion(string email, string contraseña)
        {
            return Cliente.IniciarSesion(email , contraseña);
        }

        [HttpGet]
        [Route("api/cliente/ActualizarDireccion")]
        public bool ActualizarDireccion(int id, string direccion)
        {
            return Cliente.ActualizarDireccion(id, direccion);
        }

        [HttpPut]
        [Route("api/cliente/ActualizarDireccion2")]
        public bool ActualizarDireccion2(Clientedt cli)
        {
            return Cliente.ActualizarDireccion2(cli);
        }


        [HttpPost]
        [Route("api/cliente/IniciarSesion2")]
        public bool IniciarSesion2(Clientedt cli)
        {
            return Cliente.IniciarSesion2(cli);
        }

        [HttpGet]
        [Route("api/cliente/ListarTodos")]
        public IEnumerable<Clientedt> ListarTodosClientes()
        {
            return Cliente.ListarTodosClientes();
        }

    }
}
