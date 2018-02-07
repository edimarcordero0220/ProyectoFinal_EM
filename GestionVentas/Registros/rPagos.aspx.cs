using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.Entidades;
using GestionVentas.BLL;

namespace GestionVentas.Registros
{
    public partial class rPagos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FechaTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void LlenarClase(Pagos p)
        {

            p.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            p.VendedorId = Utilidades.TOINT(VendedorIdTextBox.Text);
            p.Concepto = ConceptoTextBox.Text;
            p.Monto = Utilidades.TOINT(MontoTextBox.Text);


        }

        public void Limpiar()
        {
            IdTextBox.Text = "";
            VendedorIdTextBox.Text = "";
            ConceptoTextBox.Text = "";
            MontoTextBox.Text = "";

        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VendedorIdTextBox.Text == "" || ConceptoTextBox.Text == "" || MontoTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar Todos los Campos');</script>");
            }
            else
            {
                Entidades.Pagos p = new Entidades.Pagos();
                LlenarClase(p);
                PagosBLL.Insertar(p);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
                Limpiar();
            }
            

        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        public void BuscarPagos(Entidades.Pagos p)
        {
            if (PagosBLL.Buscar(String(IdTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {

                VendedorIdTextBox.Text = Convert.ToString(p.VendedorId);
                ConceptoTextBox.Text = p.Concepto;
                p.Fecha = Convert.ToDateTime(FechaTextBox.Text);
                MontoTextBox.Text = Convert.ToString(p.Monto);


            }
        }
        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes llenar el campo Id para realizar la busqueda!');</script>");
            }
            else
            {
                BuscarPagos(PagosBLL.Buscar(String(IdTextBox.Text)));
            }
        }

        protected void AnularButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el Campo Id');</script>");
            }
            else
            {
                if (PagosBLL.Buscar(String(IdTextBox.Text)) == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe ');</script>");
                }
                else
                {
                    PagosBLL.Eliminar(String(IdTextBox.Text));
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
                }

            }
        }
    }
}