using ProyInventario_BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_ADO
{
    public class TiendaADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        // Metodos de mantenimiento
        public Boolean InsertarTienda(TiendaBE objTiendaBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarTienda";
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vnom", objTiendaBE.Nom_tiend);
                cmd.Parameters.AddWithValue("@vdir", objTiendaBE.Dir_tiend);
                cmd.Parameters.AddWithValue("@vtel", objTiendaBE.Telf_tiend);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objTiendaBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objTiendaBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vEst_tiend", objTiendaBE.Estd_tiend);

                //Ejecutamos...
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
        public Boolean ActualizarTienda(TiendaBE objTiendaBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarTienda";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", objTiendaBE.Cod_tiend);
                cmd.Parameters.AddWithValue("@vnom", objTiendaBE.Nom_tiend);
                cmd.Parameters.AddWithValue("@vdir", objTiendaBE.Dir_tiend);
                cmd.Parameters.AddWithValue("@vtel", objTiendaBE.Telf_tiend);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objTiendaBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objTiendaBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vEst_tiend", objTiendaBE.Estd_tiend);

                //Ejecutamos...
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

        public Boolean EliminarTienda(String strcod)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarTienda";
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strcod);

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

        public TiendaBE ConsultarTienda(String strCod)
        {
            try
            {
                TiendaBE objTiendaBE = new TiendaBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarTienda";
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCod);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();

                    objTiendaBE.Cod_tiend = Convert.ToInt16(dtr["Cod_tiend"]);
                    objTiendaBE.Nom_tiend = dtr["Nom_tiend"].ToString();
                    objTiendaBE.Dir_tiend = dtr["Dir_tiend"].ToString();
                    objTiendaBE.Telf_tiend = dtr["Telf_tiend"].ToString();
                    objTiendaBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objTiendaBE.Estd_tiend = Convert.ToInt16(dtr["estd_tiend"]);

                    dtr.Close();
                }
                return objTiendaBE;
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

        public DataTable ListarTienda()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarTienda";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Tiendas");
                return dts.Tables["Tiendas"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable TiendasPorDistrito()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_TiendasPorDistrito";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                ada.Fill(dataset, "TiendasDistrito");
                return dataset.Tables["TiendasDistrito"];
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
