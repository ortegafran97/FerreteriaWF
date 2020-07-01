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
            DataTable tabla = new DataTable();
            string consulta = "select * from producto  where precio = (select max(precio) from producto);";

            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(tabla);
            tablaAgregacion.DataSource = tabla;
        }

        private void D_Agregacion_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
