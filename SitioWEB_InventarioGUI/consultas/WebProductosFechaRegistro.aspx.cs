using ProyInventario_BE;
using ProyInventario_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_InventarioGUI.consultas
{
    public partial class WebProductosFechaRegistro : System.Web.UI.Page
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        CategoriaBL objCategoriaBL = new CategoriaBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    LlenarCombo();
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void LlenarCombo()
        {
            DataTable dtCombos = new DataTable();
            DataRow drFila;

            dtCombos = objProductoBL.CantidadProductosPorTipoInventario();
            drFila = dtCombos.NewRow();
            drFila["Cod_tip_invent"] = "X";
            drFila["Dscp_tip_invent"] = "--Todos--";
            dtCombos.Rows.InsertAt(drFila, 0);
            cboTipInvent.DataSource = dtCombos;
            cboTipInvent.DataTextField = "Dscp_tip_invent";
            cboTipInvent.DataValueField = "Cod_tip_invent";
            cboTipInvent.DataBind();
        }

        private void CargarDatos()
        {
            try
            {
                // Codifique
                grvProductos.DataSource = objProductoBL.ListarProductosFechaRegistro(cboTipInvent.SelectedValue.ToString(),
                                        Convert.ToDateTime(txtFecIni.Text), Convert.ToDateTime(txtFecFin.Text));
                grvProductos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void grvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvProductos.PageIndex = e.NewPageIndex;
            CargarDatos();
        }
    }
}