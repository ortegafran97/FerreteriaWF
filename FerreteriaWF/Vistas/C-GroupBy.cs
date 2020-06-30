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
    public partial class C_GroupBy : Form
    {
        //private NpgsqlConnection conection;
        //private string stringConnection = "Username= postgres; Password = 123; Host= localhost;Port =5432 ; Database = Ferreteria";

        public C_GroupBy(NpgsqlConnection conection)
        {
            // Conexion
            //ConexionBD conexion = new ConexionBD();
            //conection = new NpgsqlConnection(stringConnection);
            
            DataTable proveedor = new DataTable();
            string consulta = "select cuit,nombre from proveedor natural join vende group by cuit having count(nombrerubro) >2;";
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(proveedor);
            InitializeComponent();
            tablaGroupBy.DataSource = proveedor;
        }

        private void C_GroupBy_Load(object sender, EventArgs e)
        {
            ////Desplegable
            //DataTable rubros = conexion.Rubros();
            //List<string> lista = new List<string>();
            //for (int i = 0; i < rubros.Rows.Count; i++)
            //{
            //    //string item = rubros.Rows[i]["nombrerubro"].ToString();/* + ": $ " + provsPrecio.Rows[i]["precio"].ToString();*/
            //    lista.Add(rubros.Rows[i]["nombrerubro"].ToString());
            //}
            ////cbRubro.DataSource = lista;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
