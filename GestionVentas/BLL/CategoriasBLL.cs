using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;
using System.Linq.Expressions;

namespace GestionVentas.BLL
{
    public class CategoriasBLL
    {
        public static void Guardar(Categorias c)
        {
            try
            {


                GestionVentaDb db = new GestionVentaDb();
                db.Categorias.Add(c);
                //db.SaveChanges();
                db.Dispose();
            }
            catch (FormatException)
            {
                Console.WriteLine("No se puede convertir a '{0}' a un solo. ", c);
            }

        }
        public static void Eliminar(int eliminar)
        {
            GestionVentaDb db = new GestionVentaDb();
            Categorias c = db.Categorias.Find(eliminar);

            db.Categorias.Remove(c);
            // db.SaveChanges();
        }

        public static Categorias Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.Categorias.Find(Id);
        }
        public static List<Categorias> GetListaCategiriaId(int tmp)
        {
            List<Categorias> lista = new List<Categorias>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.Categorias.Where(c => c.CategoriaId == tmp).ToList();
            return lista;
        }
        public static List<Categorias> GetConcepto(string tmp)
        {
            List<Categorias> lista = new List<Categorias>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.Categorias.Where(c => c.Nombre == tmp).ToList();
            return lista;
        }
        public static List<Categorias> ListarTodo()
        {
            List<Categorias> lista = null;
            using (var conn = new Repositorio<Categorias>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }
        public static List<Categorias> GetList(Expression<Func<Categorias, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<Categorias>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        
        public static List<Categorias> GetListTodo()
        {
            List<Categorias> lista = null;
            using (var conn = new Repositorio<Categorias>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }

    }
}
