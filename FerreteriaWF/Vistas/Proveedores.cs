﻿using System;
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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }
         public Proveedores(DataTable dt)
        {
            InitializeComponent();
            tablaProveedores.DataSource = dt;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btNuevoProveedor_Click(object sender, EventArgs e)
        {
            new NuevoProveedor(new ConexionBD()).Show();
        }
    }
}
