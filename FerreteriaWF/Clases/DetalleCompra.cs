using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaWF.Clases
{
    public class DetalleCompra
    {
        float precio,total;
        int cantidad, idproducto;
        public DetalleCompra()
        {
            total = precio = cantidad = 0;
        }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public int Idproducto { get { return idproducto; } set { idproducto = value; } }
        public float Precio { get { return precio; } set { precio = value; } }
        //public float Total{ get => (precio * cantidad); set; }
        public float getTotal()
        {
            return Cantidad * Precio;
        }
    }
}
