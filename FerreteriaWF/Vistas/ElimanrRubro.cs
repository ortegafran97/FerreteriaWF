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
    public partial class ElimanrRubro : Form
    {
        private NpgsqlConnection conection;
        private string stringConnection = "Username= postgres; Password = 123; Host= localhost;Port =5432 ; Database = Ferreteria";

 
        public ElimanrRubro()
        {
            InitializeComponent();

            // Conexion
            ConexionBD conexion = new ConexionBD();
            conection = new NpgsqlConnection(stringConnection);
            conection.Open();
            //Desplegable
            DataTable rubros = conexion.Rubros();
            List<string> lista = new List<string>();
            for (int i = 0; i < rubros.Rows.Count; i++)
            {
                //string item = rubros.Rows[i]["nombrerubro"].ToString();/* + ": $ " + provsPrecio.Rows[i]["precio"].ToString();*/
                lista.Add(rubros.Rows[i]["nombrerubro"].ToString());
            }
            cbRubro.DataSource = lista;


            
        }

        private void ElimanrRubro_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = cbRubro.SelectedValue.ToString();
            string consulta = "delete from rubro where  nombrerubro='" + nombre + "';";
            try { 
                NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
                cmd.ExecuteNonQuery();
                label1.Text = "eliminado con extio";
            }catch(Exception a)
            {
                label1.Text = a.Message;
                Console.WriteLine("Error de conexion: " + a.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
