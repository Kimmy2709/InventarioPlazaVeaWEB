using ProyInventario_BE;
using ProyInventario_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_InventarioGUI.login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != String.Empty & txtPassword.Text.Trim() != String.Empty)
            {
                //Obtenemos los datos del usuario dado como Login
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtUsuario.Text.Trim());

                if (objUsuarioBE.Login_Usuario == null)
                {
                    lblErrorPass.Text = String.Empty;
                    lblErrorUs.Text = "Usuario no existe";
                }
                else if (objUsuarioBE.Login_Usuario == txtUsuario.Text.Trim() && objUsuarioBE.Pass_Usuario == txtPassword.Text.Trim())
                {
                    // Si son correctas mostramos el formulario MDIPrincipal
                    clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
                    Response.Redirect("https://localhost:44355/transaccion/usp_RegistrarProductoInvent.aspx");
                }

                else
                {
                    lblErrorUs.Text = String.Empty;
                    lblErrorPass.Text = "Usuario o Password incorrectos";

                }
            }
            else
            {
                lblErrorUs.Text = String.Empty;
                lblErrorPass.Text = "Usuario o Password obligatorios";
            }
        }
    }
}