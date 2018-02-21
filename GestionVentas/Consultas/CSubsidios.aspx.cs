using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.Entidades;
using GestionVentas.BLL;

namespace GestionVentas.Consultas
{
    public partial class CSubsidios : System.Web.UI.Page
    {
        public static List<Subsidios> Listas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listas = SubsidiosBLL.ListarTodo();

                GridViewConsultaVenta.DataSource = Listas;
                GridViewConsultaVenta.DataBind();
            }
        }
        private void BuscarSelecCombo()
        {
            Listas = null;

            if (DropDownListFiltro.SelectedIndex == 0)
            {
                Listas = SubsidiosBLL.ListarTodo();

            }
            else if (DropDownListFiltro.SelectedIndex == 1)
            {
                if (TextBoxFiltrar.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(TextBoxFiltrar.Text);
                    Listas = SubsidiosBLL.GetList(a => a.VendedorId == Busqueda);
                    GridViewConsultaVenta.DataSource = Listas;
                    GridViewConsultaVenta.DataBind();
                }
            }
            else if (DropDownListFiltro.SelectedIndex == 2)
            {
                if (TextBoxFiltrar.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(TextBoxFiltrar.Text);
                    Listas = SubsidiosBLL.GetList(p => p.VendedorId == Busqueda);
                    GridViewConsultaVenta.DataSource = Listas;
                    GridViewConsultaVenta.DataBind();
                }
            }





            GridViewConsultaVenta.DataSource = Listas;
            GridViewConsultaVenta.DataBind();
        }
        private bool ValidarBuscar()
        {
            if (PagosBLL.Buscar(String(TextBoxFiltrar.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");
                return false;

            }

            return true;


        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }


        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {

            if (TextBoxFiltrar.Text == "")
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
            }
            else
            {
                BuscarSelecCombo();
                ValidarBuscar();
            }
        }
    }
}