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
    public partial class D_Agregacion : Form
    {
        public D_Agregacion(NpgsqlConnection conection)
        {

            InitializeComponent();
            DataTable proveedor = new DataTable();
            string consulta = "select cuit,nombre from proveedor natural join vende group by cuit having count(nombrerubro) >2;";

            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(proveedor);
            tablaGroupBy.DataSource = proveedor;
        }

        private void D_Agregacion_Load(object sender, EventArgs e)
        {

        }
    }
}
