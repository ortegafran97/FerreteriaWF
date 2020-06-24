using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FerreteriaWF.Clases
{
    public class Compra
    {
        int idCompra;
        string cuit;
        DateTime fecha;
        List<DetalleCompra> items;
        float total;

        public Compra()
        {
            items = new List<DetalleCompra>();
            fecha = DateTime.Now;
            total = 0;
        }
        public Compra(int idC,string Cuit)
        {
            idCompra = idC;
            this.cuit = Cuit;
            fecha = DateTime.Now;
            items = new List<DetalleCompra>();
            total = 0;
        }        
        public void AgregarItem(DetalleCompra deta)
        {
            items.Add(deta);

            float t = 0;
            foreach (DetalleCompra det in items)
            {
                t = t + det.Precio;
            }
            total = t;
        }
        public DetalleCompra getItemCompra(int i)
        {
            return items[i];
        }
        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }
        public string CUIT
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public float Total
        {
            get
            {
                float x = 0;
                foreach (DetalleCompra d in items)
                {
                    x += d.getTotal();
                }
                return x;
            }
            set { total = value; }
        }
        public List<DetalleCompra> Items
        {
            get { return items; } }

    }
}
