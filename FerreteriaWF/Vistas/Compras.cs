using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaWF.Vistas
{
    public partial class Compras : Form
    {
        ConexionBD con;
        public Compras()
        {
            InitializeComponent();            
        }
        public Compras(ConexionBD c)
        {
            InitializeComponent();
            con = c;
            tablaCompraDetalle.DataSource = con.CompraDetalle();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btNuevaCompra_Click(object sender, EventArgs e)
        {
            new NuevaCompra(con.Productos(),con).Show();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void btBajoStock_Click(object sender, EventArgs e)
        {

        }
    }
}
