using ProyInventario_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_BL
{
    public class EmpleadoTipoUsuarioBL
    {
        EmpleadoTipoUsuarioADO objEmpleadoTipoUsuarioADO = new EmpleadoTipoUsuarioADO();


        public DataTable ListarTipoUsuario()
        {
            return objEmpleadoTipoUsuarioADO.ListarTipoUsuario();
        }
    }
}
