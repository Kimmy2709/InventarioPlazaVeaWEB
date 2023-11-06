using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyInventario_ADO
{
    public class CategoriaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

       public DataTable Producto_Area()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Producto_Area";
                cmd.Parameters.Clear();
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Dscp_area");
                return dts.Tables["Dscp_area"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Producto_SeccionArea(String strCodArea)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Producto_SeccionArea";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_area", strCodArea);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Dscp_sec");
                return dts.Tables["Dscp_sec"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Producto_LineaSeccionArea(String strCodArea, String strCodSec)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Producto_LineaSeccionArea";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_area", strCodArea);
                cmd.Parameters.AddWithValue("@Cod_sec", strCodSec);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Dscp_lin");
                return dts.Tables["Dscp_lin"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Producto_FamiliaLineaSeccionArea(String strCodArea, String strCodSec, String strCodLin)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Producto_FamiliaLineaSeccionArea";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_area", strCodArea);
                cmd.Parameters.AddWithValue("@Cod_sec", strCodSec);
                cmd.Parameters.AddWithValue("@Cod_lin", strCodLin);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Dscp_fam");
                return dts.Tables["Dscp_fam"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Producto_SubFamiliafamiliaLineaSeccionArea(String strCodArea, String strCodSec, String strCodLin, String strCodFam)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Producto_SubFamiliafamiliaLineaSeccionArea";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_area", strCodArea);
                cmd.Parameters.AddWithValue("@Cod_sec", strCodSec);
                cmd.Parameters.AddWithValue("@Cod_lin", strCodLin);
                cmd.Parameters.AddWithValue("@Cod_fam", strCodFam);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Dscp_sub");
                return dts.Tables["Dscp_sub"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }



    }
   
}
