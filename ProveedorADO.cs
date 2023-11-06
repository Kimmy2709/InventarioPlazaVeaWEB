using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyInventario_BE;

namespace ProyInventario_ADO
{
    public class ProveedorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarProveedor()
        {

            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedores";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Proveedores");

                return dts.Tables["Proveedores"];

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public ProveedorBE ConsultarProveedor(String strCodigo)
        {
            try
            {
                //Codifique
                ProveedorBE objProveedorBE = new ProveedorBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pcod", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objProveedorBE.Cod_prov = dtr["cod_prov"].ToString();
                    objProveedorBE.Raz_soc_prov = dtr["raz_soc_prov"].ToString();
                    objProveedorBE.Dir_prov = dtr["dir_prov"].ToString();
                    objProveedorBE.Telf_prov = dtr["telf_prov"].ToString();
                    objProveedorBE.Email_prov = dtr["Email_prov"].ToString();
                    objProveedorBE.Ruc_prov = dtr["ruc_prov"].ToString();
                    objProveedorBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objProveedorBE.departamento = dtr["departamento"].ToString();
                    objProveedorBE.provincia = dtr["provincia"].ToString();
                    objProveedorBE.distrito = dtr["distrito"].ToString();
                    objProveedorBE.Estd_prov= Convert.ToInt16(dtr["estd_prov"]);
                }
                dtr.Close();
                return objProveedorBE;
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

        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@praz", objProveedorBE.Raz_soc_prov);
                cmd.Parameters.AddWithValue("@pruc", objProveedorBE.Ruc_prov);
                cmd.Parameters.AddWithValue("@pdir", objProveedorBE.Dir_prov);
                cmd.Parameters.AddWithValue("@ptelf", objProveedorBE.Telf_prov);
                cmd.Parameters.AddWithValue("@pemail", objProveedorBE.Email_prov);
                cmd.Parameters.AddWithValue("@pEst_prov", objProveedorBE.Estd_prov);
                cmd.Parameters.AddWithValue("@pId_Ubigeo", objProveedorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@pUsu_Registro", objProveedorBE.Usu_Registro);
               

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
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pcod", objProveedorBE.Cod_prov);
                cmd.Parameters.AddWithValue("@praz", objProveedorBE.Raz_soc_prov);
                cmd.Parameters.AddWithValue("@pruc", objProveedorBE.Ruc_prov);
                cmd.Parameters.AddWithValue("@pdir", objProveedorBE.Dir_prov);
                cmd.Parameters.AddWithValue("@ptelf", objProveedorBE.Telf_prov);
                cmd.Parameters.AddWithValue("@pemail", objProveedorBE.Email_prov);
                cmd.Parameters.AddWithValue("@pEst_prov", objProveedorBE.Estd_prov);
                cmd.Parameters.AddWithValue("@pId_Ubigeo", objProveedorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@pUsu_Ult_Mod", objProveedorBE.Usu_Ult_Mod);

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

        public Boolean EliminarProveedor(String strCodigo)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pcod", strCodigo);

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

        public DataTable ProveedorPorDistrito()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ProveedoresPorDistrito";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                ada.Fill(dataset, "ProveedoresDistrito");
                return dataset.Tables["ProveedoresDistrito"];
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
