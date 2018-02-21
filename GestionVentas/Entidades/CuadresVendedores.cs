using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class CuadresVendedores
    {
        [Key]
        public int CuadreId  { get; set; }
        public int VendedorId { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public int Monto { get; set; }

        public virtual List<CuadresVendedorDetalles> detalle { get; set; }

        public CuadresVendedores()
        {
            this.detalle = new List<CuadresVendedorDetalles>();
        }
        public List<CuadresVendedorDetalles> Detalle;
    }
}