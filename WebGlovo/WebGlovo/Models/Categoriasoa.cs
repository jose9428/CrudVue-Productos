using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGlovo.Transfers;

namespace WebGlovo.Models
{
    public partial class Categoria
    {
        public static IEnumerable<Categoriadt> ListarCategoria()
        {
            EntitiesGlovo db = new EntitiesGlovo();

            var lista = db.Categoria.Select(b => new Categoriadt()
            {
                IDcategoria = b.IDcategoria,
                TipoCategoria = b.TipoCategoria

            });

            return lista;
        }
    }
}