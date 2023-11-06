using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_BE
{
    public class ProveedorBE
    {
        public String Cod_prov { get; set; }
        public String Raz_soc_prov { get; set; }
        public String Ruc_prov { get; set; }
        public String Dir_prov { get; set; }
        public String Telf_prov { get; set; }
        public String Email_prov { get; set; }
        public Int16 Estd_prov { get; set; }
        public String Id_Ubigeo { get; set; }
        public String departamento { get; set; }
        public String provincia { get; set; }
        public String distrito { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod{ get; set; }
     
    }
}
