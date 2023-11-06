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
    public class EmpleadoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType =CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";
                cmd.Parameters.Clear();
                //Agregamos parametros 
                cmd.Parameters.AddWithValue("@vNom", objEmpleadoBE.Nom_emple);
                cmd.Parameters.AddWithValue("@vApe", objEmpleadoBE.Ape_emple);
                cmd.Parameters.AddWithValue("@vDni", objEmpleadoBE.Dni_emple);
                cmd.Parameters.AddWithValue("@vDir", objEmpleadoBE.Dir_emple);
                cmd.Parameters.AddWithValue("@vTelf", objEmpleadoBE.Telf_emple);
                cmd.Parameters.AddWithValue("@vSue", objEmpleadoBE.Sue_emple);
                cmd.Parameters.AddWithValue("@vEst", objEmpleadoBE.Estd_emple);
                cmd.Parameters.AddWithValue("@vLogin_Usuario", objEmpleadoBE.Login_Usuario);
                cmd.Parameters.AddWithValue("@vTip_Usuario", objEmpleadoBE.Tipo_Usuario);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objEmpleadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_registro", objEmpleadoBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@Foto", objEmpleadoBE.Foto_emple);



                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;


            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;


            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vCod", objEmpleadoBE.Cod_emple);
                cmd.Parameters.AddWithValue("@vNom", objEmpleadoBE.Nom_emple);
                cmd.Parameters.AddWithValue("@vApe", objEmpleadoBE.Ape_emple);
                cmd.Parameters.AddWithValue("@vDni", objEmpleadoBE.Dni_emple);
                cmd.Parameters.AddWithValue("@vDir", objEmpleadoBE.Dir_emple);
                cmd.Parameters.AddWithValue("@vTelf", objEmpleadoBE.Telf_emple);
                cmd.Parameters.AddWithValue("@vSue", objEmpleadoBE.Sue_emple);
                cmd.Parameters.AddWithValue("@vEst", objEmpleadoBE.Estd_emple);
                cmd.Parameters.AddWithValue("@vLogin_Usuario", objEmpleadoBE.Login_Usuario);
                cmd.Parameters.AddWithValue("@vTip_Usuario", objEmpleadoBE.Tipo_Usuario);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objEmpleadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objEmpleadoBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@Foto", objEmpleadoBE.Foto_emple);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
        public Boolean EliminarEmpleado(String strCodigo)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vCod", strCodigo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {

            try
            {

                EmpleadoBE objEmpleadoBE = new EmpleadoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";
                cmd.Parameters.Clear();
                //Agregamos parametros 
                //Codifique

                cmd.Parameters.AddWithValue("@vCod", strCodigo);

                //Abrimos conexion y ejecutamos
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.Cod_emple = dtr["Cod_emple"].ToString();
                    objEmpleadoBE.Ape_emple = dtr["Ape_emple"].ToString();
                    objEmpleadoBE.Nom_emple = dtr["Nom_emple"].ToString();
                    objEmpleadoBE.Dni_emple = dtr["Dni_emple"].ToString();
                    objEmpleadoBE.Dir_emple = dtr["Dir_emple"].ToString();
                    objEmpleadoBE.Telf_emple = dtr["Telf_emple"].ToString();
                    objEmpleadoBE.Sue_emple = Convert.ToSingle(dtr["Sue_emple"].ToString());
                    objEmpleadoBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objEmpleadoBE.Departamento = dtr["Departamento"].ToString();
                    objEmpleadoBE.Provincia = dtr["Provincia"].ToString();
                    objEmpleadoBE.Distrito = dtr["Distrito"].ToString();
                    objEmpleadoBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objEmpleadoBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objEmpleadoBE.Tipo_Usuario = dtr["Tipo_Usuario"].ToString();
                    objEmpleadoBE.TipoUsuario = dtr["TipoUsuario"].ToString();
                    objEmpleadoBE.Usu_Registro = dtr["Usu_Registro"].ToString();
                    objEmpleadoBE.Usu_Ult_Mod = dtr["Usu_Ult_Mod"].ToString();
                    objEmpleadoBE.Estd_emple = Convert.ToInt16(dtr["Estd_emple"].ToString());
                    objEmpleadoBE.Estado = dtr["Estado"].ToString();
                    objEmpleadoBE.Foto_emple = (Byte[])(dtr["Foto_emple"]);
                }
                dtr.Close();
                return objEmpleadoBE;

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
        public DataTable ListarEmpleado()
        {


            try
            {

                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleado");
                return dts.Tables["Empleado"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }


}
