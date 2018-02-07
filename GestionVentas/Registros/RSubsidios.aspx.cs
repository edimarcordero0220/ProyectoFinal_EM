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
    public partial class RSubsidios : System.Web.UI.Page
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
        public void Llenar(Subsidios subsidios)
        {
            float Monto = Convert.ToSingle(MontoTextBox.Text);
        }

        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            VendedoresBLL.Eliminar(String(SubsidiosIdTextBox.Text));
            Page.ClientScript.RegisterStartupScript(GetType(), "scripts", "<script>alert(' Se Elimino Correctamente');</script>");
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Subsidios subsidios = new Subsidios();
            Llenar(subsidios);
            SubsidiosBLL.Guardar(subsidios);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert(' Se Guardo Correctamente');</script>");
        }
    }
}