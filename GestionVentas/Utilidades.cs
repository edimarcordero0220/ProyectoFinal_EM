using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionVentas
{
    public class Utilidades
    {

        public static int TOINT(string nombre)
        {
            int.TryParse(nombre, out int numero);
            return numero;
        }
    }
}