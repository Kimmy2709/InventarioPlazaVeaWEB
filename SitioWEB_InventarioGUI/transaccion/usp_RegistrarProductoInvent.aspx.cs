using ProyInventario_BE;
using ProyInventario_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_InventarioGUI.transaccion
{
    public partial class usp_RegistrarProductoInvent : System.Web.UI.Page
    {


        DataTable detalles;
        DataColumn Ccod_tip_invent;
        DataColumn Cdscp_tip_invent;
        DataColumn Ccantidad;


        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        CategoriaBL objCategoriaBL = new CategoriaBL();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    CrearTabla();
                    CargarCategoria(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                    CargarUnidadMedida();
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }
        private void CargarUnidadMedida()
        {
            DataTable dtMedidas = new DataTable();
            DataRow drFila;

            dtMedidas = objUnidadMedidaBL.ListarUM();
            drFila = dtMedidas.NewRow();
            drFila["Cod_uni"] = 0;
            drFila["Dscp_uni"] = "--Seleccione una opcion--";
            dtMedidas.Rows.InsertAt(drFila, 0);
            cboUniMedida.DataSource = dtMedidas;
            cboUniMedida.DataValueField = "Cod_uni";
            cboUniMedida.DataTextField = "Dscp_uni";
            cboUniMedida.DataBind();



        }
        private void CrearTabla()
        {
            detalles = new DataTable("detalles");
            //Creando las columnas para la tabla temporal de  detalle de compra
            //Columna DescripcionTipoInvent
            DataColumn Ccod_tip_invent = new DataColumn("Cod_tip_invent");
            Ccod_tip_invent.DataType = Type.GetType("System.String");
            detalles.Columns.Add(Ccod_tip_invent);
            //Columna DescripcionTipoInvent
            DataColumn Cdscp_tip_invent = new DataColumn("Dscp_tip_invent");
            Cdscp_tip_invent.DataType = Type.GetType("System.String");
            detalles.Columns.Add(Cdscp_tip_invent);
              //Columna Cantidad
            DataColumn Ccantidad = new DataColumn("Cantidad");
            Ccantidad.DataType = Type.GetType("System.String");
            detalles.Columns.Add(Ccantidad);
            //definimos la PK
            detalles.PrimaryKey = new DataColumn[] { detalles.Columns["Cod_tip_invent"] };
            grDetalles.DataSource = detalles;
            grDetalles.DataBind();
            Session["Detalles"] = detalles;

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
        private void LlenarCombo()
        {
            DataTable dtCombos = new DataTable();
            DataRow drFila;

            dtCombos = objProductoBL.CantidadProductosPorTipoInventario();
            drFila = dtCombos.NewRow();
            drFila["Cod_tip_invent"] = "X";
            drFila["Dscp_tip_invent"] = "--Todos--";
            dtCombos.Rows.InsertAt(drFila, 0);
            cboProducto.DataSource = dtCombos;
            cboProducto.DataTextField = "Dscp_tip_invent";
            cboProducto.DataValueField = "Cod_tip_invent";
            cboProducto.DataBind();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            PopDetalle.Show();
            LlenarCombo();
        }
        protected void btnGrabarDetalle_Click(object sender, EventArgs e)
        {

            try
            {
                // Validamos el detalle antes de registrarlo en memoria
                if (cboProducto.SelectedValue == "X")
                {
                    throw new Exception("Debe seleccionar un Tipo de Inventario");
                }
                if (txtCanPed.Text == "")
                {
                    throw new Exception("Debe ingresar una cantidad");
                }
                // Si todo esta OK casteamos la variable de sesion "Detalles" a DataTable
                detalles = (DataTable)Session["Detalles"];
                //Creamos una fila y la instanciamos como fila de mitb
                DataRow dr;
                dr = detalles.NewRow();
                //Llenamos los campos con lo ingresado en el Popup de detalle
                dr["Cod_tip_invent"] = cboProducto.SelectedValue.ToString();
                dr["Dscp_tip_invent"] = cboProducto.SelectedItem.ToString();
                dr["Cantidad"] = Convert.ToInt16(txtCanPed.Text);
                //Agregamos la fila a la coleccion de filas de detalle
                detalles.Rows.Add(dr);

                lblMensajePopup.Text = "Registraste exitosamente el detalle ";
                PopMensaje.Show();
            }
            catch (Exception ex)
            {
                lblMensajeDetalle.Text = "Error: " + ex.Message;
                PopDetalle.Show();
            }

        }

        protected void btnVerGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Trim() != String.Empty)
                {
                    if (Convert.ToInt32(txtPrecio.Text) > 0)
                    {
                        if (!string.IsNullOrEmpty(txtStockAct.Text) && !string.IsNullOrEmpty(txtStockMin.Text))
                        {
                            if (Convert.ToInt32(txtStockAct.Text) > Convert.ToInt32(txtStockMin.Text))
                            {
                                if (cboUniMedida.SelectedValue !="0")
                                {
                                    if (string.IsNullOrEmpty(txtCanPed.Text))
                                    {
                                        throw new Exception("No puede registrar un producto sin detalles.");      
                                     }
                                    else
                                    {
                                        objProductoBE.Dscp_pro = txtDescripcion.Text.Trim();
                                        objProductoBE.Pre_pro = Convert.ToSingle(txtPrecio.Text.Trim());
                                        objProductoBE.Stk_act = Convert.ToInt16(txtStockAct.Text.Trim());
                                        objProductoBE.Stk_min = Convert.ToInt16(txtStockMin.Text.Trim());
                                        if (chkEstado.Checked == true)
                                        {
                                            objProductoBE.Estd_pro = 1;
                                        }
                                        else
                                        {
                                            objProductoBE.Estd_pro = 0;
                                        }
                                        objProductoBE.Cod_area = cboArea.SelectedValue.ToString();
                                        objProductoBE.Cod_sec = cboSeccion.SelectedValue.ToString();
                                        objProductoBE.Cod_lin = cboLinea.SelectedValue.ToString();
                                        objProductoBE.Cod_fam = cboFamilia.SelectedValue.ToString();
                                        objProductoBE.Cod_sub = cboSubFamilia.SelectedValue.ToString();
                                        objProductoBE.Cod_uni = cboUniMedida.SelectedValue.ToString();
                                        objProductoBE.Usu_Registro = clsCredenciales.Usuario;

                                        detalles = (DataTable)Session["Detalles"];
                                        objProductoBE.DetallesProducto = detalles;
                                        String strNumOC = objProductoBL.RegistrarProductoInvent(objProductoBE);
                                        limpiarDatos();
                                        lblMensajePopup.Text = "Registraste exitosamente el Producto ";
                                        PopMensaje.Show();
                                        llenarGrilla();
                                    }

                                }
                                else
                                {
                                    throw new Exception("Seleccione una Unidad de Medida");
                                }
                            }                          
                            else
                            {
                                throw new Exception("El Stock Actual no puede ser menor que el Stock Mínimo");
                            }
                        }
                        else
                        {
                            throw new Exception("Ingrese el Stock Actual y el Stock Mínimo");
                        }
                    }
                    else
                    {
                        throw new Exception("El valor ingresado en precio no puede ser negativo");
                    }
                }
                else
                {
                    throw new Exception("Agregar descripción");
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }
        private void limpiarDatos()
        {
            txtDescripcion.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtStockAct.Text = String.Empty;
            txtStockMin.Text = String.Empty;
            txtCanPed.Text = String.Empty;
            chkEstado.Checked = false;
            cboArea.SelectedIndex = -1;
            cboSeccion.Items.Clear();
            cboLinea.Items.Clear();
            cboFamilia.Items.Clear();
            cboSubFamilia.Items.Clear();
            cboUniMedida.SelectedIndex = -1;
            // Limpiar la tabla detalles
            detalles.Rows.Clear();
            Session["Detalles"] = detalles;

        }
       
        private void llenarGrilla()
        {
            DataTable productos = objProductoBL.ListarRegistroDetalleProducto();

            grDetalles.DataSource = productos;
            grDetalles.DataBind();
        }
    }
}