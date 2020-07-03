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
    public partial class ProveedoresYRubros : Form
    {
        ConexionBD con;
        public ProveedoresYRubros()
        {
            InitializeComponent();
        }
        public ProveedoresYRubros(ConexionBD c)
        {
            InitializeComponent();
            con = c;
            dataGridView1.DataSource = con.ProveedoresRubros();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     

    }
}
