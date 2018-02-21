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
        public virtual DbSet<CuadresVendedores> Cuadre { get; set; }
        public virtual DbSet<CuadresVendedorDetalles> detalle { get; set; }
        public virtual DbSet<Vendedores> vendedores { get; set; }
        public virtual DbSet<Ventas> ventas { get; set; }
        public virtual DbSet<Subsidios> subsidios { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<DetalleVendedores> DetalleVendedores { get; set; }
        
    }
}