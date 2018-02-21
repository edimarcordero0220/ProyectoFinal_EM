using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;
using System.Linq.Expressions;

namespace GestionVentas.BLL
{
    public class DetalleVendedoresBLL
    {
        public static void Insertar(DetalleVendedores dv)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.DetalleVendedores.Add(dv);
               // db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<DetalleVendedores> GetLista()
        {
            List<DetalleVendedores> lista = new List<DetalleVendedores>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.DetalleVendedores.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            DetalleVendedores de = db.DetalleVendedores.Find(v);

            db.DetalleVendedores.Remove(de);
            db.SaveChanges();
        }
        public static DetalleVendedores Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.DetalleVendedores.Find(Id);
        }
        public static List<DetalleVendedores> GetListaCuadre(int tmp)
        {
            List<DetalleVendedores> lista = new List<DetalleVendedores>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.DetalleVendedores.Where(d => d.CategoriaId == tmp).ToList();
            return lista;
        }
        public static List<DetalleVendedores> GetList(Expression<Func<DetalleVendedores, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<DetalleVendedores>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<DetalleVendedores> GetListTodo()
        {
            List<DetalleVendedores> lista = null;
            using (var conn = new Repositorio<DetalleVendedores>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }

    }
}
