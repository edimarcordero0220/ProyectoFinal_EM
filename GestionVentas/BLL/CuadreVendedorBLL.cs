using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;
using System.Linq.Expressions;

namespace GestionVentas.BLL
{
    public class CuadreVendedorBLL
    {
        public static void Insertar(CuadresVendedores cv)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.cuadre.Add(cv);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<CuadresVendedores> GetLista()
        {
            List<CuadresVendedores> lista = new List<CuadresVendedores>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.cuadre.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            CuadresVendedores cl = db.cuadre.Find(v);

            db.cuadre.Remove(cl);
            db.SaveChanges();
        }
        public static CuadresVendedores Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.cuadre.Find(Id);
        }
        public static List<CuadresVendedores> GetListaVendedor(int tmp)
        {
            List<CuadresVendedores> lista = new List<CuadresVendedores>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.cuadre.Where(p => p.VendedorId == tmp).ToList();
            return lista;
        }

        public static List<CuadresVendedores> GetId(int cuadreid)
        {
            List<CuadresVendedores> lista = new List<CuadresVendedores>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.cuadre.Where(p => p.CuadreId == cuadreid).ToList();
            return lista;
        }
        public static List<Entidades.CuadresVendedores> GetList(Expression<Func<Entidades.CuadresVendedores, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<CuadresVendedores>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<CuadresVendedores> GetListTodo()
        {
            List<CuadresVendedores> lista = null;
            using (var conn = new Repositorio<CuadresVendedores>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }

    }
}