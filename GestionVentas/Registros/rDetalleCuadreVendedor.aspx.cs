using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionVentas.Registros
{
    public partial class DetalleCuadreVendedor : System.Web.UI.Page
    {
        DetalleCuadreVendedor cuadre = new DetalleCuadreVendedor();
        System.Data.DataTable table;
        System.Data.DataRow row;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                LLenarComboGastos();
                LLenarComboPagos();
                LlenarComboSubsidios();




            }
            if (IsPostBack == false)
            {

                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Vendido"), new DataColumn("Gastos"), new DataColumn("Pagos"), new DataColumn("Comision"), new DataColumn("Ganancia"), new DataColumn("Pendiente"), new DataColumn("Monto") });
                ViewState["Detalle"] = dt;


            }
        }
        public void LLenarComboGastos()
        {
            GastosDropDownList.DataSource = BLL.GastosBLL.GetListTodo();
            GastosDropDownList.DataTextField = "Concepto";
            GastosDropDownList.DataValueField = "GastoId";
            GastosDropDownList.DataBind();

        }
        public void LLenarComboPagos()
        {
            PagosDropDownList2.DataSource = BLL.PagosBLL.GetListTodo();
            PagosDropDownList2.DataTextField = "Concepto";
            PagosDropDownList2.DataValueField = "PagoId";
            PagosDropDownList2.DataBind();

        }
        public void LlenarComboSubsidios()
        {
            SubcidioDropDownList1.DataSource = BLL.SubsidiosBLL.GetListTodo();
            SubcidioDropDownList1.DataTextField = "Concepto";
            SubcidioDropDownList1.DataValueField = "SubcidioId";
            SubcidioDropDownList1.DataBind();

        }
        public int ValidarIdEntero(string IdTextBox)
        {
            int Id = 0;

            if (IdTextBox.Length > 0)
            {
                bool result = Int32.TryParse(IdTextBox, out Id);
            }

            return Id;
        }

        public void LlenarClase(Entidades.CuadresVendedorDetalles d)
        {

            d.Vendido = Utilidades.TOINT(VendidoTextBox.Text);
            d.Subsidios = ValidarIdEntero(SubcidioDropDownList1.SelectedValue);
            d.Pagos = ValidarIdEntero(PagosDropDownList2.SelectedValue);
            d.Gastos = ValidarIdEntero(GastosDropDownList.SelectedValue);
            d.Monto = Utilidades.TOINT(MontoTextBox.Text);
            d.Comision = Utilidades.TOINT(ComisionTextBox.Text);
            d.Pendiente = Utilidades.TOINT(PendienteTextBox.Text);
            d.Ganancia = Utilidades.TOINT(GananciaTextBox.Text);


        }
        protected void BindGrid()
        {
            DetalleCuadreGridView.DataSource = (DataTable)ViewState["Detalle"];
            DetalleCuadreGridView.DataBind();

        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            if (VendidoTextBox.Text == "" || ComisionTextBox.Text == "" || GananciaTextBox.Text == "" || PendienteTextBox.Text =="" || MontoTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar los Campos identificados con (*)');</script>");
            }
            else
            {
                DataTable dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(VendidoTextBox.Text, GastosDropDownList.Text, PagosDropDownList2.Text, ComisionTextBox.Text, GastosDropDownList.Text, PendienteTextBox.Text, MontoTextBox.Text);
                ViewState["Detalle"] = dt;

                this.BindGrid();

            }


        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Entidades.CuadresVendedorDetalles detalle = new Entidades.CuadresVendedorDetalles();
            LlenarClase(detalle);
            BLL.DetalleCuadreBLL.Insertar(detalle);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
           
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
           
                



            
        }
    }
}