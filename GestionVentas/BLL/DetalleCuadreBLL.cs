using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;
using System.Linq.Expressions;

namespace GestionVentas.BLL
{
    public class DetalleCuadreBLL
    {
        public static void Insertar(CuadresVendedorDetalle cd)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.detalle.Add(cd);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<CuadresVendedorDetalle> GetLista()
        {
            List<CuadresVendedorDetalle> lista = new List<CuadresVendedorDetalle>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.detalle.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            CuadresVendedorDetalle cl = db.detalle.Find(v);

            db.detalle.Remove(cl);
            db.SaveChanges();
        }
        public static CuadresVendedorDetalle Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.detalle.Find(Id);
        }
        public static List<CuadresVendedorDetalle> GetListaCuadre(int tmp)
        {
            List<CuadresVendedorDetalle> lista = new List<CuadresVendedorDetalle>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.detalle.Where(p => p.CuadreId == tmp).ToList();
            return lista;
        }
        public static List<Entidades.CuadresVendedorDetalle> GetList(Expression<Func<Entidades.CuadresVendedorDetalle, bool>> criterioBusqueda)
        {
            using (var repositorio = new Repositorio<CuadresVendedorDetalle>())
            {
                return repositorio.GetList(criterioBusqueda);
            }
        }
        public static List<CuadresVendedorDetalle> GetListTodo()
        {
            List<CuadresVendedorDetalle> lista = null;
            using (var conn = new Repositorio<CuadresVendedorDetalle>())
            {
                lista = conn.GetListTodo().ToList();
            }

            return lista;
        }


    }
}