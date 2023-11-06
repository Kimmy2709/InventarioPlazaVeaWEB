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
    public partial class WebForm1 : System.Web.UI.Page
    {
      
            ProductoBL objProductoBL = new ProductoBL();
            protected void Page_Load(object sender, EventArgs e)
            {
                try
                {
                    if (Page.IsPostBack == false)
                    {
                    grvTiendas.DataSource = objProductoBL.CantidadProductosPorTipoInventario();
                        grvTiendas.DataBind();

                        //para graficar
                        //convertimos el datatable a datareader para que el grafico se pueda construir

                        DataTableReader dtReaderTotales = objProductoBL.CantidadProductosPorTipoInventario().CreateDataReader();
                        DataTableReader dtReaderCantidades = objProductoBL.CantidadProductosPorTipoInventario().CreateDataReader();

                    //GrafCantidades
                    grvTienda.Series.Add("Cantidades");
                    grvTienda.Series["Cantidades"].Points.DataBindXY(dtReaderCantidades, "Dscp_tip_invent", dtReaderCantidades, "CantidadProductos");
                    grvTienda.Series["Cantidades"].IsValueShownAsLabel = true;//muestra etiquetas con valores de cada cant.
                    grvTienda.Series["Cantidades"].LabelFormat = "n"; //Formato numérico

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