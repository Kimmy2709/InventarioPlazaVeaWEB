using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_BE
{
    public class ProductoBE
    {
        public Int16 Cod_pro { get; set; }
        public String Dscp_pro { get; set; }
        public Single Pre_pro { get; set; }
        public Int16 Stk_min { get; set; }
        public Int16 Stk_act { get; set; }        
        public Int16 Estd_pro { get; set; }
        public String Cod_area { get; set; }
        public String Cod_sec { get; set; }
        public String Cod_lin { get; set; }
        public String Cod_fam { get; set; }
        public String Cod_sub { get; set; }
        public String Cod_uni { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }

        private DataTable Detalles;
        public DataTable DetallesProducto
        {
            get { return Detalles; }
            set { Detalles = value; }

        }
    }
}
