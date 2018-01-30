using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;

namespace GestionVentas.BLL
{
    public class CuadreBLL
    {
        public static void Insertar(CuadreVendedor cv)
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


        public static List<CuadreVendedor> GetLista()
        {
            List<CuadreVendedor> lista = new List<CuadreVendedor>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.cuadre.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            CuadreVendedor cl = db.cuadre.Find(v);

            db.cuadre.Remove(cl);
            db.SaveChanges();
        }
        public static CuadreVendedor Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.cuadre.Find(Id);
        }
        public static List<CuadreVendedor> GetListaVendedor(int tmp)
        {
            List<CuadreVendedor> lista = new List<CuadreVendedor>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.cuadre.Where(p => p.VendedorId == tmp).ToList();
            return lista;
        }

        public static List<CuadreVendedor> GetId(int cuadreid)
        {
            List<CuadreVendedor> lista = new List<CuadreVendedor>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.cuadre.Where(p => p.CuadreId == cuadreid).ToList();
            return lista;
        }

    }
}