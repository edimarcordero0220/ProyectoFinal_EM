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
    public partial class rCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void LlenarClase(Categorias c)
        {


            c.CategoriaId = Utilidades.TOINT(IdTextBox.Text);
            c.Nombre = NombreTextBox.Text;
            float MaximoVentasDefault = Convert.ToSingle(MaximoVentaDefaultTextBox.Text);


        }
        public void Limpiar()
        {
            IdTextBox.Text = "";
            NombreTextBox.Text = "";
            MaximoVentaDefaultTextBox.Text = "";


        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "" || MaximoVentaDefaultTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar Todos los Campos');</script>");
            }
            else
            {
                Categorias c = new Categorias();
                LlenarClase(c);
                CategoriasBLL.Guardar(c);
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

        protected void LimpiarCampos_Click(object sender, EventArgs e)
        {
            CategoriasBLL.Eliminar(String(IdTextBox.Text));
            Page.ClientScript.RegisterStartupScript(GetType(), "scripts", "<script>alert(' Se Elimino Correctamente');</script>");
        }

        protected void AnularButton_Click(object sender, EventArgs e)
        {
            IdTextBox.ReadOnly = true;
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            ImprimirButton.Attributes.Add("onclick", "return printing()");
            ClientScript.RegisterStartupScript(this.GetType(), "printOperation", "printing()", true);

        }
        public void BuscarCategorias(Categorias c)
        {
            if (CategoriasBLL.Buscar(String(IdTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {

                NombreTextBox.Text = Convert.ToString(c.Nombre);
                float MaximoVentasDefault = Convert.ToSingle(MaximoVentaDefaultTextBox.Text);


                {

                    if (IdTextBox.Text == "")
                    {
                        base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes llenar el campo Id para realizar la busqueda!');</script>");
                    }
                    else
                    {
                        BuscarCategorias(CategoriasBLL.Buscar(String(IdTextBox.Text)));
                    }
                }
            }
        }
    }
}