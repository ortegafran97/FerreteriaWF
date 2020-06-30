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
    public partial class Rubros : Form
    {

        public Rubros()
        {
            InitializeComponent();
        }
        public Rubros(DataTable dt)
        {
            InitializeComponent();
            tablaRubros.DataSource = dt;
        }
        public void AbrirFormHijo(Form hijo)
        {
        }
        private void Rubros_Load(object sender, EventArgs e)
        {
            
        }

        private void btNuevoRubro_Click(object sender, EventArgs e)
        {
            /*Crear rubro*/
            new NuevoRubro().Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ElimanrRubro().Show();
        }

        private void tablaRubros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
