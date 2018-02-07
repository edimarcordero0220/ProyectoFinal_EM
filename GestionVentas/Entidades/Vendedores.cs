using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class Vendedores
    {
        [Key]
        public int VendedorId { get; set; }
        public string Nombres { get; set; }
        public string Descripcion { get; set; }
        public string MensajeInicial { get; set; }
        public string MensajeFinal { get; set; }
        public float PorcientoComision1 { get; set; }
        public float PorcientoComision2 { get; set; }
        public float PorcientoComision3 { get; set; }
        public float PorcientoComision4 { get; set; }
        public float PorcientoComision5 { get; set; }
        public float LimiteVentas { get; set; }

    }
}