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
        Rubro rubro;

        public Producto (DataRow s)
        {
            nombre = s["nombreproducto"].ToString();
            idProd = int.Parse(s["idprod"].ToString());
            precio = float.Parse(s["precio"].ToString());
            cant = int.Parse(s["cantidad"].ToString());
            rubro = new Rubro();
            rubro.Nombre = s["nombrerubro"].ToString();

            //TODO: cambiar ubicacion
            ubic = null;
        }
        public Producto()
        {

        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public int IdProducto {
            get { return idProd; }
            set { idProd = value; }
        }
        public int Cantidad {
            get { return cant; }
            set { cant = value; }
        }
        public float Precio {
            get { return precio; }
            set { precio = value; }
        }
        public Ubicacion Ubic {
            get { return ubic; }
            set { ubic = value; }
        }
        
    }
}
