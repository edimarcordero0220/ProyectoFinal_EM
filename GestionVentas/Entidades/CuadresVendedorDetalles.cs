using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class CuadresVendedorDetalles
    {
        [Key]
        public int Id { get; set; }
        
        public int CuadreId { get; set; }
        public int Pendiente { get; set; }
        public int Monto { get; set; }
        public int Vendido { get; set; }
        public int Subsidios { get; set; }
        public int Gastos { get; set; }
        public int Pagos { get; set; }
        public int Comision { get; set; }
        public int Ganancia { get; set; }

        public virtual List<CuadresVendedores> cuadrevendedor { get; set; }
        public CuadresVendedorDetalles()
        {
            this.cuadrevendedor = new List<CuadresVendedores>();
        }
    }
}