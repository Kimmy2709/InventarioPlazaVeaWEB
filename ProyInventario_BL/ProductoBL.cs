using ProyInventario_ADO;
using ProyInventario_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_BL
{
    public class ProductoBL
    {
        ProductoADO objProductoADO = new ProductoADO();

        public DataTable ListarProducto()
        {
            return objProductoADO.ListarProducto();
        }
        public ProductoBE ConsultarProducto(String strCodigo)
        {
            return objProductoADO.ConsultarProducto(strCodigo);
        }

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.InsertarProducto(objProductoBE);
        }
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.ActualizarProducto(objProductoBE);
        }
        public Boolean EliminarProducto(String strCodigo)
        {
            return objProductoADO.EliminarProducto(strCodigo);
        }
        public DataTable CantidadProductosPorTipoInventario()
        {
            return objProductoADO.CantidadProductosPorTipoInventario();
        }
        public DataTable ConsultarProductoCategoria(String Cod_area, String Cod_sec,String Cod_lin, String Cod_fam,String Cod_subFam)
        {
            return objProductoADO.ConsultarProductosCategoria(Cod_area, Cod_sec, Cod_lin, Cod_fam, Cod_subFam);

        }

        public DataTable LlenarCantidadProductosPorTipoInventario()
        {
            return objProductoADO.LlenarCantidadProductosPorTipoInventario();
        }

        public DataTable ListarProductosFechaRegistro(String strCodigo, DateTime fecIni, DateTime fecFin)
        {
            return objProductoADO.ListarProductosFechaRegistro(strCodigo, fecIni, fecFin);
        }

        public String RegistrarProductoInvent(ProductoBE objProductoBE)
        {
            return objProductoADO.RegistrarProductoInvent(objProductoBE);
        }
        public DataTable ListarRegistroDetalleProducto()
        {
            return objProductoADO.ListarRegistroDetalleProducto();
        }
    }
}
