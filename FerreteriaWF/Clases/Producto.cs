using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FerreteriaWF.Clases
{
    public class Producto
    {
        string nombre;
        int idProd,cant;
        float precio;
        Ubicacion ubic;

        public Producto (DataRow s)
        {
            nombre = s["nombre"].ToString();
            idProd = int.Parse(s["idprod"].ToString());
            precio = float.Parse(s["precio"].ToString());
            cant = int.Parse(s["cantidad"].ToString());
            //TODO: cambiar ubicacion
            ubic = null;
        }
        public Producto()
        {

        }

        public string Nombre { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public Ubicacion Ubic { get; set; }
        
    }
}
