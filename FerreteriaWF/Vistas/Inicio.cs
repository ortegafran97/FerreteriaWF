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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        public Inicio(DataTable compras)
        {
            InitializeComponent();
            tablaCompras.DataSource = compras;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
