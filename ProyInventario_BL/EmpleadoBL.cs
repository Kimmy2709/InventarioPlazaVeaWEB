using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyInventario_ADO;
using ProyInventario_BE;

namespace ProyInventario_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objEmpleadoBE);
        }
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(objEmpleadoBE);
        }
        public Boolean EliminarEmpleado(String strCodigo)
        {
            return objEmpleadoADO.EliminarEmpleado(strCodigo);
        }

        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {
            return objEmpleadoADO.ConsultarEmpleado(strCodigo);
        }

        public DataTable ListarEmpleado()
        {
            return objEmpleadoADO.ListarEmpleado();
        }
    }
}
