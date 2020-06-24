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
    public partial class Stock : Form
    {
        //TODO: agregar combobox de rubros para ver sus rubros
        public Stock()
        {
            InitializeComponent();
        }
        public Stock(DataTable dt)
        {
            InitializeComponent();
            tablaProductos.DataSource = dt;
        }


        private void Stock_Load(object sender, EventArgs e)
        {
        }
    }
}
