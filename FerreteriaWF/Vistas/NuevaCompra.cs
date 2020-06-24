using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using FerreteriaWF.Clases;

namespace FerreteriaWF.Vistas
{
    public partial class NuevaCompra : Form
    {        
        List<string> prods;
        DataTable provsPrecio;        
        ConexionBD conexion;

        public NuevaCompra()
        {
            InitializeComponent();                      
        }
        public NuevaCompra(DataTable productos,ConexionBD conec) // Recibe tabla de productos
        {
            InitializeComponent();
            conexion = conec;
            prods = new List<string>();           
            for(int i = 0; i < productos.Rows.Count; i++) { prods.Add(productos.Rows[i]["nombreproducto"].ToString()); }
            cbProductos.DataSource = prods;
        }

        private void NuevaCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e) //Llena el listado de proveedores del producto seleccionado
        {            
            string nomp = cbProductos.Text;
            provsPrecio = conexion.VendedoresDeProducto(nomp);
            List<string> lista = new List<string>();

            for(int i = 0; i < provsPrecio.Rows.Count; i++)
            {
                string item = provsPrecio.Rows[i]["nombre"].ToString();/* + ": $ " + provsPrecio.Rows[i]["precio"].ToString();*/
                lista.Add(item);
            }
            cbProveedores.DataSource = lista;
        }

        private void contadorCantidad_ValueChanged(object sender, EventArgs e)
        {
            
            lblTotal.Text = "";
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //TODO: se puede/deberia adaptar para 'agregar a carrito' y tener muchos items por compra
            Compra compra = new Compra();
            Producto p = conexion.Producto(cbProductos.Text);

            DetalleCompra detalle = new DetalleCompra();
            detalle.Cantidad = int.Parse(contadorCantidad.Text);
            detalle.Precio = float.Parse(tbCosto.Text);
            //float TOTAL = detalle.getTotal();

            string nombreProd = cbProductos.Text;
            int idpr = conexion.Producto(nombreProd).IdProducto;
            detalle.Idproducto = idpr;


            compra.CUIT = conexion.CUIT(cbProveedores.Text);
            compra.AgregarItem(detalle);           


            conexion.NuevaCompra(compra);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
