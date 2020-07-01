using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerreteriaWF.Clases;

namespace FerreteriaWF.Vistas
{
    public partial class EditProducto : Form
    {
        ConexionBD conexion;
        List<Producto> productos;
        List<string> nombres;
        List<string> rubros;
        Producto viejo;

        public EditProducto(ConexionBD con)
        {
            InitializeComponent();
            conexion = con;
            productos = con.ListaProductos();
            nombres = new List<string>();
            for(int i = 0; i < productos.Count; i++)
            {
                nombres.Add(productos[i].Nombre);
            }

            List<Rubro> r = con.ListaRubros();
            rubros = new List<string>();
            for (int i = 0; i < productos.Count; i++)
            {
                rubros.Add(r[i].Nombre);
            }
            cbProductos.DataSource = nombres;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProducto_Load(object sender, EventArgs e)
        {

        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cbProductos.SelectedIndex;
            viejo = productos[ind];
            tbNombreProd.Text = productos[ind].Nombre;
            tbPrecio.Text = productos[ind].Precio.ToString();
            cbRubro.DataSource = rubros;
            int j = 0;
            while (productos[ind].Rubro.Nombre != rubros[j]) { j++; }
            cbRubro.SelectedIndex = j;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto
            {
                IdProducto = viejo.IdProducto,
                Cantidad = viejo.Cantidad,
                Nombre = tbNombreProd.Text,
                Rubro = (viejo.Rubro.Nombre == cbRubro.Text) ? viejo.Rubro : new Rubro(cbRubro.Text),
                Precio = float.Parse(tbPrecio.Text),
            };
            conexion.EditProducto(viejo, nuevo);
            this.Close();
        }
    }
}
