using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.BLL;
using GestionVentas.Entidades;

namespace GestionVentas.Registros
{
    public partial class RVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            VendedoresBLL.Eliminar(String(VentasIdTextBox.Text));
            Page.ClientScript.RegisterStartupScript(GetType(), "scripts", "<script>alert(' Se Elimino Correctamente');</script>");
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            float total = 0;


            float.TryParse(TotalTextBox.Text, out total);
            ComisionTextBox.Text = (total * 1.6 / 100).ToString() + "%";


            Ventas ventas = new Ventas();
            VentasBLL.Guardar(ventas);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert(' Se Guardo Correctamente');</script>");
        }
    }
}