//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código. 
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace SitioWEB_InventarioGUI.transaccion
{


    public partial class usp_RegistrarProductoInvent
    {

        /// <summary>
        /// Control ScriptManager1.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.ScriptManager ScriptManager1;

        /// <summary>
        /// Control UpdatePanel1.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.UpdatePanel UpdatePanel1;

        /// <summary>
        /// Control txtDescripcion.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.TextBox txtDescripcion;

        /// <summary>
        /// Control txtPrecio.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.TextBox txtPrecio;

        /// <summary>
        /// Control txtStockAct.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.TextBox txtStockAct;

        /// <summary>
        /// Control txtStockMin.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.TextBox txtStockMin;

        /// <summary>
        /// Control chkEstado.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.CheckBox chkEstado;

        /// <summary>
        /// Control cboArea.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.DropDownList cboArea;

        /// <summary>
        /// Control cboUniMedida.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.DropDownList cboUniMedida;

        /// <summary>
        /// Control cboSeccion.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.DropDownList cboSeccion;

        /// <summary>
        /// Control cboLinea.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.DropDownList cboLinea;

        /// <summary>
        /// Control lblTipInvent.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblTipInvent;

        /// <summary>
        /// Control cboFamilia.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.DropDownList cboFamilia;

        /// <summary>
        /// Control lblCantInv.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblCantInv;

        /// <summary>
        /// Control cboSubFamilia.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.DropDownList cboSubFamilia;

        /// <summary>
        /// Control btnAgregar.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnAgregar;

        /// <summary>
        /// Control btnVerGrabar.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnVerGrabar;

        /// <summary>
        /// Control grDetalles.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.GridView grDetalles;

        /// <summary>
        /// Control lnkDetalle.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.LinkButton lnkDetalle;

        /// <summary>
        /// Control PanelDetalle.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Panel PanelDetalle;

        /// <summary>
        /// Control cboProducto.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.DropDownList cboProducto;

        /// <summary>
        /// Control txtCanPed.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.TextBox txtCanPed;

        /// <summary>
        /// Control txtCanPed_MaskedEditExtender.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::AjaxControlToolkit.MaskedEditExtender txtCanPed_MaskedEditExtender;

        /// <summary>
        /// Control lblMensajeDetalle.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblMensajeDetalle;

        /// <summary>
        /// Control btnGrabarDetalle.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnGrabarDetalle;

        /// <summary>
        /// Control btnCancelarDetalle.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnCancelarDetalle;

        /// <summary>
        /// Control PopDetalle.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::AjaxControlToolkit.ModalPopupExtender PopDetalle;

        /// <summary>
        /// Control lnkMensaje.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.LinkButton lnkMensaje;

        /// <summary>
        /// Control pnlMensaje.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Panel pnlMensaje;

        /// <summary>
        /// Control lblTitulo.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblTitulo;

        /// <summary>
        /// Control lblMensajePopup.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblMensajePopup;

        /// <summary>
        /// Control btnAceptar.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnAceptar;

        /// <summary>
        /// Control PopMensaje.
        /// </summary>
        /// <remarks>
        /// Campo generado automáticamente.
        /// Para modificarlo, mueva la declaración del campo del archivo del diseñador al archivo de código subyacente.
        /// </remarks>
        protected global::AjaxControlToolkit.ModalPopupExtender PopMensaje;
    }
}
