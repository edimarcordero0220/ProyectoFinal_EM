using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionVentas.Entidades
{
    public class DetalleVendedores
    {
        [Key]
        public int ID { get; set; }
        public int CategoriaId { get; set; }
        public float MaximoVentas { get; set; }
    }
}
