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
    public partial class rCuadreVendedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
        }
        public void LlenarClase(CuadreVendedor cv)
        {

            cv.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            cv.VendedorId = Utilidades.TOINT(VendedorIdTextBox.Text);
            cv.Concepto = ConceptoTextBox.Text;
            cv.Monto = Utilidades.TOINT(MontoTextBox.Text);


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
                Entidades.CuadreVendedor cv = new Entidades.CuadreVendedor();
                LlenarClase(cv);
                CuadreBLL.Insertar(cv);
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
        public void BuscarCuadre(Entidades.CuadreVendedor cv)
        {
            if (CuadreBLL.Buscar(String(IdTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {

                VendedorIdTextBox.Text = Convert.ToString(cv.VendedorId);
                ConceptoTextBox.Text = cv.Concepto;
                cv.Fecha = Convert.ToDateTime(FechaTextBox.Text);
                MontoTextBox.Text = Convert.ToString(cv.Monto);


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
                BuscarCuadre(CuadreBLL.Buscar(String(IdTextBox.Text)));
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
                if (CuadreBLL.Buscar(String(IdTextBox.Text)) == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe ');</script>");
                }
                else
                {
                    CuadreBLL.Eliminar(String(IdTextBox.Text));
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
                }

            }
        }
    }
}