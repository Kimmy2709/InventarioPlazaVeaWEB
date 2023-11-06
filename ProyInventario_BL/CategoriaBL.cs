using ProyInventario_ADO;
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
    public class CategoriaBL
    {
        CategoriaADO objCategoriaADO = new CategoriaADO();

        public DataTable Producto_Area()
        {
            return objCategoriaADO.Producto_Area();
        }
        public DataTable Producto_SeccionArea(String strCodArea)
        {
            return objCategoriaADO.Producto_SeccionArea(strCodArea);
        }
        public DataTable Producto_LineaSeccionArea(String strCodArea, String strCodSec)
        {
            return objCategoriaADO.Producto_LineaSeccionArea(strCodArea, strCodSec);
        }
        public DataTable Producto_FamiliaLineaSeccionArea(String strCodArea, String strCodSec,String strCodLin)
        {
            return objCategoriaADO.Producto_FamiliaLineaSeccionArea(strCodArea, strCodSec, strCodLin);
        }
        public DataTable Producto_SubFamiliafamiliaLineaSeccionArea(String strCodArea, String strCodSec, String strCodLin,String strCodFam)
        {
            return objCategoriaADO.Producto_SubFamiliafamiliaLineaSeccionArea(strCodArea, strCodSec,strCodLin,strCodFam);
        }

    }
}
