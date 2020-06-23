using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FerreteriaWF.Clases
{
    class Compra
    {
        int idCompra;
        string cuit;
        DateTime fecha;
        List<DetalleCompra> items;

        public Compra(int idC,string Cuit)
        {
            idCompra = idC;
            this.cuit = Cuit;
            fecha = DateTime.Now;
            items = new List<DetalleCompra>();
        }
        public void AgregarItem(Producto p, int cant)
        {
            /**
             * Tomar el precio en el que se realiza la compra, que no se modifique desps
             * tomamos la cantidad que compramos, no la que poseemos en stock
             */
            DetalleCompra d = new DetalleCompra();
            d.Cantidad = cant;
            d.IdProducto = p.IdProducto;
            d.Precio = p.Precio;
            items.Add(d);
        }
    }
}
