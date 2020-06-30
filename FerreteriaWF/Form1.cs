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

namespace FerreteriaWF
{
    public partial class FormFerreteria : Form
    {
        ConexionBD conexion;

        public FormFerreteria()
        {
            InitializeComponent();
            conexion = new ConexionBD();
            AbrirFormHijo(new Vistas.Inicio(conexion.UltimasCompras()));           
        }

        private void FormFerreteria_Load(object sender, EventArgs e)
        {
            
        }

        public void AbrirFormHijo(Form hijo)
        {
            //Cambia el contenido de {PanelContenedor} por {hijo}
            if (this.PanelContenedor.Controls.Count > 0) this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = hijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new Vistas.Inicio());
            AbrirFormHijo(new Vistas.Inicio(conexion.UltimasCompras()));
        }

        private void btCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Vistas.Compras(conexion));
        }

        private void btStock_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new Vistas.Stock());
            DataTable dt = conexion.Productos();
            AbrirFormHijo(new Vistas.Stock(dt));
        }

        private void btProveedores_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new Vistas.Proveedores());
            DataTable dt = conexion.Proveedores();
            AbrirFormHijo(new Vistas.Proveedores(dt));
        }

        private void btRubros_click(object sender, EventArgs e)
        {
            DataTable rubros = conexion.Rubros();
            AbrirFormHijo(new Vistas.Rubros(rubros));
        }
        private void btNuevoRubros_click(object sender, EventArgs e)
        {
            DataTable rubros = conexion.Rubros();
            AbrirFormHijo(new Vistas.NuevoRubro());
        }

        private void FormFerreteria_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion.Cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new group().Show();
            AbrirFormHijo(new Vistas.C_GroupBy(conexion.conection));
        }
    }
}
