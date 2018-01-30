using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;

namespace GestionVentas.BLL
{
    public class DetalleCuadreBLL
    {
        public static void Insertar(CuadreVendedorDetalle cd)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.detallecuadre.Add(cd);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<CuadreVendedorDetalle> GetLista()
        {
            List<CuadreVendedorDetalle> lista = new List<CuadreVendedorDetalle>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.detallecuadre.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            CuadreVendedorDetalle cl = db.detallecuadre.Find(v);

            db.detallecuadre.Remove(cl);
            db.SaveChanges();
        }
        public static CuadreVendedorDetalle Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.detallecuadre.Find(Id);
        }
        public static List<CuadreVendedorDetalle> GetListaCuadre(int tmp)
        {
            List<CuadreVendedorDetalle> lista = new List<CuadreVendedorDetalle>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.detallecuadre.Where(p => p.CuadreId == tmp).ToList();
            return lista;
        }

     

    }
}