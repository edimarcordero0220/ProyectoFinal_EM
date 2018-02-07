using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;
using GestionVentas.DAL;

namespace GestionVentas.BLL
{
    public class SubsidiosBLL
    {
        public static void Guardar(Subsidios sub)
        {
            try
            {


                GestionVentaDb db = new GestionVentaDb();
                db.subsidios.Add(sub);
                //db.SaveChanges();
                db.Dispose();
            }
            catch (FormatException)
            {
                Console.WriteLine("No se puede convertir a '{0}' a un solo. ", sub);
            }

        }
        public static void Eliminar(int eliminar)
        {
            GestionVentaDb db = new GestionVentaDb();
            Subsidios sub = db.subsidios.Find(eliminar);

            db.subsidios.Remove(sub);
            // db.SaveChanges();
        }

        public static Subsidios Buscar(int Id)
        {
            GestionVentaDb db = new GestionVentaDb();
            return db.subsidios.Find(Id);
        }
        public static List<Subsidios> GetListaSubsidiosId(int tmp)
        {
            List<Subsidios> lista = new List<Subsidios>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.subsidios.Where(s => s.SubsidiosId == tmp).ToList();
            return lista;
        }
        public static List<Subsidios> GetConcepto(string tmp)
        {
            List<Subsidios> lista = new List<Subsidios>();
            GestionVentaDb db = new GestionVentaDb();
            lista = db.subsidios.Where(s => s.Concepto == tmp).ToList();
            return lista;
        }

    }
}
