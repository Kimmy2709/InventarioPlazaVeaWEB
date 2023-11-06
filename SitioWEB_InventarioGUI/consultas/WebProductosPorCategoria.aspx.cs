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
    public partial class WebProductosPorCategoria : System.Web.UI.Page
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
                    grvCategoriaProducto.PageIndexChanging += grvCategoriaProducto_PageIndexChanging; // Suscribir el controlador de eventos al GridView
                    CargarCategoria(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        private void CargarCategoria(String strCodArea, String strCodSec, String strCodLin, String strCodFam, String strCodSubfam)
        {
            cboArea.DataSource = objCategoriaBL.Producto_Area();
            cboArea.DataValueField = "Cod_area";
            cboArea.DataTextField = "Dscp_area";
            cboArea.DataBind();
            cboArea.SelectedValue = strCodArea;

            cboSeccion.DataSource = objCategoriaBL.Producto_SeccionArea(strCodArea);
            cboSeccion.DataValueField = "Cod_sec";
            cboSeccion.DataTextField = "Dscp_sec";
            cboSeccion.DataBind();
            if (string.IsNullOrEmpty(strCodSec))
            {
                cboSeccion.SelectedIndex = -1; // Establecer el valor como nulo
            }
            else if (cboSeccion.Items.FindByValue(strCodSec) != null)
            {
                cboSeccion.SelectedValue = strCodSec;
            }

            cboLinea.DataSource = objCategoriaBL.Producto_LineaSeccionArea(strCodArea, strCodSec);
            cboLinea.DataValueField = "Cod_lin";
            cboLinea.DataTextField = "Dscp_lin";
            cboLinea.DataBind();
            if (string.IsNullOrEmpty(strCodLin))
            {
                cboLinea.SelectedIndex = -1; // Establecer el valor como nulo
            }
            else if (cboLinea.Items.FindByValue(strCodLin) != null)
            {
                cboLinea.SelectedValue = strCodLin;
            }

            cboFamilia.DataSource = objCategoriaBL.Producto_FamiliaLineaSeccionArea(strCodArea, strCodSec, strCodLin);
            cboFamilia.DataValueField = "Cod_fam";
            cboFamilia.DataTextField = "Dscp_fam";
            cboFamilia.DataBind();
            if (string.IsNullOrEmpty(strCodFam))
            {
                cboFamilia.SelectedIndex = -1; // Establecer el valor como nulo
            }
            else if (cboFamilia.Items.FindByValue(strCodFam) != null)
            {
                cboFamilia.SelectedValue = strCodFam;
            }

            cboSubFamilia.DataSource = objCategoriaBL.Producto_SubFamiliafamiliaLineaSeccionArea(strCodArea, strCodSec, strCodLin, strCodFam);
            cboSubFamilia.DataValueField = "Cod_sub";
            cboSubFamilia.DataTextField = "Dscp_sub";
            cboSubFamilia.DataBind();
            if (string.IsNullOrEmpty(strCodSubfam))
            {
                cboSubFamilia.SelectedIndex = -1; // Establecer el valor como nulo
            }
            else if (cboSubFamilia.Items.FindByValue(strCodSubfam) != null)
            {
                cboSubFamilia.SelectedValue = strCodSubfam;
            }
        }

        protected void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), string.Empty, string.Empty, string.Empty, string.Empty);
        }

        protected void cboSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), cboSeccion.SelectedValue.ToString(), string.Empty, string.Empty, string.Empty);
        }

        protected void cboLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), cboSeccion.SelectedValue.ToString(), cboLinea.SelectedValue.ToString(), string.Empty, string.Empty);
        }

        protected void cboFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), cboSeccion.SelectedValue.ToString(), cboLinea.SelectedValue.ToString(), cboFamilia.SelectedValue.ToString(), string.Empty);
        }

        private void CargarDatos()
        {
            string strArea = string.IsNullOrEmpty(cboArea.SelectedValue) ? null : cboArea.SelectedValue.ToString();
            string strSeccion = string.IsNullOrEmpty(cboSeccion.SelectedValue) ? null : cboSeccion.SelectedValue.ToString();
            string strLinea = string.IsNullOrEmpty(cboLinea.SelectedValue) ? null : cboLinea.SelectedValue.ToString();
            string strFamilia = string.IsNullOrEmpty(cboFamilia.SelectedValue) ? null : cboFamilia.SelectedValue.ToString();
            string strSubFam = string.IsNullOrEmpty(cboSubFamilia.SelectedValue) ? null : cboSubFamilia.SelectedValue.ToString();

            DataTable productos = objProductoBL.ConsultarProductoCategoria(strArea, strSeccion, strLinea, strFamilia, strSubFam);

            grvCategoriaProducto.DataSource = productos;
            grvCategoriaProducto.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void grvCategoriaProducto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvCategoriaProducto.PageIndex = e.NewPageIndex;
            CargarDatos();
        }
    }
}