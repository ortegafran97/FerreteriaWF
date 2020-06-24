using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using FerreteriaWF.Clases;


namespace FerreteriaWF.Vistas
{
    public partial class NuevoRubro : Form
    {
        public NuevoRubro()
        {
            InitializeComponent();
        }

        private void NuevoRubro_Load(object sender, EventArgs e)
        {
            //AbrirFormHijo(new Vistas.Proveedores(dt));

        }

        private void CrearNuevoRubro(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            string nombre = textBox1.Text;
            int b =conexion.InsertRubro(nombre);
            if (b == 1)
            {
                label1.Visible = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
