using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.DAL;
using GestionVentas.Entidades;

namespace GestionVentas.BLL
{
    public class GastosBLL
    {
        public static void Insertar(Gastos g)
        {
            try
            {
                GestionVentaDb db = new GestionVentaDb();
                db.gasto.Add(g);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<Gastos> GetLista()
        {
            List<Gastos> lista = new List<Gastos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.gasto.ToList();
            return lista;

        }

        public static void Eliminar(int v)
        {
            GestionVentaDb db = new GestionVentaDb();
            Gastos cl = db.gasto.Find(v);

            db.gasto.Remove(cl);
            db.SaveChanges();
        }
        public static Gastos Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.gasto.Find(Id);
        }
        public static List<Gastos> GetListaVendedor(int tmp)
        {
            List<Gastos> lista = new List<Gastos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.gasto.Where(p => p.VendedorId == tmp).ToList();
            return lista;
        }

        public static List<Gastos> GetId(int gastoid)
        {
            List<Gastos> lista = new List<Gastos>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.gasto.Where(p => p.GastoId == gastoid).ToList();
            return lista;
        }
        

    }
}