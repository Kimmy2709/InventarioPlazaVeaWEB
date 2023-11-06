using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyInventario_BE;

namespace ProyInventario_ADO
{
    public class UsuarioADO
    {
        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public UsuarioBE ConsultarUsuario(String strCodigo)
        {
            try
            {
                UsuarioBE objUsuarioBE = new UsuarioBE();
                cnx.ConnectionString = Miconexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vlogin_usuario", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioBE.Est_Usuario = Convert.ToInt16(dtr["Est_Usuario"]);
                    objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_Registro"]);
                    objUsuarioBE.Usu_Registro = dtr["Usu_Registro"].ToString();


                }
                return objUsuarioBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
    }
    
}
