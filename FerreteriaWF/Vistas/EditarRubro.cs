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
    public partial class EditarRubro : Form
    {
        public EditarRubro(NpgsqlConnection conection)
        {
            InitializeComponent();
            DataTable tabla = new DataTable();
            string consulta = "select * from Rubro;";

            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(tabla);
            

            //Desplegable
            List<string> lista = new List<string>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                lista.Add(tabla.Rows[i]["nombrerubro"].ToString());
            }
            comboBox1.DataSource = lista;

        }

        private void EditarRubro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            string nuevonombre;
            nuevonombre = textBox1.Text;
            string consulta = "update rubro set nombrerubro = '" + nuevonombre + "' where nombrerubro = '" + comboBox1.SelectedValue + "' ";
            //string consulta = "INSERT into Rubro VALUES ('" + nuevonombre + "');";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexion.conection);
            cmd.ExecuteNonQuery();
        }
    }
}
