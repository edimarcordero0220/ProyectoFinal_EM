using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionVentas.Reportes
{
    public partial class GastoReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            GastosReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            GastosReportViewer.Reset();

            GastosReportViewer.LocalReport.ReportPath = Server.MapPath(@"Gastos.rdlc");
            GastosReportViewer.LocalReport.DataSources.Clear();



            GastosReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("GastosDataSet", GestionVentas.Consultas.cGastos
              .Listas));

            GastosReportViewer.LocalReport.Refresh();
        }
    }
}