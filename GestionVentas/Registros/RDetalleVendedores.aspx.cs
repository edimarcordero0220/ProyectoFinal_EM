using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionVentas.Entidades;
using System.Data;

namespace GestionVentas.Registros
{
    public partial class RDetalleVendedores : System.Web.UI.Page
    {
        System.Data.DataTable table;
        System.Data.DataRow row;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                LLenarComboCategoria();

            }

        }

        public void LLenarComboCategoria()
        {
            categoriaDropDownList1.DataSource = BLL.CategoriasBLL.GetListTodo();
            categoriaDropDownList1.DataTextField = "Nombre";
            categoriaDropDownList1.DataValueField = "CategoriaId";
            categoriaDropDownList1.DataBind();

        }





        protected void BuscarButton_Click(object sender, EventArgs e)
    {

    }
}}
