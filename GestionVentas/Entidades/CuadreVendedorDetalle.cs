using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class CuadreVendedorDetalle
    {
        [Key]
        public int Id { get; set; }
        public int CuadreId { get; set; }
        public decimal Vendido { get; set; }
        public decimal Subsidios { get; set; }
        public decimal Gastos { get; set; }
        public decimal Pagos { get; set; }
        public decimal Comision { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Pendiente { get; set; }
        public decimal Monto { get; set; }
    }
}