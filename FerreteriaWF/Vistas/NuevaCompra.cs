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

namespace FerreteriaWF.Vistas
{
    public partial class NuevaCompra : Form
    {        
        List<string> prods;
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
            DataTable provs = conexion.VendedoresDeProducto(nomp);
            List<string> lista = new List<string>();

            for(int i = 0; i < provs.Rows.Count; i++)
            {
                string item = provs.Rows[i]["nombre"].ToString() + ": $" + provs.Rows[i]["precio"].ToString();
                lista.Add(item);
            }
            cbProveedores.DataSource = lista;
        }
    }
}
