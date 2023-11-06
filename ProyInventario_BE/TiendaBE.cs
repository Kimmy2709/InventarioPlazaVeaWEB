using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_BE
{
    public class TiendaBE
    {
        public Int16 Cod_tiend { get; set; }
        public String Nom_tiend { get; set; }
        public String Dir_tiend { get; set; }
        public String Telf_tiend { get; set; }
        public String Id_Ubigeo { get; set; }
        public String Departamento { get; set; }
        public Int16 Provincia { get; set; }
        public String Distrito { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public Int16 Estd_tiend { get; set; }
    }
}
