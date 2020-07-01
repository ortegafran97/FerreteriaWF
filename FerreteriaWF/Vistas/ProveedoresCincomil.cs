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
    public partial class ProveedoresCincomil : Form
    {
        ConexionBD con;
        public ProveedoresCincomil()
        {
            InitializeComponent();
        }
        
        public ProveedoresCincomil(ConexionBD c)
        {
            InitializeComponent();
            con = c;
            dataGridView1.DataSource = con.ProveedoresCincomil();
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
