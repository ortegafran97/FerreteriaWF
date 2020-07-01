using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerreteriaWF.Clases;

namespace FerreteriaWF.Vistas
{
    public partial class NuevoProveedor : Form
    {
        ConexionBD conexion;
        public NuevoProveedor(ConexionBD con)
        {
            InitializeComponent();
            conexion = con;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor
            {
                CUIT = tbCuit.Text,
                Nombre = tbNombre.Text,
                Direccion = tbDireccion.Text
            };
            conexion.NuevoProveedor(p);
            this.Close();
        }
    }
}
