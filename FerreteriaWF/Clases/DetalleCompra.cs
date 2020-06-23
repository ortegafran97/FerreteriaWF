using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteriaWF.Clases
{
    class DetalleCompra
    {
        float precio,total;
        int cant, idProd;
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
        public float Precio { get; set; }
        public float Total { get; set; }
    }
}
