using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using GestionVentas.Entidades;

namespace GestionVentas.DAL
{
    public class GestionVentaDb : DbContext
    {
        public GestionVentaDb() : base("name = ConStr")
        {
                
        }
        public virtual DbSet<Gastos> gasto { get; set; }
        public virtual DbSet<Pagos> pago { get; set; }
        public virtual DbSet<CuadresVendedores> cuadre { get; set; }
        public virtual DbSet<CuadresVendedorDetalle> detalle { get; set; }
        
    }
}