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
    public class CategoriaController : ApiController
    {
        [HttpGet]
        [Route("api/Categoria/ListarCategoria")]
        public IEnumerable<Categoriadt> ListarCategoria()
        {
            return Categoria.ListarCategoria();
        }
    }
}
