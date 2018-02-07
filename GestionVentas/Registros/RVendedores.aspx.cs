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
    public partial class RVendedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        public void Llenar(Vendedores vendedores)
        {

            float LimiteVentas = 0;


            float.TryParse(LimiteVTextBox.Text, out LimiteVentas);
            Pct1TextBox.Text = (LimiteVentas * 0.1 / 100).ToString() + "%";
            Pct2TextBox.Text = (LimiteVentas * 0.2 / 100).ToString() + "%";
            Pct3TextBox.Text = (LimiteVentas * 0.3 / 100).ToString() + "%";
            Pct4TextBox.Text = (LimiteVentas * 0.4/ 100).ToString() + "%";
            Pct5TextBox.Text = (LimiteVentas * 0.5 / 100).ToString() + "%";



            vendedores.Nombres = NombreTextBox.Text;
            DescripcionTextBox.Text = DescripcionTextBox.Text + "Productos Vendidos";
            MjITextBox.Text = MjITextBox.Text + " Mayor Venta  ";
            MjFTextBox.Text = MjFTextBox.Text + " Satisfecho ";

        }


        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            VendedoresBLL.Eliminar(String(IdTextBox.Text));
            Page.ClientScript.RegisterStartupScript(GetType(), "scripts", "<script>alert(' Se Elimino Correctamente');</script>");
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Vendedores vendedores = new Vendedores();
            Llenar(vendedores);
            VendedoresBLL.Guardar(vendedores);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert(' Se Guardo Correctamente');</script>");

        }
    }
}