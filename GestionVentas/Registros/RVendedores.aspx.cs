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



            vendedores.Nombres = NombresTextBox.Text;
            DescripcionTextBox.Text = DescripcionTextBox.Text + "Productos Vendidos";
            MjeInicialTextBox.Text = MjeInicialTextBox.Text + " Mayor Venta  ";
            MjeFinalTextBox.Text = MjeFinalTextBox.Text + " Satisfecho ";

        }

      

       
         protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
                Vendedores vendedores = new Vendedores();
                Llenar(vendedores);
                VendedoresBLL.Guardar(vendedores);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert(' Se Guardo Correctamente');</script>");

            }

        protected void LimpiarCampos_Click1(object sender, EventArgs e)
        {
            VendedoresBLL.Eliminar(String(IdTextBox.Text));
            Page.ClientScript.RegisterStartupScript(GetType(), "scripts", "<script>alert(' Se Elimino Correctamente');</script>");
        }
        public void BuscarVendedores(Vendedores ve)
        {
            if (VendedoresBLL.Buscar(String(IdTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {

                NombresTextBox.Text = Convert.ToString(ve.Nombres);
                DescripcionTextBox.Text = ve.Descripcion;
                MjeInicialTextBox.Text = ve.MensajeInicial;
                MjeFinalTextBox.Text = ve.MensajeFinal;
                float PorcientoComision1 = Convert.ToSingle(Pct1TextBox.Text);
                float PorcientoComision2 = Convert.ToSingle(Pct2TextBox.Text);
                float PorcientoComision3 = Convert.ToSingle(Pct3TextBox.Text);
                float PorcientoComision4 = Convert.ToSingle(Pct4TextBox.Text);
                float PorcientoComision5 = Convert.ToSingle(Pct5TextBox.Text);
                float LimiteVentas = Convert.ToSingle(LimiteVTextBox.Text);


            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {

            if (IdTextBox.Text == "")
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes llenar el campo Id para realizar la busqueda!');</script>");
            }
            else
            {
                BuscarVendedores(VendedoresBLL.Buscar(String(IdTextBox.Text)));
            }
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Attributes.Add("onclick", "return printing()");
            ClientScript.RegisterStartupScript(this.GetType(), "printOperation", "printing()", true);

        }
        
        

        protected void AnularButton_Click(object sender, EventArgs e)
        {
            IdTextBox.ReadOnly = true;
        }
    }
}