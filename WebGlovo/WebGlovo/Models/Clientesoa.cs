using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebGlovo.Transfers;

namespace WebGlovo.Models
{
    public partial class Cliente
    {

        public static bool IniciarSesion(string email , string contraseña) {
            bool estado;

            EntitiesGlovo db = new EntitiesGlovo();

            var encontro = db.Cliente.Where(t => t.Correo.Trim() == email.Trim() 
            && t.Contraseña.Trim() == contraseña).Count();

            if (encontro > 0)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }

            return estado;
        }

        public static bool IniciarSesion2(Clientedt cli)
        {
            bool estado;

            EntitiesGlovo db = new EntitiesGlovo();

            var encontro = db.Cliente.Where(t => t.Correo.Trim() == cli.Correo
            && t.Contraseña == cli.Contraseña).Count();

            if (encontro > 0)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }

            return estado;
        }

        public static bool ActualizarDireccion(int idCliente , string direccion)
        {
     
            EntitiesGlovo db = new EntitiesGlovo();

            Cliente c = db.Cliente.Find(idCliente);

            if (c == null)
            {
                return false;
            }
            else 
            {
                c.Direccion = direccion;
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
        }

        public static bool ActualizarDireccion2(Clientedt cli)
        {

            EntitiesGlovo db = new EntitiesGlovo();

            Cliente c = db.Cliente.Find(cli.IDCliente);

            if (c == null)
            {
                return false;
            }
            else
            {
                c.Direccion = cli.Direccion;
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
        }

        public static IEnumerable<Clientedt> ListarTodosClientes()
        {
            EntitiesGlovo db = new EntitiesGlovo();

            var lista = db.Cliente.Select(b=> new Clientedt() { 
                NombreCliente = b.NombreCliente,
                Correo = b.Correo ,
                Contraseña = b.Contraseña,
                Direccion = b.Direccion ,
                Telefono = b.Telefono
            });

            return lista;
        }
    }
}