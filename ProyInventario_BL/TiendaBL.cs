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
    public class TiendaBL
    {
        TiendaADO objTiendaADO = new TiendaADO();

        public Boolean InsertarTienda(TiendaBE objTiendaBE)
        {
            return objTiendaADO.InsertarTienda(objTiendaBE);
        }
        public Boolean ActualizarTienda(TiendaBE objTiendaBE)
        {
            return objTiendaADO.ActualizarTienda(objTiendaBE);
        }
        public Boolean EliminarTienda(String strcod)
        {
            return objTiendaADO.EliminarTienda(strcod);
        }

        public TiendaBE ConsultarTienda(String strcod)
        {
            return objTiendaADO.ConsultarTienda(strcod);
        }

        public DataTable ListarTienda()
        {
            return objTiendaADO.ListarTienda();
        }

        public DataTable TiendasPorDistrito()
        {
            return objTiendaADO.TiendasPorDistrito();
        }
    }
}
