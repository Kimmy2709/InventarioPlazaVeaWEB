using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_BE
{
    public class EmpleadoBE
    {
        public String Cod_emple { get; set; }
        public String Nom_emple { get; set; }
        public String Ape_emple { get; set; }
        public String Dni_emple { get; set; }
        public String Dir_emple { get; set; }
        public String Telf_emple { get; set; }
        public Single Sue_emple { get; set; }
        public Int16 Estd_emple { get; set; }
        public String Login_Usuario { get; set; }
        public String Pass_Usuario { get; set; }
        public String TipoUsuario { get; set; }

        public String Tipo_Usuario { get; set; }
        public String Estado { get; set; }
        public String Id_Ubigeo { get; set; }
        public String Departamento { get; set; }
        public String Provincia { get; set; }
        public String Distrito { get; set; } 
        public DateTime Fec_Registro { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public Byte[]  Foto_emple { get; set; }
    }
}
