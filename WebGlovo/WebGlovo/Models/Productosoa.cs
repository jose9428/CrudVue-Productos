using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using WebGlovo.Transfers;

namespace WebGlovo.Models
{
    public partial class Producto
    {
        public static IEnumerable<Productodt> ListarProducto(int id)
        {
            EntitiesGlovo db = new EntitiesGlovo();

            var lista = from b in db.Producto.Where(p => p.IDCategoria == id)
                        select new Productodt()
                        {
                            IDproducto = b.IDproducto,
                            NombreProducto = b.NombreProducto,
                            Stock = b.Stock,
                            Precio = b.Precio,
                            IDCategoria = b.IDCategoria
                        };

            return lista;
        }

        public static bool EliminarProducto(int id) {
            EntitiesGlovo db = new EntitiesGlovo();
            Producto p = db.Producto.Find(id);
            db.Producto.Remove(p);
            db.SaveChanges();
            return true;
        }

        public static Productodt ObtenerProducto(int id) {
            EntitiesGlovo db = new EntitiesGlovo();

            var prod = db.Producto.Select(p=> new Productodt() {
                IDCategoria = p.IDCategoria,
                IDproducto = p.IDproducto,
                NombreProducto = p.NombreProducto,
                Precio = p.Precio,
                Stock = p.Stock
                
            }).SingleOrDefault(p => p.IDproducto== id);

            if (prod == null) {
                prod = new Productodt()
                {
                    IDCategoria = 0,
                    IDproducto = 0,
                    NombreProducto = "",
                    Precio = 0,
                    Stock = 0
                };
            }

            return prod;
        }

        public static Productodt ActualizarProducto(Productodt prod)
        {
            EntitiesGlovo db = new EntitiesGlovo();

            Producto p = new Producto()
            {
                IDCategoria = prod.IDCategoria,
                IDproducto = prod.IDproducto,
                NombreProducto = prod.NombreProducto,
                Precio = prod.Precio,
                Stock = prod.Stock
            };

            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
            return Producto.ObtenerProducto(p.IDproducto);
        }

        public static Productodt AgregarProducto(Productodt prod)
        {
            EntitiesGlovo db = new EntitiesGlovo();

            Producto p = new Producto()
            {
                IDCategoria = prod.IDCategoria,
                NombreProducto = prod.NombreProducto,
                Precio = prod.Precio,
                Stock = prod.Stock
            };

            db.Producto.Add(p);
            db.SaveChanges();
            return Producto.ObtenerProducto(p.IDproducto);
        }
    }
}