using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyInventario_BL;

namespace SitioWEB_InventarioGUI.consultas
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProveedorBL objProveedoresBL = new ProveedorBL();

                if (Page.IsPostBack == false)
                {
                    grvProveedores.DataSource = objProveedoresBL.ProveedoresPorDistrito();
                    grvProveedores.DataBind();

                    //para graficar
                    //convertimos el datatable a datareader para que el grafico se pueda construir

                    DataTableReader dtReaderTotales = objProveedoresBL.ProveedoresPorDistrito().CreateDataReader();
                    DataTableReader dtReaderCantidades = objProveedoresBL.ProveedoresPorDistrito().CreateDataReader();

                    //GrafCantidades
                    grvProv.Series.Add("Cantidades");
                    grvProv.Series["Cantidades"].Points.DataBindXY(dtReaderCantidades, "Distrito", dtReaderCantidades, "Cantidad");
                    grvProv.Series["Cantidades"].IsValueShownAsLabel = true;//muestra etiquetas con valores de cada cant.
                    grvProv.Series["Cantidades"].LabelFormat = "n"; //Formato numérico

                    //    //GrafTotales
                    //    grafTotales.Series.Add("Totales");
                    //    grafTotales.Series["Totales"].Points.DataBindXY(dtReaderTotales, "Año", dtReaderTotales, "TotalAnual");
                    //    grafTotales.Series["Totales"].IsValueShownAsLabel = true;//muestra etiquetas con valores de cada cant.
                    //    grafTotales.Series["Totales"].LabelFormat = "c"; //Formato monetario
                    //
                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = "Error" + ex.Message;
            }
        }
    }
}