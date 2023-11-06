using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyInventario_BE;
using ProyInventario_ADO;
namespace ProyInventario_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();
        public UsuarioBE ConsultarUsuario(String strCodigo)
        {
            return objUsuarioADO.ConsultarUsuario(strCodigo);
        }
    }
}
