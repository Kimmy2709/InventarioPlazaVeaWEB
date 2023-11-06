using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_ADO
{
    internal class ConexionADO
    {
        public string GetCnx()
        {
            String strCnx = ConfigurationManager.ConnectionStrings["PlazaVea"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}
