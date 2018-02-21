using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.BLL;
using GestionVentas.Entidades;


namespace GestionVentas.Consultas
{
    public partial class CVendedores : System.Web.UI.Page
    {
        public static List<Vendedores> Listas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listas = VendedoresBLL.ListarTodo();

                GridViewConsultaVendedores.DataSource = Listas;
                GridViewConsultaVendedores.DataBind();
            }

        }
        private void BuscarSelecCombo()
        {
            Listas = null;

            if (DropDownListFiltro.SelectedIndex == 0)
            {
                Listas = VendedoresBLL.ListarTodo();

            }
            else if (DropDownListFiltro.SelectedIndex == 1)
            {
                if (TextBoxFiltro.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(TextBoxFiltro.Text);
                    Listas = VendedoresBLL.GetList(a => a.VendedoresId == Busqueda);
                    GridViewConsultaVendedores.DataSource = Listas;
                    GridViewConsultaVendedores.DataBind();
                }
            }
            else if (DropDownListFiltro.SelectedIndex == 2)
            {
                if (TextBoxFiltro.Text == "")
                {
                    base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debe de Insertar la descripcion');</script>");
                }
                else
                {
                    int Busqueda = Utilidades.TOINT(TextBoxFiltro.Text);
                    Listas = VendedoresBLL.GetList(a => a.VendedoresId == Busqueda);
                    GridViewConsultaVendedores.DataSource = Listas;
                    GridViewConsultaVendedores.DataBind();
                }
            }

            GridViewConsultaVendedores.DataSource = Listas;
            GridViewConsultaVendedores.DataBind();
        }
        private bool ValidarBuscar()
        {
            if (PagosBLL.Buscar(String(TextBoxFiltro.Text)) == null)
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
            if (TextBoxFiltro.Text == "")
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